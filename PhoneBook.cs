using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    public class PhoneBook : Phone
    {
        private List<string[]> PhoneList;

        public PhoneBook()
        {
            PhoneList = new List<string[]>();
        }

        public override void InsertPhone(string name, string phone)
        {
            bool flag = false ;
            foreach (string[] element in PhoneList )
            {
                if (element[0] == name)
                {
                    flag = true;
                    if (element[1] != phone)
                    {
                        element[1] = phone;
                        Console.WriteLine("Phone number updated for user: " + name);
                    }
                    else
                    {
                        Console.WriteLine("Phone number already exists for user: " + name);
                    }
                    break;
                }
            }
            if (!flag)
            {
                PhoneList.Add(new string[] { name, phone });
                Console.WriteLine("User added to phonebook: " + name);
            }
        }

        public override void RemovePhone(string name)
        {
            int count = PhoneList.RemoveAll(element => element[0] == name);
            if (count > 0)
            {
                Console.WriteLine("User removed from phonebook: " + name);
            }
            else
            {
                Console.WriteLine("User not found in phonebook: " + name);
            }
        }

        public override void UpdatePhone(string name, string newphone)
        {
            foreach (string[] element in PhoneList)
            {
                if (element[0] == name)
                {
                    element[1] = newphone;
                    Console.WriteLine("Phone number updated for user: " + name);
                    return;
                }
            }
            Console.WriteLine("User not found in phonebook: " + name);
        }

        public override void SearchPhone(string name)
        {
            foreach (string[] element in PhoneList)
            {
                if (element[0] == name)
                {
                    Console.WriteLine("Phone number for user " + name + " is " + element[1]);
                    return;
                }
            }
            Console.WriteLine("User not found in phonebook: " + name);
        }

        public override void Sort()
        {
            PhoneList.Sort((x, y) => string.Compare(x[0], y[0]));
            Console.WriteLine("Phonebook sorted by username");
        }
    }
}
