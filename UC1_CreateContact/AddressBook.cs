using System;
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
        public void AddDetailsOfPersons(string firstName, string lastName, string address, string city, string state, int zip, long phoneNo, string email)
        {
            Contact contact = new Contact(firstName, lastName, address, city, state, zip, phoneNo, email);
            addressBookList.Add(contact);
        }

        public void DisplayPersonDetails()
        {
            int numberOfPersons = 1;
            foreach (Contact contact in addressBookList)


            {

                Console.WriteLine("The Details of Contact Number {0} -", numberOfPersons);
                Console.WriteLine(" the first name is : " + contact.firstName + " \n the last name is :" + contact.lastName + "\n the address is : " + contact.address + " \n the city is : " + contact.city + " \n the state is " + contact.state + "\n the zip is :" + contact.zip + "\n the phone number is : " + contact.phoneNo + " \n the email is :" + contact.email);
                numberOfPersons++;
                
            }
        }


    }
}
