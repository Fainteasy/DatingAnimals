
# Dating Animals

This project presents a dating site implementation. The front-end was made in [Angular](https://angular.io/) and the Back-End in [.NET](https://learn.microsoft.com/fr-fr/dotnet/). It includes : 
- **Login / Register** : A full fonctionnal and secure User Login and Register with .NET Identity
- **Roles** : An Admin and a Moderator role in order to moderate the platform and an Admin Panel.
- **Presence Tracker** : An online tracker via Hub allowing users to know which other users are logged in.
- **Instant Message** : An instant chat system with read/unread function and timeline.
- **Like** : A like feature to show which users liked you/you liked.
- **Pagination** : Pagination Header system to call the api 



## Back-End Stack
The back-end is designed as an API Rest with caching and CRUD operators. The Database is in SqLite (developement mode) then switched to PostGreSQL (production mode). 

- **.NET 8** : Microsoft Framework based on C# to create the API. [More infos](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- **.NET Identity** : .NET Identity was used to manage roles and Users [More infos](https://learn.microsoft.com/fr-fr/aspnet/identity/overview/getting-started/introduction-to-aspnet-identity)
- **Entity Framework**: Used to manage Database's query. [More infos](https://learn.microsoft.com/en-us/ef/)
- **SQLite** : Database language for the developement mode. [More infos](https://www.sqlite.org/index.html) 
- **PostGreSQL** : Database language for the production mode. [More infos](https://www.postgresql.org/)
- **Nuget Gallery** : Package manager for the back end side. [More infos](https://www.nuget.org/)
- **Swagger** : Used to documentate the API's route [More infos](https://swagger.io/)

### Swagger snapshot
![Swaggersnapshot](https://i.ibb.co/W5nn368/swagger.png)

This is a snapshot of the Swagger avalaible directly on the api at the '/swagger' route. A lot of these route have optionnal query strings.

### Entity Relational Diagram (ERD)

![ERD](https://i.ibb.co/wwYQwZk/erd.png)

The database was created using .NET Identity. Here is the connection between the tables and there organization. 




## Front End Stack
The front-end of the web app was done using : 
- **Angular 16** : Typescript Framework [More Infos](https://angular.io/guide/update-to-version-16)
- **Ngx Bootstrap** : Theme library [More Infos](https://valor-software.com/ngx-bootstrap/#/)
- **Font-Awesome** : Icon repository [More Infos](https://fontawesome.com/)
- **Ngx-gallery**: Plugin to create custom photo gallery [More Infos](https://www.npmjs.com/package/ngx-gallery)
- **ToastR**: A plugin to display custom alert/info messages [More Infos](https://github.com/CodeSeven/toastr)
- **TimeAgo**: A plugin to display date in a time passed format [More Infos](https://www.npmjs.com/package/timeago)
- **Ngx-Spinner**: A library to add custom loading screen [More Infos](https://www.npmjs.com/package/ngx-spinner)
- **mkCert** : Install localhost certificate to handle https [More Infos](https://github.com/FiloSottile/mkcert)
- **Bootswatch** : Custom theme for Bootstrap Library [More Infos](https://bootswatch.com/)

### Screenshots

#### Home Page
![homepage](https://i.ibb.co/gjCqgdk/main-screen.png)

#### Matches Page
![matchespage](https://i.ibb.co/LvtKBcS/matches.png)

#### Message Page
![message page](https://i.ibb.co/QdKYsF8/messages.png)
## Installation

Clone the repository on your local machine

**To run the client**
```
cd client
npm install
ng serve

```

**To run the API**
```
cd api
dotnet run

```
## Live Version
Incoming
## Authors

Gwendoline Jacobs.

[@Fainteasy](https://www.github.com/Fainteasy)

