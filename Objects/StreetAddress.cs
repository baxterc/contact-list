using System.Collections.Generic;

namespace StreetAddresses.Objects
{
  public class StreetAddress
  {
    private static List<StreetAddress> _streetAddresses = new List<StreetAddress> {};
    private string _streetNum;
    private string _streetPrefix;
    private string _streetName;
    private string _streetType;
    private string _city;
    private string _state;
    private string _zip;

    public StreetAddress(string StreetNum, string StreetPrefix, string StreetName, string StreetType, string City, string State, string Zip)
    {
      _streetNum = StreetNum;
      _streetPrefix = StreetPrefix;
      _streetName = StreetName;
      _streetType = StreetType;
      _city = City;
      _state = State;
      _zip = Zip;
    }

    public string GetStreetNum()
    {
      return _streetNum;
    }
    public void SetStreetNum(string newStreetNum)
    {
      _streetNum = newStreetNum;
    }
    public string GetStreetPrefix()
    {
      return _streetPrefix;
    }
    public void SetStreetPrefix(string newStreetPrefix)
    {
      _streetPrefix = newStreetPrefix;
    }
    public string GetStreetName()
    {
      return _streetName;
    }
    public void SetStreetName(string newStreetName)
    {
      _streetName = newStreetName;
    }
    public string GetStreetType()
    {
      return _streetType;
    }
    public void SetStreetType(string newStreetType)
    {
      _streetType = newStreetType;
    }
    public string GetCity()
    {
      return _city;
    }
    public void SetCity(string newCity)
    {
      _city = newCity;
    }
    public string GetState()
    {
      return _state;
    }
    public void SetState(string newState)
    {
      _state = newState;
    }
    public string GetZip()
    {
      return _zip;
    }
    public void SetZip(string newZip)
    {
      _zip = newZip;
    }
    public string AddressToString()
    {
      return (_streetNum + " " + _streetPrefix + " " + _streetName + " " + _streetType + " " + _city + ", " + _state + " " + _zip);
    }
  }
}
