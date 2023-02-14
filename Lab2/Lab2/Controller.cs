using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab2
{
    internal class Controller
    {

        public void AddEntry(Person p, string phonenumber)
        {
            HashSet<Phone> phones = FindPhones(p);

            foreach(Phone phone in phones)
            {
                if(!phone.PhoneNumber.Equals(phonenumber))
                {
                    Phone newPhone = new Phone(phonenumber);
                    phones.Add(newPhone);
                }
            }
        }

        public HashSet<Phone> FindPhones (Person p)
        {        
                return p.phones;
        }

        public void RemoveEntry(Person p, string oldnumber)
        {
            HashSet<Phone> phones = FindPhones(p);

            foreach(Phone phone in phones) 
            {
                if(phone.PhoneNumber.Equals(oldnumber))
                {
                    phones.Remove(phone);
                }
            }
        }

    }
}
