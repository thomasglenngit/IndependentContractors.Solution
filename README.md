# _Independent Contractors_

#### _C#/.NET Project for [Epicodus](https://www.epicodus.com/), 2020.08.17_

#### By **Thomas Glenn and Tyson Lackey**

## Description
An interface for independent contractors to organize their contracts with bosses (in a many-to-many-to-many-to-one relationship)

<!-- <img src="IndependentContractors/wwwroot/assets/images/LPLoginPg.png"          style="float: left; margin-right: 10px;" /> -->


The following sitemap explains this database query relationship between Flavors and Treats in this schema.

## Database Structure
<img src="IndependentContracts/wwwroot/assets/images/SchemaDiagram3.png"          style="float: left; margin-right: 10px;" />

## Specifications

| Spec | Input | Output | 
|:--------- |:--------- |:-------- |
| The program will construct a database of Clients, Contractors and Weapons, allowing the user to add entries | "Add Client" | "Mickey the Shark" | 
| The program will allow the user to view lists of Clients, Contractors and Weapons | "View Contractors List" | "Slimey Joe" "The Tooth" "AC" |
| The program will allow the user to edit entries of Clients, Contractors and Weapons |  "Mikey the Shake" | "Mickey the Shark" |
| The program will allow the user to delete entries | "The Strangler" | " " | 


## Known Bugs
* No known bugs.   

## Setup/Installation Requirements
#### View Online
Visit the GitHub Pages by clicking on the following link or by typing it in your web browser. 
<url:>

https://github.com/thomasglenngit/IndependentContractors.Solution

#### View locally

*[.NET Core](https://dotnet.microsoft.com/download/dotnet-core/2.2) is needed to run this application*

To clone this repository from your command line you will need [Git](https://git-scm.com/) installed. 

First navigate in the command line to where you want to clone this repository. 

Then from your command line run:

`$ git clone `

Once the repository has been cloned, navigate to the to the application directory and run `$ dotnet restore`.
Once 'restore' is run, enter `$ dotnet build`.

#### MySQL Setup
In order to view and use the functionality of this project you must,
1. Install MySQL on your computer. If you don't have it, you can download the .dmg file here:
https://dev.mysql.com/downloads/file/?id=484914. You'll need to create a password.

2. Install MySQL Workbench on your computer. If you don't have it, you can download it here:
https://dev.mysql.com/downloads/file/?id=484391.

3. Open MySQL Workbench and select the Local instance 3306 server. 

#### Importing this file:
1. Open your MySQL Workbench. In the Navigator > Administration window, select Data Import/Restore.

2. In Import Options select Import from Self-Contained File.

3. Navigate to `independent_contracts`.

Under Default Schema to be Imported To, select the New button.

Enter the name of your database with _test appended to the end.
In this case independent_contracts_test.
Click Ok.
Click Start Import.

Reopen the Navigator > Schemas tab. Right click and select Refresh All. Our new test database will appear.



#### Query
The following is the query information for access to this database on MySQL Workbench.
```


```
#### Entity
Entity is a framework which coordinates the properties associated with the project models, and the corresponding datatables stored in MySQL. In order to keep the database refreshed with user inputs and possible changes to the application models, the following commands must be made after these inputs and changes:

1. In the terminal command line, enter: `dotnet ef migration add (name of migration)`. You can name the migration what you will, but remember that each new migration must have a unique name. Best practices are to name the first migration, "Initial", then "Secondary", etc. Also note that the first letter of the migration name should always be capitalized. If all goes well, the terminal will respond with the affirmation, "Done."

2. Following the migration the database must be updated with the following command: `dotnet ef database update`. Again, if all goes well, after entering this command, the terminal will affirm the update and migration by displaying the migration with a unique migration number and the affirmation, "Done".

3. Check to see that the migration appears in MySQl Workbench, as well as newly formed "Migrations" folder in your VSCode editor.

### Edit
* To view and edit the code, open the application in your preferred code editor, such as Visual Studio Code.

## Technologies Used
* Visual Studio Code (code editor)
* C#/.NET
* GitHub
* MSTests
* MacOS Catalina
* MySQL Workbench
* CSS
* .html

## License
This software is licensed under the MIT license. Copyright (c) 2020 Thomas Glenn.

