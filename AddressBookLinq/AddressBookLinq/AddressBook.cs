using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace AddressBookLinq
{
    class AddressBook
    {
        public void CreateAddressBookDataTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("FirstName", typeof(string));
            dataTable.Columns.Add("LastName", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));
            dataTable.Columns.Add("City", typeof(string));
            dataTable.Columns.Add("State", typeof(string));
            dataTable.Columns.Add("Zip", typeof(int));
            dataTable.Columns.Add("PhoneNumber", typeof(long));
            dataTable.Columns.Add("Email", typeof(string));
        }
    }
}