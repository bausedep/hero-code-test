# Hero Web Apps

This project is intended for demo purpose and developed using asp.net 5 MVC framework

## Prerequsites

Install dotnet 5.0 [SDK](https://dotnet.microsoft.com/download/dotnet/5.0) to your computer.


## Configuration

Open the configuration file in the src/Hero.WebApps folder and adjust the following value

```json
{
  ... omitted ...
  //The Hero API base Address
  "HeroApiAddress": "https://staging.hero.travel/api/v2",

  // Use the fake hero implementation 
  "UseFake": true
}
```
## Running The Application


You will need to set the **apikey** configuration value, even the fakemode is set to true.

Set the configuration value using usersecret (Recomended Windows + visual studio), azure vault, configuration file or using environment variable 

example using environment variable and running the application on linux:
```bash
export aspnetcore_apikey="yourapikey"
git clone https://github.com/bausedep/hero-code-test
cd hero-code-test/
dotnet build
dotnet run -p src/Hero.WebApps/Hero.WebApps.csproj

```

## License
[MIT](https://choosealicense.com/licenses/mit/)
