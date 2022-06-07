// See https://aka.ms/new-console-template for more information
using homework3.Db;

Console.WriteLine("Hello, World!" );
ContactsContext contacts = new ContactsContext();
contacts.Add( new Contact() );
Console.WriteLine(contacts);
contacts.SaveChanges();
