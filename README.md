AVL (Automatic Vehicle Location) Display
====

This repo contains the implementation of an AVL display system. 

## Development Environment
This system is developed based on MS-based frameworks, i.e., ASP.NET, IIS, MSSQL.

Tools and Environment:
* MS Visual Studio 2012
* MSSQL 2008 R2
* jquery, jquery UI, Google Maps
* IIS 7.0

## Architecture

.
+-- AVL.aspx
| +-- AVL.aspex.cs 
+-- Site.master 
| +-- Site.master 
+-- /js 
| +-- viewer 
| | +-- AVLDisplay.js 
| | +-- AVLQuery.js 
+-- /lib 
| +-- Highcharts 
| +-- jquery 
| +-- jquery-UI 
+-- /Styles 
+-- /App_Data 
| +-- patroller_routes.txt 

### AVL.aspx
The main UI page that devlivers the functions to users in front-end.
AVL.aspx.cs is the C# server-side module of AVL.aspx.

### Site.master
The master page in ASP.NET framework. It controls the visual layout.

### AVLDisplay.js
The client-side module assembly for data processing and front-end display.

### AVLQuery.js
The client-side module assembly as the query handler.

### /lib
Library directory that contains the required packages: Highcharts, jquery, jquery-ui.

### /Styles
Contains the css style setting files.

### patroller_routes.txt
The regular patroller routes info.


