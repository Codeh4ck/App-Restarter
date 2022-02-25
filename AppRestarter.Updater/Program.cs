using System;
using System.Linq;
using System.IO;
using System.IO.Compression;
using System.Diagnostics;
using System.Windows.Forms;

namespace AppRestarter.Updater
{
    internal static class Program
    {
        private static Guid _sessionId;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            _sessionId = Guid.NewGuid();

            if (!ValidateFiles()) Environment.Exit((int)ExitCodes.CouldNotValidateUpdateFiles);
            if (!KillAppRestarter()) Environment.Exit((int)ExitCodes.CouldNotKillAppRestarter);
            if (!BackupCurrentAppRestarter()) Environment.Exit((int)ExitCodes.CouldNotBackupAppRestarterFiles);
            if (!ExtractNewAppRestarter()) Rollback(ExitCodes.CouldNotInstallNewAppRestarterFiles);
            if (!CleanupAndRestart()) Environment.Exit((int)ExitCodes.CouldNotCleanupUpdateFiles);

            Environment.Exit(0);
        }

        private static bool ValidateFiles()
        {
            string path = Application.StartupPath;
            string appRestarterZip = Path.Combine(path, "AppRestarter.zip");

            if (!File.Exists(appRestarterZip)) return false;

            using FileStream fileStream = new(appRestarterZip, FileMode.Open);
            using ZipArchive zipArchive = new(fileStream, ZipArchiveMode.Read, false);

            return zipArchive.Entries.Any(x =>
                x.FullName.ToLower().Contains(".exe") ||
                x.FullName.ToLower().Contains(".dll"));
        }

        private static bool KillAppRestarter()
        {
            Process[] processes = Process.GetProcessesByName("AppRestarter");

            if (processes.Length > 0)
                foreach (Process process in processes)
                    process.Kill();

            return processes.Length > 0;
        }

        private static bool BackupCurrentAppRestarter()
        {
            string tempZipBackupFile = $"{_sessionId.ToString("N").Substring(0, 16)}.zip";
            if (File.Exists(tempZipBackupFile)) File.Delete(tempZipBackupFile);

            using FileStream fileStream = new(tempZipBackupFile, FileMode.Create);
            using ZipArchive zipArchive = new(fileStream, ZipArchiveMode.Create, false);

            try
            {
                foreach (string file in Directory.GetFiles(Application.StartupPath).Where(x => Path.GetExtension(x) != ".zip"))
                {
                    ZipArchiveEntry entry = zipArchive.CreateEntry(Path.GetFileName(file), CompressionLevel.Optimal);
                    entry.LastWriteTime = File.GetLastWriteTime(file);

                    using FileStream entryFileStream = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                    using Stream entryStream = entry.Open();
                    entryFileStream.CopyTo(entryStream, 81920);
                }

                return true;
            }
            catch
            {
                fileStream.Close();
                zipArchive.Dispose();

                File.Delete(tempZipBackupFile);

                return false;
            }
        }

        private static bool ExtractNewAppRestarter()
        {
            string path = Application.StartupPath;
            string appRestarterZip = Path.Combine(path, "AppRestarter.zip");

            if (!File.Exists(appRestarterZip)) return false;

            using FileStream fileStream = new(appRestarterZip, FileMode.Open);
            using ZipArchive zipArchive = new(fileStream, ZipArchiveMode.Read, false);

            try
            {
                foreach (ZipArchiveEntry entry in zipArchive.Entries.Where(x =>
                             x.FullName.Contains(".exe") || x.FullName.Contains(".dll")))
                    entry.ExtractToFile(entry.Name, true);

                return true;
            }
            catch
            {
                return false;
            }
        }

        private static bool CleanupAndRestart()
        {
            string tempZipBackupFile = $"{_sessionId.ToString("N").Substring(0, 16)}.zip";
            if (File.Exists(tempZipBackupFile)) File.Delete(tempZipBackupFile);
            if (File.Exists("AppRestarter.zip")) File.Delete("AppRestarter.zip");
            if (!File.Exists("AppRestarter.exe")) return false;

            ProcessStartInfo startInfo = new("AppRestarter.exe")
            {
                WindowStyle = ProcessWindowStyle.Normal,
                CreateNoWindow = false,
                WorkingDirectory = Application.StartupPath
            };

            Process.Start(startInfo);

            return true;
        }

        private static void Rollback(ExitCodes exitCode)
        {
            string tempZipBackupFile = $"{_sessionId.ToString("N").Substring(0, 16)}.zip";

            if (!File.Exists(tempZipBackupFile)) Environment.Exit((int)ExitCodes.CouldNotRollbackUpdate);

            using FileStream fileStream = new(tempZipBackupFile, FileMode.Open);
            using ZipArchive zipArchive = new(fileStream, ZipArchiveMode.Read, false);

            try
            {
                foreach (ZipArchiveEntry entry in zipArchive.Entries)
                    entry.ExtractToFile(entry.Name, true);

                Environment.Exit((int)exitCode);
            }
            catch
            {
                Environment.Exit((int)ExitCodes.CouldNotRollbackUpdate);
            }
        }
    }
}
