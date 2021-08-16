# crud-dotnet
Asp.Net Core MVC Web App CRUD with Entity Framework and PostgreSQL.

A project to learn how to manage customer data


## Installation

- Visual Studio 
- Pgadmin 4 for PostgreSQL


## Usage

Step 1: Set up database in PostgreSQL

```
create table customer
(
	customerid serial primary key,
	customername varchar(150),
	email varchar(100),
	salary int
);
```

Step 2: Open source code with Visual Studio and run application by press `Ctrl + F5`

Step 3: See it in browser



## Technologies	
- Asp.Net Core MVC
- Entity Framework
- PostgreSQL

## Demo

See demo at link: [Youtube](https://www.youtube.com/watch?v=EP0K-qBlngI)

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License
[MIT](https://choosealicense.com/licenses/mit/)
