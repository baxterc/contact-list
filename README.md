
- Create a Contact class with private properties for name, phone number, email, a street address, a list of all Contacts and an ID number set by the length of the list of Contacts.  The class will also include a constructor that creates Contact objects.
Example Input:
Example Output:

- Create getters and setters for Contact's private properties (no setter is needed for ID).
Example Input:
Example Output:

- Set up HomeModule.cs with a route for the root path that takes the user to index.cshtml.
Example Input:
Example Output:

- Two routes in HomeModule.cs should take the user to two pages, one for viewing an existing contact and the other containing a form to add a contact.  These routes should be accessible from the root path via a link in index.cshtml.
Example Input:
Example Output:

- Create a form to allow the user to create a new Contact object.
Example Input:
Example Output:

- Show user-created contacts as a list.
Example Input:
Example Output:

- Make each item in the above-mentioned list a link that will take the user to the selected contact's information page.
Example Input:
Example Output:

- Upon submission of a new contact, a page will notify the user that a new contact has been added and will also display that new contact's info, along with links to go to a list of current contacts or to add a new contact.
Example Input:
Example Output:

- Allow user to clear the entire list of contacts via a button on the listing of all contacts.
Example Input:
Example Output:

- Check for a blank input in the name field of the contact form; other inputs can be blank, but if the name is empty, prevent the contact from being added.
Example Input: Name: ""
Example Output: "Please give your contact a name"

- Use a StreetAddress object to store the contact's street address.
