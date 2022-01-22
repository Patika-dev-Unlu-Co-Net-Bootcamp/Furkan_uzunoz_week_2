using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnluCo.Bank.WEBAPI.models
{
    public class Bank_Accounts
    {
        public int id { get; set; }
        public string name { get; set; }
        public string tcNumber { get; set; }
        public int amount { get; set; }
        public string Adress { get; set; }
        public string Pass { get; set; }
    }
}
