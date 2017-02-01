# iTrellis TodoList Test Program
### By Jonathan Tiefer
This is the complete solution of the Todo List test application program developed for iTrellis.  The test program was developed using the To-Do List with a Native GUI interface written in the language of C# and using the .Net WinForms framework.  This program utilizes the .Net Framework 4.6.1 framework.  In addition, my own personal open source DotCoolControls were used to develop the UI.  In addition, the Moq framework is used in the Testing project for some of the unit testing procedures.   The following are the instructions of how to properly install the program so it can be loaded and compiled in Visual Studio 2015 and later.  




## SQL Server Installation
The SQL Server database engine is used as the backend data source for the Todo List application.  TodoDB.mdf is the name of the database file used by the TodoList application.  It will be necessary to attach the TodoDB database to an existing or new instance of SQL Server installed on the machine.   I've included a TodoDBAttach script file and a TodoDBAttach batch file to ease with the process of attaching the database file to the instance.  In addition to attaching the database, you must update the connection strings in the Trellis.TodoData project so that they are referencing the SQL Server instance to which you have attached the TodoDB database file.  


## Attaching TodoDB Database to SQL Server Instance
Here is a detailed, step-by-step set of instructions on how to attach the database to the SQL Server instance on your machine:
1. Launch the TrellisTodo solution in Visual Studio as an Administrator.
2. Locate the file 'TodoDBAttach.bat' in the Solution Items folder of the solution.  This file is contained in the root directory of the TrellisTodo solution.
3. Open the TodoDBAttach.bat file and modify the connection string Data Source so that the SQL Server instance matches the instance of the server to which you wish to attach the Todo database file. 
4. After modifying the Server instance in the TodoDBAttach.bat file, save the file.
5. Once the file is saved, right click in Solution Explorer on the TodoDBAttach.bat file and Click "Execute File."  This will launch the sqlcmd command via a script that will attach the TodoDBAttach database to the SQL Server instance.  
(NOTE: This can also be done from DOS or File Explorer, but also requires Administrator access).

## Modifying SQL Server Connection Strings in Trellis.TodoData Project
Here is step-by-step instructions on how to modify the SQL Server connection string of the TodoDB database from Visual Studio:
1. The TodoList application uses a connection string with the name of 'TodoDBConnectionString'.
2. Locate and expand the Properties folder of the Trellis.TodoData project.
3. Double-Click the Settings.settings file in the Properties folder which will launch the Trellis.TodoData settings window.
4. Locate the TodoDBConnectionString setting in the list of the window.
5. Edit the 'Value' column of the connection string and replace the Data Source so that the SQL Server instance matches the instance of the local server to which you have attached the TodoDB database file.
6. Save the project to update the new settings in the TodoDBConnectionString.
7. Saving this setting in Visual Studio should also update the App.config file, but double-click on the App.config file in the Trellis.TodoData project to verify the connection string settings have been updated.  If the settings have not been updated, update the DataSource in the App.Config to match that in the Settings.settings file.

## NuGet Package Installation
The application only contains one NuGet package installation which is the Moq library.  I've provided the list of all steps required to install all Nuget packages into the solution.

## Moq Nuget Installation Instructions
1. Display the Package Manager Console in Visual Studio and set the Package source drop down value to 'nuget.org'.
2. In the command line enter the following to install the Moq 4.5.30 library and its dependency libraries:
   "Install-Package Moq -Version 4.5.30 -ProjectName Trellis.TodoTests"

3. This will install and add the Moq library package to the Trellis.TodoTests which will be used for unit testing in the project.

## DotCoolControls
The TodoUI project uses a set of open source controls that I personally developed called DotCoolControls.  The set of DotCoolControl library dll files will be contained the DotCoolControlsLib subdirectory of the Trellis.TodoUI project.  These libraries will be referenced by the project and contain several UI controls, some of which will be displayed in the TodoList application's UI.  If it is desired to add these controls to the toolbox, it will be necessary to locate these dll files in the DotCoolControlsLib subdirectory when adding the controls to the toolbox of Visual Studio.  

The following files are assocaited with the DotCoolControls UI library which are used in the application:
DotCoolControls.DotCoolBase.dll
DotCoolControls.Tools.dll
DotCoolControls.WinForms.dll
Tiferix.Global.dll

## Tiferix.Global
This library contains some shared utility functions used throughout the applications.  Each project that references Tiferix.Global will have a local reference in the project's directory (or a subdirectory) containing a reference to this dll.  