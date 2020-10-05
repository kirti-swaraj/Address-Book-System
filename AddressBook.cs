﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
   
     public class AddressBook
    {
        private List<Contact> addressBookList;
        public AddressBook()
        {
            addressBookList = new List<Contact>();

        }
         public void AddDetailsOfPersons(string firstName, string lastName, string address, string city, string state, int zip, double phoneNo, string eMail)
        {
            Contact contactPerson = new Contact(firstName, lastName, address, city, state, zip, phoneNo, eMail);
            addressBookList.Add(contactPerson);
        }
        public void DisplayContactPersonDetails()
        {
            int numberOfPersons = 1;
            foreach (Contact contactPerson in addressBookList)
            {

                Console.WriteLine("The Details of Contact Number {0} -", numberOfPersons);
                
                Console.WriteLine(" the first name is : " + contactPerson.firstName + " \n the last name is :" + contactPerson.lastName + "\n the address is : " + contactPerson.address + " \n the city is : " + contactPerson.city + " \n the state is " + contactPerson.state + "\n the zip is :" + contactPerson.zip + "\n the phone number is : " + contactPerson.phoneNo + " \n the email is :" + contactPerson.email);
                numberOfPersons++;
                Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            }
       
        }
    }
}
