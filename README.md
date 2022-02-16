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

**Note: Each application is monitored a separate background thread.**

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

## Additional features

AppRestarter offers basic event logging for each application. You will need to enable `Log application events` when you add an application on AppRestarter in order to monitor what happens behind the scene. You can either view logs on a separate window or save them in a directory of your choice. Additionally, you can choose to keep logs in a single file or separately per application. 

AppRestarter can also be started automatically with Windows. All you have to do is enable the respective setting in AppRestarter's settings. Keep in mind that AppRestarter will not automatically start your applications on Windows startup to prevent issues such as slow startup or antivrus false-positives. You will need to start AppRestarter's monitoring manually, once per Windows boot.

Finally, AppRestarter will automatically save your monitor applications when you close the main window. You will not need to re-add each time you run AppRestarter. Save, update and loading is done automatically for you.

# Screenshots
[![Main-Window.png](https://i.postimg.cc/5NjLCg8F/Main-Window.png)](https://postimg.cc/dLPhM8Hq)

[![Add-Application.png](https://i.postimg.cc/wjmNWBfq/Add-Application.png)](https://postimg.cc/4YXnyXRq)

# Contributing

## Found an issue?

Please report any issues you have found by [creating a new issue](https://github.com/Codeh4ck/App-Restarter/issues). We will review the case and if it is indeed a problem with the code, I will try to fix it as soon as possible. I want to maintain a healthy and bug-free standard for our code. Additionally, if you have a solution ready for the issue please submit a pull request. 

## Submitting pull requests

Before submitting a pull request to the repository please ensure the following:

* Your code follows the naming conventions [suggested by Microsoft](https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/naming-guidelines)
* Your code works flawlessly, is fault tolerant and it does not break the library or aspects of it
* Your code follows proper object oriented design principles. Use interfaces!

Your code will be reviewed and if it is found suitable it will be merged. Please understand that the final decision always rests with me. By submitting a pull request you automatically agree that I hold the right to accept or deny a pull request based on my own criteria.

## Contributor License Agreement

By contributing your code to AppRestarter you grant Nikolas Andreou a non-exclusive, irrevocable, worldwide, royalty-free, sublicenseable, transferable license under all of Your relevant intellectual property rights (including copyright, patent, and any other rights), to use, copy, prepare derivative works of, distribute and publicly perform and display the Contributions on any licensing terms, including without limitation: (a) open source licenses like the MIT license; and (b) binary, proprietary, or commercial licenses. Except for the licenses granted herein, You reserve all right, title, and interest in and to the Contribution.

You confirm that you are able to grant us these rights. You represent that you are legally entitled to grant the above license. If your employer has rights to intellectual property that you create, You represent that you have received permission to make the contributions on behalf of that employer, or that your employer has waived such rights for the contributions.

You represent that the contributions are your original works of authorship and to your knowledge, no other person claims, or has the right to claim, any right in any invention or patent related to the contributions. You also represent that you are not legally obligated, whether by entering into an agreement or otherwise, in any way that conflicts with the terms of this license.

Nikolas Andreou acknowledges that, except as explicitly described in this agreement, any contribution which you provide is on an "as is" basis, without warranties or conditions of any kind, either express or implied, including, without limitation, any warranties or conditions of title, non-infringement, merchantability, or fitness for a particular purpose.