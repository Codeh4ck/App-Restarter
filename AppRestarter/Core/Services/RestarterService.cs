using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using AppRestarter.Models;
using AppRestarter.Core.Observers;

namespace AppRestarter.Core.Services
{
    public class RestarterService : SingletonBase<IRestarterService, RestarterService>, IRestarterService
    {
        private readonly ILogService _logService;
        private readonly IRestartObserver _restartObserver;
        private readonly ICrashMonitorService _crashMonitorService;

        private static readonly TimeSpan CrashThresholdTimespan = TimeSpan.FromMilliseconds(500);

        public RestarterService()
        {
            _logService = LogService.GetInstance();
            _restartObserver = RestartObserver.GetInstance();
            _crashMonitorService = CrashMonitorService.GetInstance();
        }

        public int RestartApplication(WatchedApp app)
        {
            _logService.AddLog(app, "Attempting to restart application...");

            string fullPath = Path.Combine(app.BaseDirectory, app.ExecutableName);
            string arguments = app.Arguments.Count > 0 ? BuildArguments(app.Arguments) : string.Empty;

            ProcessStartInfo startInfo;

            // TODO: Replace this ugly way with an enum & switch
            if (app.RunThroughCmd)
            {
                startInfo = new("cmd.exe", $"/c {fullPath} {arguments}")
                {
                    WindowStyle = (app.ShowWindow) ? ProcessWindowStyle.Normal : ProcessWindowStyle.Hidden,
                    WorkingDirectory = app.BaseDirectory,
                    UseShellExecute = false
                };
            }
            else if (app.PassCmdArgsOnly)
            {
                startInfo = new("cmd.exe", $"/c {arguments}")
                {
                    WindowStyle = (app.ShowWindow) ? ProcessWindowStyle.Normal : ProcessWindowStyle.Hidden,
                    WorkingDirectory = app.BaseDirectory,
                    UseShellExecute = true
                };
            }
            else
            {
                startInfo = new(fullPath, arguments)
                {
                    WindowStyle = (app.ShowWindow) ? ProcessWindowStyle.Normal : ProcessWindowStyle.Hidden,
                    WorkingDirectory = app.BaseDirectory,
                };
            }

            Stopwatch stopwatch = new();

            Process process = new()
            {
                StartInfo = startInfo,
                EnableRaisingEvents = true
            };

            process.Exited += OnProcessOnExited;

            void OnProcessOnExited(object o, EventArgs eventArgs)
            {
                stopwatch.Stop();

                if (process.ExitCode != 0)
                {
                    if (stopwatch.Elapsed <= CrashThresholdTimespan)
                        _crashMonitorService.RegisterCrashedApp(app);
                }
            }

            process.Start();
            stopwatch.Start();

            int processId = process?.Id ?? -1;

            if (processId != -1)
            {
                _restartObserver.NotifyRestart(app);
                _logService.AddLog(app, "Application restarted successfully!");
            }
            else
                _logService.AddLog(app, "Could not restart application.");

            return processId;
        }

        private string BuildArguments(List<CmdArgument> arguments)
        {
            StringBuilder argumentBuilder = new();

            foreach (CmdArgument argument in arguments)
                argumentBuilder.Append($"{argument.Argument} {argument.Value} ");

            return argumentBuilder.ToString();
        }
    }
}
