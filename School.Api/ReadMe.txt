dotnet ef --startup-project School.Api/School.Api.csproj migrations add InitialModel -p School.Data/School.Data.csproj


dotnet ef --startup-project School.Api/School.Api.csproj database update



dotnet ef --startup-project School.Api/School.Api.csproj migrations add SeedStudentsTable -p School.Data/School.Data.csproj