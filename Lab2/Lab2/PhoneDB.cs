using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    abstract class PhoneDB
    {
        private HashSet<string> members;
        private HashSet<string> telephones = new HashSet<string>();

        public HashSet<string> FindPhones(string name)
        {
            HashSet<string> phonesforaperson = new HashSet<string>();
            foreach (string s in telephones)
            {
                if (telephones.Contains(s))
                {
                    phonesforaperson.Add(s);
                }
            }
            return phonesforaperson;
        }

        public void AddEntry(string name, string phonenumber)
        {
            HashSet<string> phones = FindPhones(name);

            foreach (string phone in phones)
            {
                if (!phone.Contains(phonenumber))
                {
                    telephones.Add(name + " " + phonenumber);
                    
                }
            }
        }

        public void RemoveEntry(string name, string oldnumber)
        {
            HashSet<string> phones = FindPhones(name);

            foreach (string phone in phones)
            {
                if (phone.Contains(oldnumber))
                {
                    if (phone.Contains(name))
                    {
                        telephones.Remove(phone);
                    }
                }
            }
        }
    }
}
