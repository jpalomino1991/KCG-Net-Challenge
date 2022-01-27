To run the code clone the repository, the solution was built using visual studio community 2019 and .Net Core 5

You must also add the following lines in the app.settings.json of the solution which contains the connection string of the database.

"ConnectionStrings": {
    "DefaultConnection": "uid=user_name;Password=password;Server=ip_or_server_name;Database=database_name;Trusted_Connection=False;Encrypt=False;"
  },

There is also attached the sql querys and the csv files necessary to run the solution. They are located in the Script folder.

The csv files must be in a path where the database is hosted.

The order to run the scripts:

1) tables.sql
2) insertar cliente.sql
3) insertar producto.sql

Todo do

- Create a filter to search client and product.
- Filter to show the orders.
