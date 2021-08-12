using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonebookApp
{
    class Contact
    {
        public Contact(string name,string number)
        {
            this.name = name;
            this.number = number;

        }
        public string name { get; set; }
        public string number { get; set; }
    }
}
