using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            AddressBook addressBook = new AddressBook();
            addressBook.AddDetailsOfPersons("Kirti", "Swaraj", "home", "Nawada", "Bihar", 805110, 9854723, "kirti@gmail.com");
            addressBook.DisplayPersonDetails();
        }
    }
}