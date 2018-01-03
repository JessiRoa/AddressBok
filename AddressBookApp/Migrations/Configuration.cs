using AddressBookApp.Data;
using AddressBookApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBookApp
{
    public class DbSeed
    {
        public static void Seed(ApplicationDbContext context)
        {
            var PersonName1 = new Person { Name = "Jessica Roa", };
            context.Add(PersonName1);
            var PersonName2 = new Person { Name = "Mattias Asplund", };
            context.Add(PersonName2);

            var address1 = new Address { Name = "Karl martins väg 4", person = PersonName1 };
            context.Add(address1);
            var address2 = new Address { Name = "Tomtebodavägen 3A", person = PersonName2 };
            context.Add(address2);
            context.SaveChanges();
        }
    }
}