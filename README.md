# SQL GUI

If you're anything like me, you kind of hate SQL. It's not that I don't think it's good, but it is annoying. SQL has been what we use for database management for about 50 years and it has reigned nearly uncontested.

There's countless GUI's for interacting with your SQL database, but they all have one thing in common. They all require you to type your own queries. Now, if you're interacting with a database chances are you know what you are doing and that is not a huge deal, but developers often find themselves having to mentally change languages constantly. Remembering a language as finicky as SQL can be a real pain, especially if you are only making a minor change or check.

This project aims to create a point and click style of operation to maintaining a SQL database. This allows less experienced users to aid in maintenance in a low danger manner, as well as allows developers to carry out simple actions easily, without needing to change languages in their head.

#

### Getting started --

Simply building the project will create a .exe file in the _/bin_ folder, that can be opened normally.

Your first window will prompt you for database connection string information. This memory is held only locally by the program, and only while the program is running.

If the connection is successful, you will see a success message and the version info of the database you have connected to. Otherwise, you will see an error message.

#

### To-do --

These are, in semi-particular order, my immediate goals. This list will have new objectives appended as the project continues, and I will cross off features as I go, leaving notes as necessary.

- ~~Create connection window~~
- ~~Create dashboard~~
- ~~Attempt database connection~~
- ~~Add functionality to add tables~~
- ~~On successful connect, fetch a list of tables and display them on the left~~
- ~~Add functionality to delete tables~~
- ~~Included in previous objective, show/hide features on the dashboard relative to the tab you're on~~
- ~~Create a function for writing to the log ( so I don't have to do excessive in-line += )~~
- ~~Handle empty values in existing form controls~~
- Create an override for log writing function to take a color ( for fun :D )
- Evaluate list of options on columns tab, maybe add more
- Begin work on columns tab ( detail objectives here )
