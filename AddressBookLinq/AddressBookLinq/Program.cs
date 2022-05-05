using AddressBooklinq;

using System;
using System.Data;

namespace AddressBookLinq
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book Using LINQ");
            AddressBook address = new AddressBook();
            Contact contact = new Contact();
            int option = 0;
            do
            {
                Console.WriteLine("1: For Add the Contact");
                Console.WriteLine("2: For Display Contact");
                Console.WriteLine("3.For Edit Contact");
                Console.WriteLine("4.For Delete Contact");
                Console.WriteLine("5.For Retrieving contact by State");
                Console.WriteLine("6.For Retrieving contact by City");
               
                Console.WriteLine("0: For Exist");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter First Name:");
                        contact.FirstName = Console.ReadLine();
                        Console.WriteLine("Enter Last Name:");
                        contact.LastName = Console.ReadLine();
                        Console.WriteLine("Enter Address:");
                        contact.Address = Console.ReadLine();
                        Console.WriteLine("Enter City:");
                        contact.City = Console.ReadLine();
                        Console.WriteLine("Enter State:");
                        contact.State = Console.ReadLine();
                        Console.WriteLine("Enter Zip code:");
                        contact.ZipCode = Console.ReadLine();
                        Console.WriteLine("Enter Phone Number:");
                        contact.PhoneNumber = Console.ReadLine();
                        Console.WriteLine("Enter Email:");
                        contact.Email = Console.ReadLine();
                        address.AddContact(contact);
                        break;
                    case 2:
                        address.DisplayContacts();
                        break;
                    case 3:
                        Console.WriteLine("Enter First Name: ");
                        contact.FirstName = Console.ReadLine();
                        Console.WriteLine("Enter Last Name: ");
                        contact.LastName = Console.ReadLine();
                        Console.WriteLine("Enter Address: ");
                        contact.Address = Console.ReadLine();
                        Console.WriteLine("Enter City: ");
                        contact.City = Console.ReadLine();
                        Console.WriteLine("Enter State: ");
                        contact.State = Console.ReadLine();
                        Console.WriteLine("Enter Zip code: ");
                        contact.ZipCode = Console.ReadLine();
                        Console.WriteLine("Enter Phone Number: ");
                        contact.PhoneNumber = Console.ReadLine();
                        Console.WriteLine("Enter Email ID: ");
                        contact.Email = Console.ReadLine();
                        address.EditContact(contact);
                        break;
                    case 4:
                        Console.WriteLine("Enter First Name: ");
                        contact.FirstName = Console.ReadLine();
                        Console.WriteLine("Enter Last Name: ");
                        contact.LastName = Console.ReadLine();
                        address.DeleteContact(contact);
                        break;
                    case 5:
                        Console.WriteLine("Enter State: ");
                        contact.State = Console.ReadLine();
                        address.RetrievePersonDataByUsingState(contact);
                        break;
                    case 6:
                        Console.WriteLine("Enter City: ");
                        contact.City = Console.ReadLine();
                        address.RetrievePersonDataByUsingCity(contact);
                        break;
                    case 7:
                        Console.WriteLine("Enter City :");
                        contact.City= Console.ReadLine();
                        Console.WriteLine("Enter State:");
                        contact.State = Console.ReadLine();
                        address.CountByCityOrState(contact);
                        break;
                    case 8:
                        Console.WriteLine("Enter the city for sorting = ");
                        contact.City = Console.ReadLine();
                        address.sortContactAlphabeticallyForGivenCity(contact);
                        break;
                    case 0:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Invalid Input Please Choose Correct Option");
                        break;
                   
                }
            }
            while (option != 0);
        }
    }
}
