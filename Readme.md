# BookStore Projects

## Packages
- Install-Package microsoft.EntityFrameworkCore
- Install-Package microsoft.EntityFrameworkCore.SqlServer
- Install-Package microsoft.EntityFrameworkCore.Design
- Install-Package microsoft.EntityFrameworkCore.Tools

## EF CLI
- Add-Migration [Migration Name] -Project BookStore.Data -StartupProject BookStore.Admin
- Update-Database -Project BookStore.Data -StartupProject BookStore.Admin

- https://learn.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli
