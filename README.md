# .NET-EntityFramework
Examples with .NET-EntityFramework

## Code First Migrations
Package Manager Console commands
* Enable-Migrations
* Add-Migration [MigrationName] e.g. Add-Migration AddBlogUrl
* Update-Database or Update-Database –Verbose 

More [here](https://docs.microsoft.com/en-us/ef/ef6/modeling/code-first/migrations/index)

## Automatic Migrations
Package Manager Console commands
* Enable-Migrations –EnableAutomaticMigrations
* Update-Database or Update-Database –Verbose 

More [here](https://docs.microsoft.com/en-us/ef/ef6/modeling/code-first/migrations/automatic)

## Loading Related Entities
https://docs.microsoft.com/en-us/ef/ef6/querying/related-data   

### Eagerly Loading
Call *Include* API.   
Eagerly loading solves problem called *N + 1* 
More [here](https://www.brentozar.com/archive/2018/07/common-entity-framework-problems-n-1/) and [here](http://blogs.microsoft.co.il/gilf/2010/08/18/select-n1-problem-how-to-decrease-your-orm-performance/)   
(N is the number of parent entities) 

### Lazy Loading
By default lazy loading is enabled. To have working lazy loading navigation property has to be virtual.   

*When using POCO entity types, lazy loading is achieved by creating instances of derived proxy types and then overriding virtual properties to add the loading hook.*

### Explicitly Loading

Even with lazy loading disabled it is still possible to lazily load related entities, but it must be done with an explicit call.

