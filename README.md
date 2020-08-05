air Salon
C#/.NET Project for Epicodus, 2020.07.31
By Tyson Lackey and Thomas Glenn


Description
An interface for independent contractors to organize their contracts with bosses (in a many-to-many-to-many relationship).



Known Bugs
No known bugs.
Setup/Installation Requirements
View Online
Visit the GitHub Pages by clicking on the following link or by typing it in your web browser. url:

https://github.com/thomasglenngit/HairSalon.Solution

View locally
.NET Core is needed to run this application

To clone this repository from your command line you will need Git installed.

First navigate in the command line to where you want to clone this repository.

Then from your command line run:

$ git clone

Once the repository has been cloned, navigate to the to the application directory and run $ dotnet restore. Once 'restore' is run, enter $ dotnet build.

MySQL Setup
In order to view and use the functionality of this project you must,

Install MySQL on your computer. If you don't have it, you can download the .dmg file here: https://dev.mysql.com/downloads/file/?id=484914. You'll need to create a password.

Install MySQL Workbench on your computer. If you don't have it, you can download it here: https://dev.mysql.com/downloads/file/?id=484391.

Open MySQL Workbench and select the Local instance 3306 server.

Importing this file:
Open your MySQL Workbench. In the Navigator > Administration window, select Data Import/Restore.

In Import Options select Import from Self-Contained File.

Navigate to thomas_glenn.

Under Default Schema to be Imported To, select the New button.

Enter the name of your database with _test appended to the end. In this case thomas_glenn_test. Click Ok. Click Start Import.

Reopen the Navigator > Schemas tab. Right click and select Refresh All. Our new test database will appear.

Query
The following is the query information for access this database on MySQL Workbench.

DROP DATABASE IF EXISTS `thomas_glenn`;
CREATE DATABASE `thomas_glenn`;
USE `thomas_glenn`;
CREATE DATABASE `thomas_glenn` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */;
CREATE TABLE `clients` (
  `clientId` int(11) NOT NULL AUTO_INCREMENT,
  `stylistId` int(11) NOT NULL,
  `name` varchar(255) DEFAULT NULL,
  `mobile` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`clientId`,`stylistId`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `stylists` (
  `stylistId` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`stylistId`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
Edit
To view and edit the code, open the application in your preferred code editor, such as Visual Studio Code.
Technologies Used
Visual Studio Code (code editor)
C#/.NET
GitHub
MSTests
MacOS Catalina
License
This software is licensed under the MIT license. Copyright (c) 2020 Thomas Glenn.