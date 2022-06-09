using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbBrowser
{
    public class Person
    {
        public int id;
        public string firstName;
        public string lastName;
        public string email;
        public string phone;

        public string FullInfo
        {
            get
            {
                return $"{id}\t{firstName}\t{lastName}\t{email}\t{phone}";
            }
        }
    }
}
