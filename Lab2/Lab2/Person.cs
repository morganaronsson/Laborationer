using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Person
    {
        private string name;
        public HashSet<Phone> phones;

        public string Name { get => name; set => name = value; }
    }
}
