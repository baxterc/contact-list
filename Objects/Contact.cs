using System.Collections.Generic;
using StreetAddresses.Objects;

namespace Contacts.Objects
{
  public class Contact
  {
    private static List<Contact> _contacts = new List<Contact> {};
    private string _firstName;
    private string _lastName;
    private string _phoneNum;
    private StreetAddress _address;
    private string _email;
    private int _id;

    public Contact(string FirstName, string LastName, string PhoneNum, StreetAddress Address, string Email)
    {
    _firstName = FirstName;
    _lastName = LastName;
    _phoneNum = PhoneNum;
    _address = Address;
    _email = Email;
    _contacts.Add(this);
    _id = _contacts.Count;
    }

    public string GetFirstName()
    {
      return _firstName;
    }
    public void SetFirstName(string newFirstName)
    {
      _firstName = newFirstName;
    }
    public string GetLastName()
    {
      return _lastName;
    }
    public void SetLastName(string newLastName)
    {
      _lastName = newLastName;
    }
    public string GetPhoneNum()
    {
      return _phoneNum;
    }
    public void SetPhoneNum(string newPhoneNum)
    {
      _phoneNum = newPhoneNum;
    }
    public StreetAddress GetAddress()
    {
      return _address;
    }
    public void SetAddress(StreetAddress newAddress)
    {
      _address = newAddress;
    }
    public string GetEmail()
    {
      return _email;
    }
    public void SetEmail(string newEmail)
    {
      _email = newEmail;
    }
    public int GetId()
    {
      return _id;
    }
    public static List<Contact> GetAll()
    {
      return _contacts;
    }
    public string GetFullName()
    {
      return (_firstName + " " + _lastName);
    }
    public static Contact FindContact(int id)
    {
      return _contacts[id-1];
    }
    public static void DeleteAll()
    {
      _contacts.Clear();
    }
    public static List<Contact> ContactSearch(string SearchName)
    {
      List<Contact> resultContacts = new List<Contact> {};
      foreach(Contact contact in _contacts)
      {
        string ContactName = contact.GetFullName();
        if (ContactName.Contains(SearchName))
        {
          resultContacts.Add(contact);
        }
      }
    return resultContacts;
    }
  }
}
