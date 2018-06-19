# .NET Core - FizzBuzz with Unit Test

## How To Install
```bash
dotnet new sln
mkdir src tests
cd src
dotnet new webapi -n fizzbuzz
cd ..
cd tests
dotnet new xunit -n fizzbuzz.UnitTest
cd ..
dotnet sln add src/fizzbuzz/fizzbuzz.csproj
dotnet sln add tests/fizzbuzz.UnitTest/fizzbuzz.UnitTest.csproj
dotnet sln list
```

## How to Run Test
```bash
dotnet test fizzbuzz.UnitTest/fizzbuzz.UnitTest.csproj
```