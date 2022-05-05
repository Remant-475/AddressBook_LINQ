using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using AddressBookLinq;

namespace AddressBooklinq
{
    class AddressBook
    {
        DataTable dataTable = new DataTable();

        public AddressBook()
        {
            dataTable.Columns.Add("FirstName", typeof(string));
            dataTable.Columns.Add("LastName", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));
            dataTable.Columns.Add("City", typeof(string));
            dataTable.Columns.Add("State", typeof(string));
            dataTable.Columns.Add("Zip", typeof(int));
            dataTable.Columns.Add("PhoneNumber", typeof(long));
            dataTable.Columns.Add("Email", typeof(string));
        }
        public void AddContact()
        {
            dataTable.Rows.Add("Remant", "Mahato", "Jorapokhar", "Dhanbad", "Jharkhand", 828112, 8271630771, "remantmahato9798@gmail.com");
            dataTable.Rows.Add("Hemant", "Mahato", "Jorapokhar", "Dhanbad", "Jharkhand", 828112, 7979367171, "hemant402@gmail.com");
            dataTable.Rows.Add("Aman", "Singh", "Newtown", "Kolkata", "WestBengal", 7003213, 9572846335, "aman147@gmail.com");
            dataTable.Rows.Add("Shubham", "Singh", "Sector-2", "Bokaro", "Jharkhand", 831005, 8271453692, "shubham145@gmail.com");
            dataTable.Rows.Add("Ajit", "Kumar", "Ashoknagar", "Patna", "Bihar", 865112, 9571593571, "ajit957@gmail.com");
            Console.WriteLine("Contact is Added in Address Book ");

        }
        public void DisplayContacts()
        {
            foreach (var contact in dataTable.AsEnumerable())
            {
                Console.WriteLine("First Name:" + contact.Field<string>("FirstName"));
                Console.WriteLine("LastName:-" + contact.Field<string>("LastName"));
                Console.WriteLine("Address:-" + contact.Field<string>("Address"));
                Console.WriteLine("City:-" + contact.Field<string>("City"));
                Console.WriteLine("State:-" + contact.Field<string>("State"));
                Console.WriteLine("ZipCode:-" + contact.Field<int>("Zip"));
                Console.WriteLine("PhoneNumber:-" + contact.Field<long>("PhoneNumber"));
                Console.WriteLine("Email:-" + contact.Field<string>("Email"));
                Console.WriteLine();
            }
        }
    }
}