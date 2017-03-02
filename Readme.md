# Tiferix TodoList Test Program
### By Jonathan Tiefer
This is the complete solution of the Todo List test application program.  The test program was developed using the To-Do List with a Native GUI interface written in the language of C# and using the .Net WinForms framework.  This program utilizes the .Net Framework 4.6.1 framework.  In addition, my own personal open source DotCoolControls were used to develop the UI.  In addition, the project utilizes unit testing of a Todo Model project that operates independently of the data backend.  This project is an example of an application that can be developed with a custom designed ORM structured library that allows for separation of front-end and back-end data layers of the application.  The following are the instructions of how to properly install the program so it can be loaded and compiled in Visual Studio 2015 and later.  




## SQL Server Installation
The SQL Server database engine is used as the backend data source for the Todo List application.  TodoDB.mdf is the name of the database file used by the TodoList application.  It will be necessary to attach the TodoDB database to an existing or new instance of SQL Server installed on the machine.   I've included a TodoDBAttach script file and a TodoDBAttach batch file to ease with the process of attaching the database file to the instance.  In addition to attaching the database, you must update the connection strings in the Tiferix.TodoData project so that they are referencing the SQL Server instance to which you have attached the TodoDB database file.  Please note in a production environment, this database would be scripted, rather than attached.  This pre-loaded database is used only for purpose of the sample application.

## Attaching TodoDB Database to SQL Server Instance
Here is a detailed, step-by-step set of instructions on how to attach the database to the SQL Server instance on your machine:<br/>
1. Launch the TiferixTodo solution in Visual Studio as an Administrator.<br/>
2. Locate the file 'TodoDBAttach.bat' in the Solution Items folder of the solution.  This file is contained in the root directory of the TiferixTodo solution.<br/>
3. Open the TodoDBAttach.bat file and modify the connection string Data Source so that the SQL Server instance matches the instance of the server to which you wish to attach the Todo database file.<br/>
4. After modifying the Server instance in the TodoDBAttach.bat file, save the file.<br/>
5. Once the file is saved, right click in Solution Explorer on the TodoDBAttach.bat file and Click "Execute File."  This will launch the sqlcmd command via a script that will attach the TodoDBAttach database to the SQL Server instance. <br/>
(NOTE: This can also be done from DOS or File Explorer, but also requires Administrator access).<br/>

## Modifying SQL Server Connection Strings in Tiferix.TodoData Project
Here is step-by-step instructions on how to modify the SQL Server connection string of the TodoDB database from Visual Studio:<br/>
1. The TodoList application uses a connection string with the name of 'TodoDBConnectionString'.<br/>
2. Locate and expand the Properties folder of the Tiferix.TodoData project.<br/>
3. Double-Click the Settings.settings file in the Properties folder which will launch the Tiferix.TodoData settings window.<br/>
4. Locate the TodoDBConnectionString setting in the list of the window.<br/>
5. Edit the 'Value' column of the connection string and replace the Data Source so that the SQL Server instance matches the instance of the local server to which you have attached the TodoDB database file.<br/>
6. Save the project to update the new settings in the TodoDBConnectionString.<br/>
7. Saving this setting in Visual Studio should also update the App.config file, but double-click on the App.config file in the Tiferix.TodoData project to verify the connection string settings have been updated.  If the settings have not been updated, update the DataSource in the App.Config to match that in the Settings.settings file.<br/>

## NuGet Package Installation
The application only contains one NuGet package installation which is the Moq library.  I've provided the list of all steps required to install all Nuget packages into the solution.

## Moq Nuget Installation Instructions
1. Display the Package Manager Console in Visual Studio and set the Package source drop down value to 'nuget.org'.<br/>
2. In the command line enter the following to install the Moq 4.5.30 library and its dependency libraries:<br/>
   "Install-Package Moq -Version 4.5.30 -ProjectName Tiferix.TodoTests"<br/>
3. This will install and add the Moq library package to the Tiferix.TodoTests which will be used for unit testing in the project.<br/>

## DotCoolControls
The TodoUI project uses a set of open source controls that I personally developed called DotCoolControls.  The set of DotCoolControl library dll files will be contained the DotCoolControlsLib subdirectory of the Tiferix.TodoUI project.  These libraries will be referenced by the project and contain several UI controls, some of which will be displayed in the TodoList application's UI.  If it is desired to add these controls to the toolbox, it will be necessary to locate these dll files in the DotCoolControlsLib subdirectory when adding the controls to the toolbox of Visual Studio.  

The following files are assocaited with the DotCoolControls UI library which are used in the application:<br/>
DotCoolControls.DotCoolBase.dll<br/>
DotCoolControls.Tools.dll<br/>
DotCoolControls.WinForms.dll<br/>
Tiferix.Global.dll<br/>

## Tiferix.Global
This library contains some shared utility functions used throughout the applications.  Each project that references Tiferix.Global will have a local reference in the project's directory (or a subdirectory) containing a reference to this dll.  