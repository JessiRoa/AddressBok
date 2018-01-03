using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBookApp.Models
{
    public class Person
    {
        public int PersonID{ get; set; }
        public string Name { get; set; }
        //3:
        public List<Address> Addresses { get; set; }
    }
}
