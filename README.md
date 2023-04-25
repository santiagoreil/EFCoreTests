# EFCoreTests
Tests for EF Core

This is a quick and dirty  test for EF Code.
I will update it will more things I will test in the future, but for now, it allows to create a database using migrations, and will install on a database.

# Configuration:

Go to file ContextModel.cs and edit it. Find the following code:

	optionsBuilder.UseSqlServer("Data Source=localhost ....

Update the information for your database. The database should exist, and be empty. In this case it is called EFTests.
This is a quick test, so for now, it is hardcoded, but on a real application, even for development, this should be on a config json file.
Even better, it should be encrypted.

Also, I added  a configuration to trust the certificate, because I have none for my local machine, but also, on a serious environment you should have a valid certificate.

# Migration:

After configuring, you can run the migrations:

You have two options. Remove the Migrations folder and run both calls to be sure this works correctly:

PM>Add-Migration Initial
PM>Update-Database

This will really test that the definitions with code first really work.


Optionally, you can leave the migrations, and just run Update-Database.

# Contact:

Any questions, you can ask me at
email: santiagoreil@gmail.com
phone/whatsapp: +54-911-64621197
