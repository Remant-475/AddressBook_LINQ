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
            int option = 0;
            do
            {
                Console.WriteLine("1: For Add the Contact");
                Console.WriteLine("2: For Display Contact");
                Console.WriteLine("0: For Exist");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        address.AddContact();
                        break;
                    case 2:
                        address.DisplayContacts();
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
