using Nancy;
using System.Collections.Generic;
using Contacts.Objects;

namespace Contacts
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View ["index.cshtml"];
      };
      Get["/contacts"] = _ => {
        return View ["contacts.cshtml"];
      };
      Get["/contacts/new"] = _ => {
        return View ["add-contact.cshtml"];
      };
    }
  }
}
