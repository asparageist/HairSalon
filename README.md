# HairSalon

#### By Joseph Murray

#### An MCV app that keeps track of Claire's stylists and their clients.

## Technologies Used

- Markdown
- Github
- C#
- ASP.NET Core
- HTML
- CSS
- Razor Pages

## Description

This app helps Claire to keep track of Stylists and Clients. Each Stylist has a list of their own Clients, and each Client is faithful to only one Stylist. All elements of the app are saved to a local database for safekeeping.

## Setup/Installation Requirements

- Note: An installation of the .NET SDK is required in order to run this application locally. [See Here](https://dotnet.microsoft.com/en-us/) for installation.

1. Clone this repo.
2. Open your shell (e.g., Terminal or GitBash) and navigate to this project's directory called "HairSalon".
3. Create a file named `appsettings.json`: `$ touch appsettings.json`
4. Within `appsettings.json` add the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL.

   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=localhost;Port=3306;database=joseph_murray;uid=[YOUR-USERNAME];pwd=[YOUR-MYSQL-PASSWORD];"
     }
   }
   ```

5. Set up the Database from the file `joseph_murray.sql`.
6. Run `$ dotnet watch run` in the command line to start the project in development mode with a watcher.
7. Open the browser at: _https://localhost:5001_.

## licensing info

*Copyright (c) 10/20/2023 Joseph Murray
*MIT license below
Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
