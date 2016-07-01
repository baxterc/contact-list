using System.Collections.Generic;
using StreetAddresses.Objects;

namespace Contacts.Objects
{
  public class Contact
  {
    private static List<Contact> _contacts = new List<Contact> {};
    private string _contactName;
    private string _phoneNum;
    private StreetAddress _address;
    private string _email;
    private int _id;

    public Contact(string ContactName, string PhoneNum, StreetAddress Address, string Email)
    {
    _contactName = ContactName;
    _phoneNum = PhoneNum;
    _address = Address;
    _email = Email;
    _contacts.Add(this);
    _id = _contacts.Count;
    }

    public string GetName()
    {
      return _contactName;
    }
    public void SetName(string newName)
    {
      _contactName = newName;
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
    public static Contact FindContact(int id)
    {
      return _contacts[id-1];
    }
    public static void DeleteAll()
    {
      _contacts.Clear();
    }
  }
}
