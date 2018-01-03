using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBookApp.Models
{
    public class Address
    {
        public int AddressID { get; set; }
        public string Name { get; set; }
        //3:
        public int PersonID { get; set; }
        public virtual Person person { get; set; }
    }
}
