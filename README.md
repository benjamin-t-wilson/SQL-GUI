# SQL GUI

Ben, on project conception:
"If you're anything like me, you kind of hate SQL. It's not that I don't think it's good, but it is annoying. SQL has been what we use for database management for about 50 years and it has reigned nearly uncontested.

There's countless GUI's for interacting with your SQL database, but they all have one thing in common. They all require you to type your own queries. Now, if you're interacting with a database chances are you know what you are doing and that is not a huge deal, but developers often find themselves having to mentally change languages constantly. Remembering a language as finicky as SQL can be a real pain, especially if you are only making a minor change or check.

This project aims to create a point and click style of operation to maintaining a SQL database. This allows less experienced users to aid in maintenance in a low danger manner, as well as allows developers to carry out simple actions easily, without needing to change languages in their head."

#

### Getting started --

Simply building the project will create a .exe file in the _/bin_ folder, that can be opened normally. Your first window will prompt you for database connection string information. This memory is held only locally by the program, and only while the program is running. If the connection is successful, you will see a success message and the version info of the database you have connected to. Otherwise, you will see an error message.

#### Removing a saved connection --

We will add functionality for this later, currently you would need to delete the local database file ( connDb.sqlite ). Note, the info is stored in the local database in **plain text**. These fields auto populate into the connection box in **plain text**. This is not encrypted and is not totally secure. Please exercise your own caution when saving/handling sensitive information.

#

### To-do & Updates --

With the addition of another team member, our [updates are now held in clickup](https://app.clickup.com/8485502/v/l/li/44207667)

#

### The Team --

![photo of Ben](https://i.imgur.com/uwz4ChK.png)

#### Benjamin Wilson --

Ben is an AZ native born into nerd-dom. He built his first desktop when he was 8 and seems only fit that he get into coding eventually. He is currently a junior .Net developer at Centuri Construction

##### Find Ben on:

- His [website](https://btwicode.com/)
- [LinkedIn](https://www.linkedin.com/in/benjamin-t-wilson/)
- [GitHub](https://github.com/benjamin-t-wilson)
- or email at [whatsup@btwicode.com](mailto:whatsup@btwicode.com)
