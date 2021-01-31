# _Animal shelter api_

#### _Week 12 independent project for Epicodus_

#### By _**Joey Giunta**_

## Description
Allows the user to get an animal from a database using an api call

## Prerequisites

* .NET Core Framework

## Setup

* _Install listed prerequisites following their own listed install instructions_
* _Download or clone this repository by copying the link from the green "code" dropdown menu and running "git clone {copied link}" in the command line_
* _open console in project-root/Factory_
* _run "dotnet restore" followed by "dotnet build" project-root/Factory_
* _run "dotnet tool install --global dotnet-ef" in project-root/Factory_
* _if no Migrations directory exists, run "dotnet ef migrations add Initial" followed by "dotnet ef database update" in project-root/Factory_
* _run "dotnet run" project-root/Factory_

## Making calls
_To make an api call, navigate to localhost{root}/api/animals?name={animal name}_
_Possible calls:_
* name (NOTE: Name is required)
* age
* species (default only contains cats, dogs and a parrot)
* Gender (male or female, fully typed out)

_Params must begin with a question mark, and have an ampersand_
* Example: _https://localhost:5001/api/animals?name=Bender&gender=male_


## Known Bugs

_There are currently no known bugs._

## Support and contact details

_If there are issues, please contact the following:_  
Joseph Giunta <giuntajc@comcast.net>


## Technologies Used
- C#
- .NET Core
- ASP.NET Razor
- Identity

### License

*Available under the MIT License.*

Copyright (c) 2021 **_Joseph C Giunta_**
