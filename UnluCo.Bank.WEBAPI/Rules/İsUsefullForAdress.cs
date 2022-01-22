using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnluCo.Bank.WEBAPI.Rules
{
    public class İsUsefullForAdress : IRules
    {
        bool IRules.isValid(models.Bank_Accounts Account)
        {
            int sayac = 0;
            var str = Account.Adress;
            for (int i = 0; i < Account.Adress.Length; i++)
            {
                if (str[i] == ',')
                {
                    sayac++;
                }
            }
            if (sayac == 3)
            {
                return true;
            }
            return false;
        }
    }
}
