# RecipesAPI

## As of 14.09.23:
Project consists of three parts:
- API - that is fully working, has 5 CRUD methods to `Update`, `Insert`, `Delete` and `GetRecipe` by `name` and `ID`,
- DB - part of the project responsible for creating `tables` and `stored procedures`.
- Class Library - located in there are C# classess used for loading and saving data, communication with SQL DB and descriptions of data models.


`PostDeployement Script` is used to create example recipe and to fill ingredients table.

## How to start
In order to start API, user needs to `Publish` DB, and then change Default connection string in `appsettings.json`.
