using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnluCo.Bank.WEBAPI.models;

namespace UnluCo.Bank.WEBAPI.Rules
{
    public interface IRules
    {
      
        bool isValid(Bank_Accounts Account);
    }
}
