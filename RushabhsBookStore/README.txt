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