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
        public void AddDetailsOfPersons(string firstName, string lastName, string address, string city, string state, int zip, double phoneNo, string eMail)
        {
            Contact contact = new Contact(firstName, lastName, address, city, state, zip, phoneNo, eMail);
            addressBookList.Add(contact);
        }
        public void DisplayContactPersonDetails()
        {
            int numberOfPersons = 1;
            foreach (Contact contact in addressBookList)
            {

                Console.WriteLine("The Details of Contact Number {0} -", numberOfPersons);
                Console.WriteLine(" the first name is : " + contact.firstName + " \n the last name is :" + contact.lastName + "\n the address is : " + contact.address + " \n the city is : " + contact.city + " \n the state is " + contact.state + "\n the zip is :" + contact.zip + "\n the phone number is : " + contact.phoneNo + " \n the email is :" + contact.email);
                numberOfPersons++;
                Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            }
        }

        public void UpdateContactPersonDetails()
        {
            Console.WriteLine("enter the first name & last name of the person to be updated");
            string newFirstName = Console.ReadLine();
            string newLastName = Console.ReadLine();
            foreach (Contact contactPerson in addressBookList)
            {
                if (newFirstName == contactPerson.firstName && newLastName == contactPerson.lastName)
                {
                    Console.WriteLine("Enter the details to be updated");
                    contactPerson.address = Console.ReadLine();
                    contactPerson.city = Console.ReadLine();
                    contactPerson.state = Console.ReadLine();
                    contactPerson.zip = Convert.ToInt32(Console.ReadLine());
                    contactPerson.phoneNo = Convert.ToDouble(Console.ReadLine());
                    contactPerson.email = Console.ReadLine();
                    Console.WriteLine("details has been updated");

                }
            }
        }

    }
}

