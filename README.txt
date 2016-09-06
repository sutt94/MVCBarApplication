Created using Visual Studio 2015 Enterprise 
Requires Entity Framework to be installed 
Must add connection to local database file and modify connection string to access database file or the project will not work.
1. After opening the project open the server explorer and right click connections, click add connection and select SQL Server Database file.
2.For the database file name field click browse and navigate to the location on your machine containing the downloaded BarApp.mdf file.
3.Within the Web.config file of the project there are two connection strings that must be modified, they are as follows.
<add name="DrinksContext" connectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\UsersC:\Users\Folder\Folder\BarApp.mdf;Integrated Security=True;Connect Timeout=30" providerName="System.Data.SqlClient" />
<add name="OrdersContext" connectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\C:\Users\Folder\Folder\BarApp.mdf;Integrated Security=True;Connect Timeout=30" providerName="System.Data.SqlClient" />
The section AttachDbFilename=C:\Users\Folder\Folder\BarApp.mdf must be changed to the path where BarApp.mdf is located on your machine for both connection strings.
4.After following these steps you should be connected to the database file and the project should run succesfully.