using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC4_AddressBook
{
    class AddBook
    {
        static void Main(string[] args)
        {
            AddrBook.GetCustomer();
            AddrBook.Modify();
            AddrBook.ListingPeople();
            AddrBook.RemovePeople();

        }
    }
}