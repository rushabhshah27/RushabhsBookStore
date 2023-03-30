2023-03-03

1510
Started Assignment 2 inclass on the lab computer.
Set up the ASP.NET MVC with core 3.1 (out-of-support)
HTTP enabled, Individual account authentication
Reviewed the Areas folder, Controller, Model, View

1540 - n Startup.cs online 33
removed options for default  identity:
options => options.SignIn.RequireConfirmedAccount = true

1542
Tested App...Ran it good...Tested Links

Action Items:
- Modify the navigation
- Update the copyright... from 'static' to 'dynamic'

1545
Modified the default welcome message tested.
review the route pattern in Startup.cs

1549
Confirmed the repo is build. Now I want to test it. 

1553
Create README.md file in GitHub and pull it in Visual Studio. 

2023-03-09

1440
Changed the default bootstrap file to bootstrap_bk.css for the backup purpose. 
Looking for the theme from the website https://bootswatch.com/.

1451
Selected a theme of 'VAPOR' and added bootstrap.min.css file to CSS Folder. 

1453
Added a code to the bootstrap/css/bootstrap.min.css file. 
Then try to run the Application. 

1547
Changed the navclass from navbar-light to navbar-dark and bg-white to bg-primary in _Layout.cshtml in Views folder. 

1550
Remove text-dark from line 23 in _Layout.cshtml file.
Then added additional properties to the footer class. 

2251
Changed file name from bootstrap.min.css to bootstrap.css

2252
Removed text-dark in _LoginPartial.cshtml file and run the Project to review the changes.

2300
Added additional stylesheets and scripts from the CSS_JS.txt file in _Layout.cshtml file. 
Added dropdown to the navbar in _Layout.cshtml file and changed the dropdown name to Content Management. 

2023-03-10

1148
Added 3 New .Net Core Class Library Projects to the Application.
1) RushabhsBooks.DataAccess
2) RushabhsBooks.Models
3) RushabhsBooks.Utility

1151
Copy the Data folder and paste it to the .DataAccess Project and delete the original.

1205
Installed Microsoft.EntityFrameworkCore.Relational and SqlServer Packages.
Also deleted the Migration Folder. 

1215
Modify the namespace in ApplicationDbContext.cs
And also deleted Class1.cs file from all projects.

1225
Moved Models folder into .Models Project
Added a project reference in .DataAccess and .Models project
Rename the Models folder to ViewModels and also changed the namespace to .Models.ViewModels

1232
Modify the Startup.cs file and run the application to review the errors.
Changed the reference in Error.cshtml to .Models.ViewModels.ErrorViewModels and tested the application. 
But still getting an error while running the application. 

1505
Added Identity.Entity Nuget Package. 
When I am building the project. Getting 2 Errors. 

Update the NuGet Package AspNetCore.Identity.EntityFrameworkCore to 3.1.27
Update the  Microsoft.EntityFrameworkCore.SqlServer to 3.1.27
Built the project and got NO ERRORS.

1538
Added SD.cs class in .Utility Project. 
Added a reference of .Utility in the Main project. 
Added a reference of .Utility and .Models in the .DataAccess project. 

2023-03-21
2300
Added a Customer area to Areas.
Changed the routes in Startup.cs file like the one in the ScaffoldingReadMe.txt file.

2310
Moved the HomeController.cs to the Controller folder and deleted the Data and Models.
Also defined that the controller is in the Customer area.
Moved Home folder to Views folder in Customer folder.

Run the application. It gives an error.

2315
Copied the _ViewImports.cshtml and _ViewStart.cshtml file to the Customers folder.
Modified the _ViewStart.cshtml to reflect the new path.

2317
Run the application. Still getting an error. 

2320
Added an Admin area in Areas.
Also added Views files and deleted the Data and Model and Controllers folders.

2325
Again Run the application but still getting an error. 

2023-03-29
1800
Again run the application and still getting an error. 

1803
Update the Nudget Packages version from 5.1 to 3.1.27.
Try to run the application and It works properly without any error. 

2023-03-30
1345
Starting the Part 2 of this Assignment. 
Build the Application and confirmed that there are no errors. 

1355
Reviewed the appsettings.json file and modified the database name. 

1400
Added the migration using Nuget Package Manager Console with 'add-migration AddDefaultIdentityMigration'
It gives error as I selected the wrong project.

1403
I performed migration again with .DataAccess Project and it builded successfully. 
The new added migration file name: "20230330180032_AddDefaultIdentityMigration.cs"
and I reviewed the file. 

1408
Update the database by the following command 'update-database' in the PM Console.

1410
Reviewed the Updated database from SQL Server Object Explorer and run the application. 
The application is working without any errors. 

1420
Added a Category.cs file to the .Models Project and also modified it.

1426
Added the migration via PM Console with 'add-migration AddCategoryToDb'.

1431
Update the ApplicationDbContext.cs file with 'public DbSet<Category> Categories { get; set; }' and using RushabhsBooks.Models statements.

1500
Trying to re-run the add-migration AddCategoryToDb via PM Console, but it shows that the migration is already exists. 
Therefore, Deleted the AddCategoryToDb.cs file and again run the command add-migration AddCategoryToDb in PM Console. 

1525
Updated the Database and checked the Category Table in SQL SOE.

1720
Added a Repository folder to the .DataAccess project. 
Also added an IRepository folder inside the Repository folder. 

1730
Created IRepository.cs interface file and modified it with the given code.

1741
Again modified the IRepository.cs file to perform CRUD operations.

1756
Modified the code to create constructors and DI with the help of provided Assignment 2 folder.

1830
Created individual repos for Category - CategoryRepository.cs and ICategoryRepository.cs

1844
Modified the CategoryRepository.cs file.

1846
Also Modified the ICategoryRepository.cs file.

1858
Added remaining modifications in CategoryRepository.cs file.

1905
Modified the Update in CategoryRepository.cs file.
Built the application and it worked. Without any errors. 