// ContactManager.cs
using System;
using System.Collections.Generic;

namespace ContactManagerApp
{
    public class ContactManager
    {
        private List<Contact> contacts;

        public ContactManager()
        {
            contacts = new List<Contact>();
        }

        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
            Console.WriteLine($"Added contact: {contact.Name}");
        }

        public void ListContacts()
        {
            Console.WriteLine("Contacts:");
            foreach (var contact in contacts)
            {
                contact.DisplayInfo();
            }
        }

        public void RemoveContact(int index)
        {
            if (index < 0 || index >= contacts.Count)
            {
                Console.WriteLine("Invalid contact index.");
                return;
            }

            Console.WriteLine($"Removed contact: {contacts[index].Name}");
            contacts.RemoveAt(index);
        }
    }
}
