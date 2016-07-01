using System.Collections.Generic;

namespace Contacts.Objects
{
  public class Contact
  {
    private string _contactName;
    private string _phoneNum;
    private string _address;
    private string _email;
    private int _id;
    private static List<Contact> _contacts = new List<Contact> {};

    public Contact(string ContactName, string PhoneNum, string Address, string Email)
    {
    _contactName = ContactName;
    _phoneNum = PhoneNum;
    _address = Address;
    _email = Email;
    _id = _contacts.Count -1;
    }

    public string GetName()
    {
      return _contactName;
    }
    public void SetName(string newName)
    {
      _name = newName;
    }
    public string GetPhoneNum()
    {
      return _phoneNum;
    }
    public void SetPhoneNum(string newPhoneNum)
    {
      _phoneNum = newPhoneNum;
    }
    public string GetAddress()
    {
      return _address;
    }
    public string SetAddress(string newAddress)
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
  }
}
