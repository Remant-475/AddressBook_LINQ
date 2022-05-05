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
            dataTable.Columns.Add("ZipCode", typeof(string));
            dataTable.Columns.Add("PhoneNumber", typeof(string));
            dataTable.Columns.Add("Email", typeof(string));

            dataTable.Rows.Add("Ravi", "Kumar", "Gowtham Nagar", "Bangarpet", "Karnataka", "563114", "8073112156", "shashidhar.sasic@gmail.com");
            dataTable.Rows.Add("Lalith", "Kumar", "Vijay Nagar", "Bangarpet", "Karnataka", "563122", "8223112156", "lalith.lalu@gmail.com");
            dataTable.Rows.Add("Mohan", "Kumar", "Shanthi Nagar", "Bangalore", "Tamilnadu", "560018", "9973112156", "mohanrah.mohan@gmail.com");
            dataTable.Rows.Add("Kiran", "Kumar", "Ambedkar Nagar", "Kolar", "AndhraPradesh", "561363", "8073174156", "kiran.Kid@gmail.com");
            dataTable.Rows.Add("Sridhar", "Kumar", "Amravathi Nagar", "Patna", "Bihar", "560018", "8073114656", "sridhar.sri@gmail.com");
            dataTable.Rows.Add("Praveen", "Kumar", "Vivekanandha Nagar", "Dhanbad", "Jharkhand", "563441", "8000112156", "praveen.pravi@gmail.com");
        }
    
        
            public void AddContact(Contact contact)
            {
                dataTable.Rows.Add(contact.FirstName, contact.LastName, contact.Address, contact.City, contact.State,
                    contact.ZipCode, contact.PhoneNumber, contact.Email);
                Console.WriteLine("Contact Added SuccesFull");
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
                Console.WriteLine("ZipCode:-" + contact.Field<string>("Zip"));
                Console.WriteLine("PhoneNumber:-" + contact.Field<string>("PhoneNumber"));
                Console.WriteLine("Email:-" + contact.Field<string>("Email"));
                Console.WriteLine();
            }
        }
        public void EditContact(Contact contact)
        {
            /// linq query to Check exist or not
            /// Returns first element of sequence
            var recordedData = dataTable.AsEnumerable().Where(data => data.Field<string>("FirstName") == contact.FirstName).First();
            if (recordedData != null)
            {
                recordedData.SetField("LastName", contact.LastName);
                recordedData.SetField("Address", contact.Address);
                recordedData.SetField("City", contact.City);
                recordedData.SetField("State", contact.State);
                recordedData.SetField("ZipCode", contact.ZipCode);
                recordedData.SetField("PhoneNumber", contact.PhoneNumber);
                recordedData.SetField("Email", contact.Email);
            }
            else
            {
                Console.WriteLine("No dataFound");
            }
        }
        public void DeleteContact(Contact contact)
        {
            var recordedData = dataTable.AsEnumerable()
                               .Where(data => (data.Field<string>("FirstName") == contact.FirstName) &&
                               (data.Field<string>("LastName") == contact.LastName)).First();
            if (recordedData != null)
            {
                recordedData.Delete();
            }
        }
        public void RetrievePersonDataByUsingState(Contact contact)
        {
            var selectedData = from dataTable in dataTable.AsEnumerable()
                             .Where(dataTable => dataTable.Field<string>("State") == contact.State)
                               select dataTable;
            foreach (var table in selectedData.AsEnumerable())
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("FirstName:- " + table.Field<String>("FirstName"));
                Console.WriteLine("LastName:- " + table.Field<String>("LastName"));
                Console.WriteLine("Address:- " + table.Field<String>("Address"));
                Console.WriteLine("City:- " + table.Field<String>("City"));
                Console.WriteLine("State:- " + table.Field<String>("State"));
                Console.WriteLine("ZipCode:- " + table.Field<String>("ZipCode"));
                Console.WriteLine("PhoneNumber:- " + table.Field<String>("PhoneNumber"));
                Console.WriteLine("Email:- " + table.Field<String>("Email"));
                Console.WriteLine("---------------------------------------------");
            }
        }

  
        public void RetrievePersonDataByUsingCity(Contact contact)
        {
            var selectedData = from dataTable in dataTable.AsEnumerable()
                             .Where(dataTable => dataTable.Field<string>("City") == contact.City)
                               select dataTable;
            foreach (var table in selectedData.AsEnumerable())
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("FirstName:- " + table.Field<String>("FirstName"));
                Console.WriteLine("LastName:- " + table.Field<String>("LastName"));
                Console.WriteLine("Address:- " + table.Field<String>("Address"));
                Console.WriteLine("City:- " + table.Field<String>("City"));
                Console.WriteLine("State:- " + table.Field<String>("State"));
                Console.WriteLine("ZipCode:- " + table.Field<String>("ZipCode"));
                Console.WriteLine("PhoneNumber:- " + table.Field<String>("PhoneNumber"));
                Console.WriteLine("Email:- " + table.Field<String>("Email"));
                Console.WriteLine("---------------------------------------------");
            }
        }
    }
}