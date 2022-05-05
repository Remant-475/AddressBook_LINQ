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
                Console.WriteLine("ZipCode:-" + contact.Field<int>("Zip"));
                Console.WriteLine("PhoneNumber:-" + contact.Field<long>("PhoneNumber"));
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
    }
}