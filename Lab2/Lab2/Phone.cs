using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Phone
    {
        private string phoneNumber;
        public HashSet<Person> persons;

        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        public Phone(string value) { this.phoneNumber = value; }  

        
       
    }
}
