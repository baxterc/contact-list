# Address Book
### An Object-Oriented C# Exercise Using Nancy and Razor
### By Charlie Baxter, July 1, 2016

## Description
This site stores and displays contact information for individuals entered by the user.  After the user submits a person's contact information, a contact object is created using Nancy.  Users can select any of the contacts that they've entered from a list.  Users can also clear the list of contacts.

## Setup
* Clone this repository
* Install a C# framework such as Mono, which is available from [www.mono-project.com](http://www.mono-project.com/)
* Navigate to the project folder using your terminal/shell and run the command "dnu restore" to load dependencies.
* Type the command "dnx kestrel" to load the project.  The following message should appear:   
Hosting environment: Production   
Now listening on: http://localhost:5004   
Application started. Press Ctrl+C to shut down.
* In your web browser, type in http://localhost:5004
* Once finished, type control-C in your terminal or shell.

## Technologies Used
* C#
* Nancy
* Razor
* HTML
* CSS

## Specifications
- ###### Create a Contact class with private properties for name, phone number, email, a street address, a list of all Contacts and an ID number set by the length of the list of Contacts.  The class will also include a constructor that creates Contact objects.   
Example Input:   
Example Output:

- ###### Create getters and setters for Contact's private properties (no setter is needed for ID).
Example Input:
Example Output:

- ###### Set up HomeModule.cs with a route for the root path that takes the user to index.cshtml.
Example Input:
Example Output:

- ###### Two routes in HomeModule.cs should take the user to two pages, one for viewing an existing contact and the other containing a form to add a contact.  These routes should be accessible from the root path via a link in index.cshtml.
Example Input:
Example Output:

- ###### Create a form to allow the user to create a new Contact object.
Example Input:
Example Output:

- ###### Show user-created contacts as a list.
Example Input:
Example Output:

- ###### Make each item in the above-mentioned list a link that will take the user to the selected contact's information page.
Example Input:
Example Output:

- ###### Upon submission of a new contact, a page will notify the user that a new contact has been added and will also display that new contact's info, along with links to go to a list of current contacts or to add a new contact.
Example Input:
Example Output:

- ###### Allow user to clear the entire list of contacts via a button on the listing of all contacts.
Example Input:
Example Output:

- ###### Check for a blank input in the name field of the contact form; other inputs can be blank, but if the name is empty, prevent the contact from being added.
Example Input: Name: ""
Example Output: "Please give your contact a name"

- ###### Use a StreetAddress object to store the contact's street address.
Example Input:  
Example Output:

- ###### Store the contact's name as a First and Last name combination.
Example Input:
Example Output:

- ###### Allow the user to find a contact by name, matching against both the first and last name.
Example Input:
Example Output:
