using Nancy;
using System.Collections.Generic;
using Contacts.Objects;
using StreetAddresses.Objects;

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
        if (Request.Form["new-contact-firstname"] == "" && Request.Form["new-contact-lastname"] == "")
        {
          return View["contact-error.cshtml"];
        }
        else
        {
          StreetAddress newStreetAddress = new StreetAddress (Request.Form["new-street-number"], Request.Form["new-street-prefix"], Request.Form["new-street-name"], Request.Form["new-street-type"], Request.Form["new-city"], Request.Form["new-state"], Request.Form["new-zip"]);
          Contact newContact = new Contact (Request.Form["new-contact-firstname"], Request.Form["new-contact-lastname"], Request.Form["new-phone-num"], newStreetAddress, Request.Form["new-email"]);
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
      Post["/search_results"] = _ =>{
        List<Contact> foundContacts = Contact.ContactSearch(Request.Form["search-name"]);
        return View["contact-results.cshtml", foundContacts];
      };
    }
  }
}
