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
Example Input: new Contact(Fred Jones, 503-555-5555, 123 Main St, fred@fakedomain.lol)   
Example Output: Contact object is created with the above arguments taken in as properties.

- ###### Create getters and setters for Contact's private properties (no setter is needed for ID).
Example Input: Contact.GetName   
Example Output: Fred Jones

- ###### Set up HomeModule.cs with a route for the root path that takes the user to index.cshtml.
Example Input: User connects to localhost:5004/ in browser   
Example Output: Browser displays index.cshtml

- ###### Two routes in HomeModule.cs should take the user to two pages, one for viewing an existing contact and the other containing a form to add a contact.  These routes should be accessible from the root path via a link in index.cshtml.
Example Input: User clicks link to add a contact   
Example Output: Browser goes to a route called localhost:5004/new which loads add-contact.cshtml

- ###### Create a form to allow the user to create a new Contact object.
Example Input: User enters Name: Fred Jones into input field   
Example Output: New object is created with that name as a property

- ###### Show user-created contacts as a list.
Example Input: User enters Fred Jones as a contact name along with other properties.  
Example Output: Fred Jones gets added on a page with an unordered list.

- ###### Make each item in the above-mentioned list a link that will take the user to the selected contact's information page.
Example Input: Fred Jones, 503-555-5555, 123 Main St, fred@fakedomain.lol   
Example Output: As displayed on a page:
Name: Fred Jones
Phone Number: 503-555-5555
Street Address: 123 Main St
Email Address: fred@fakedomain.lol

- ###### Upon submission of a new contact, a page will notify the user that a new contact has been added and will also display that new contact's info, along with links to go to a list of current contacts or to add a new contact.
Example Input: Blank name  
Example Output: User is directed to contact-error.cshtml; no contact gets created.   

- ###### Allow user to clear the entire list of contacts via a button on the listing of all contacts.
Example Input: Click on Delete Contacts button   
Example Output: All contacts removed from contacts list in Contact class.

- ###### Check for a blank input in the name field of the contact form; other inputs can be blank, but if the name is empty, prevent the contact from being added.
Example Input: Name: ""   
Example Output: "Please give your contact a name"

- ###### Use a StreetAddress object to store the contact's street address.
Example Input: 123 Main St   
Example Output: 123 is stored as an address number, Main is stored as the street name, St is stored as the street type.

- ###### Store the contact's name as a First and Last name combination.
Example Input: Fred Jones  
Example Output: Contact.FirstName = "Fred", Contact.LastName ="Jones"

- ###### Allow the user to find a contact by name, matching against both the first and last name.
Example Input: Fred   
Example Output: Returns a list of any contact with the string "fred" in it.

## Legal
Copyright (c) 2016 Charlie Baxter.  This software is licensed under the MIT License.
