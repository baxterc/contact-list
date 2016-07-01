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
        List<Contact> AllContacts = Contact.GetAll();
        return View["index.cshtml", AllContacts];
      };
      Get["/new"] = _ => {
        return View ["add-contact.cshtml"];
      };
      Post["/contact_created"] = _ =>{
        if (Request.Form["new-contact-name"] == "")
        {
          return View["contact-error.cshtml"];
        }
        else
        {
          Contact newContact = new Contact (Request.Form["new-contact-name"], Request.Form["new-phone-num"], Request.Form["new-address"], Request.Form["new-email"]);
          return View["contact-created.cshtml", newContact];
        }
      };
      Get["/contacts/{id}"] = parameters => {
        Contact SelectedContact = Contact.FindContact(parameters.id);
        return View["contact.cshtml", SelectedContact];
      };
      Post["/contacts_deleted"] = _ =>{
        Contact.DeleteAll();
        return View["contacts-deleted.cshtml"];
      };
    }
  }
}
