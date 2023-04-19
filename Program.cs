using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PhoneBook phonebook = new PhoneBook();

            phonebook.InsertPhone("John", "1234567890");
            phonebook.InsertPhone("Jane", "0987654321");
            phonebook.InsertPhone("Doe", "1112223333");
            phonebook.InsertPhone("Smith", "5556667777");

            phonebook.SearchPhone("John");
            phonebook.SearchPhone("Jane");
            phonebook.SearchPhone("Doe");
            phonebook.SearchPhone("Smith");

            phonebook.RemovePhone("Jane");

            phonebook.SearchPhone("Jane");

            phonebook.UpdatePhone("John", "9998887777");

            phonebook.Sort();
            Console.WriteLine(phonebook);
            Console.ReadKey();
        }
    }
}