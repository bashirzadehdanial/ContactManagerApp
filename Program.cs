// Program.cs
using System;

namespace ContactManagerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ContactManager contactManager = new ContactManager();
            string command;

            do
            {
                Console.WriteLine("Enter a command (add, list, remove, exit):");
                command = Console.ReadLine().ToLower();

                switch (command)
                {
                    case "add":
                        Console.WriteLine("Enter contact name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter phone number:");
                        string phoneNumber = Console.ReadLine();
                        Console.WriteLine("Enter email:");
                        string email = Console.ReadLine();
                        Contact contact = new Contact(name, phoneNumber, email);
                        contactManager.AddContact(contact);
                        break;
                    case "list":
                        contactManager.ListContacts();
                        break;
                    case "remove":
                        Console.WriteLine("Enter contact index to remove:");
                        if (int.TryParse(Console.ReadLine(), out int index))
                        {
                            contactManager.RemoveContact(index);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index.");
                        }
                        break;
                    case "exit":
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Unknown command.");
                        break;
                }
            } while (command != "exit");
        }
    }
}
