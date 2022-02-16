# AppRestarter

AppRestarter is a software that enables application monitoring and smart restarting based on user-defined configuration. AppRestarter allows you to choose executable files and watch them for unexpected shutdowns. Once a monitored application is shutdown, AppRestarter will restart the application after a predefined wait period. Additionally, AppRestarter supports command-line arguments for each monitored application and 3 different execution strategies.


## Process restarting

**Each application can be executed in 3 different ways (currently). Those ways are:**
* Classic process spawning, same as double-clicking your executable
* Through command-line
* As standalone command-line command

### Classic process spawning

Classic process spawning will restart your application as if you double-clicked the executable file. You can additionally specify command-line arguments to be passed to your executable. Moreover, you can choose whether you'd like to show the process main window or run it in the background, hidden.

### Through command line

Your application will be ran inside `cmd.exe`. This is similar to typing your application's path inside `cmd.exe` or `PowerShell` and passing your desired arguments. Of course, arguments are also passable in this scenario alongside choosing whether you'd like to display the spawned command-line window. 

### As standalone command-line command

This scenario is useful for running command-line commands in predetermined periods. Instead of selecting an executable file to monitor, you will be asked to provide a base directory instead. This will be your command-line's base directory, similar to running `cd` commands. For example, one use-case scenario would be if you want to run `yarn start` on a specific directory and monitor `yarn` for unexpected shutdowns. Once `yarn` terminates, AppRestarter will re-execute the command to respawn the process.

## Configuration

AppRestarter allows a number of configurations to be specified for each application.

***Those configurations include the following:***

* Command line arguments
* Show application window
* Run application inside `cmd.exe`
* Log application events
* Polling interval, the delay between each check to determine if a given process is alive
* Restart after, the delay to wait before restarting a process

These configurations are application specific. Each application can have its own set of configurations.