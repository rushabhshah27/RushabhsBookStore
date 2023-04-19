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
Selected a theme of 'Sandstone' and added bootstrap.min.css file to CSS Folder. 

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

1914
Added a new interface named as ISP_Call.cs file that extends IDisposable in the IRepository folder.

1930
Added a Nuget package named Dapper and modified the ISP_Call.cs file.

1940
Created SP_Call.cs file in the Repository folder. 
Implement the SP_Call.cs file with the necessary commands. 

2020
Added a IUnitOfWork.cs interface file in the IRepository folder with updating a code. 

2021
Added a UnitOfWork.cs class file to the Repository folder and modified it with the necessary code.

2105
To make it accessible, added 'services.AddScoped<IUnitOfWork, UnitOfWork>();' in Startup.cs file.

2300
Added a new MVC Controller Empty named CategoryController.cs file inside Areas/Admin/Controllers.

2312
Modified the CategoryController.cs file.

2315
Added a Category named folder inside the Admin/Views.

2320
Added a RazorView named "Index.cshtml" file into the Category folder and update the provided code. 

2333
Moved the Category link to the _Layout.cshtml file.
Run the application and check the Category section.

2356
Modified the Index.cshtml to add the icons in the Category section and checked it and commented that code.

2023-03-31
0005
Created category.js file in the wwwroot and update provided code. 

0007
Gave the path of category.js file into the Index.cshtml file.

0015
Update the CategoryController.cs file with the Upsert action. 

0030
Created a Razor View Upsert.cshtml file in Category folder with updating the provided code. 

0047
Created a partial view for edit and back. 
Added the partial view for _CreateAndBackToList.cshtml and _EditAndBackToListButton.cshtml files.
Also added @model razor statement in the _EditAndBackToListButton.cshtml

0105
Modified the Upsert.cshtml with the @model statement and added the asp-action to the Index.cshtml file.

0112
Modified Upsert.cshtml file with @title variable instead of TITLE.
Also, Added @section Script to the Upsert.cshtml file and run the application.

0136
Created Upsert POST action method in the CategoryController.cs file.
Added the Save() method to the IUnitOfWork interface.
Also, Removed the _db.SaveChanges() method in the CategoryRepository.cs file and moved _unitOfWork.Save() method with the return RedirectToAction method.

0200
Test the application to check it can update and create a category. 

0206
Added the API for HttpDelete in the CategoryController.cs file.

0210
After that, Implemented a delete method and delete functionality with onclick event in category.js file.

0225
Added Delete(url) function code in the category.js file.
Now try to run the application. It works perfectly without any error. However, the delete operation is not performed properly.

PART 3
13-04-2023

1535
Created CoverType.cs file in Models Project.
Added 2 CoverType Model in this class. ID and Name.

1543
Migration performed with PM Console.
Added a file named 20230413195221_AddCoverTypeToDb.cs after performing migration. 
Added CoverType to ApplicationDBContext.cs

1557
Checked that CoverType Table is there with SQL SOE. 

1605
Created a class named CoverTypeRepository.cs in Repository Folder.
Also Created ICoverTypeRepository.cs interface in IRepository Folder. 

1615
Update both the CoverTypeRepository.cs and ICoverTypeRepository.cs file. 

1621
Update the UnitOfWork and IUnitOfWork files by adding the CoverType in it. 

1635
Created CoverTypeController.cs file and update it with the necessary code in Areas/Admin/Controller.

1720
Performed CRUD Operation on CoverType.
Such as Added CoverType to NavBar
Added CoverType Controller with required Action Methods
Added CoverType Index View and Upsert View.
Also the Delete CoverType is done using API Call. 

Run the application and check the CoverType. Performed well except Delete action. 

1736
Added a class named Product.cs in the Models Project. 
Update that class with the given code. 

1740
Added Products to the ApplicationDbContext.cs file.

1742
Performed migration on Product using command add-migration AddProductToDb in PM Console. 
This file named 20230413214107_AddProductToDb.cs is created while performing migration. 
Update the database ane verified this table using SQL SOE.

1750
Made Title, ISBN and Author fields Required. 
Created a new Migration named AddValidationToProduct and updated the Database. 

1807
Added Product to Repository and IRepository. 
Also Added Update method in the ProductRepository Class. 
Added Product to the UnitOfWork and IUnitOfWork. 
Build the Project. No errors!

1913
Created ProductController.cs in the Area/Admin/Controllers and update it with the given code. 

1931
Created ProductVM.cs file in ViewModels Folder and installed Microsoft.AspNetCore.Mvc.ViewFeatures Package.

1949
Modify the ProductController.cs with Upsert calls to the ProductVM View Model. 
Also modified the API Call. 

2003
Added product.js file in the wwwroot>js folder.

2009
Added an Index View named Index.cshtml in the Areas/Views/Product.

2014
Updated Index.cshtml of Product. 

2019
Updated the product.js file same as category.js.

2021
Modified the _Layout.cshtml with adding a link of Product.
Run the application and when I click the Product then it displayed but at the end find an exception. 

2058
Created Upsert.cshtml file in Areas/Admin/Views/Product.
Updated that file with the provided code. 

2108
Created an account in tiny.cloud and used my API Key and update the Upsert.cshtml file.

2132
Created 'images' folder in wwwroot and 'products' folder in 'images' folder.

2145
Comment out the Upsert action in ProductCongtroller.cs file.
Run the application, but still getting an exception. 

2023-04-17

1350
Made some little bit changes to in js files so the delete action works well. 
Run the application and it works. However, Still getting an exception while clicking on the Product.

2023-04-19

1048
Finally found a minor mistake in the code of ProductController.cs file and run the application. 
The exception is gone and application run successfully. 

1122
Update the Product Upsert Post Action Method in ProductController.cs file. 

1133
Update the Product Upsert.cshtml file.

1208
Facing an error while updating the product. So Try to solve it by updating the code in ProductController.cs file. 
Also Added Delete in ProductController.cs file.

1216
Added Product in the HomeController and update the HomeController.cs file from Areas/Customer/Controllers folder. 

1221
Updated the Index.cshtml file from the folder Areas/Customer/Views/Home to reflect the Product in the home page.
Run the application and it runs successfully without any errors. 

1640
Added 3 Products. They are added and updated without any error. Also, It is visible to the Index Page. Yay!