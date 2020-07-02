My Contact
==========

Application is created to simplify process of collecting users contact list.

### Recomendations:
* OS Windows 10

### Requirements:
* Compatible database engine
* .net framework installed on OS

### How to build and start application:
* Download application from git repository
* Copy file `App.config-dist` to `App.config`
* Replace `--Database Server Name--` with your database server name
* Replace `--Database Name--` with non existing database name
* Build project
* In NuGet console run command `Update-Database`
* Run the project

### How to generate doxygen documentation
* Project must be built before you want to generate doxygen documentation
* Open package manager console
* Go to directory `My Contact`
* Run command `doxygen .\dconfig`