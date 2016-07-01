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
      Get["/contacts"] = _ => {
        List<Contact> AllContacts = Contact.GetAll();
        return View["contacts.cshtml", AllContacts];
      };
      Post["/contact_created"] = _ =>{
        Contact newContact = new Contact (Request.Form["new-contact-name"], Request.Form["new-phone-num"], Request.Form["new-address"], Request.Form["new-email"]);
        return View["contact-created.cshtml", newContact];
      };
      Get["/contacts/{id}"] = parameters => {
        Contact SelectedContact = Contact.FindContact(parameters.id);
        return View["contact.cshtml", SelectedContact];
      };
    }
  }
}
