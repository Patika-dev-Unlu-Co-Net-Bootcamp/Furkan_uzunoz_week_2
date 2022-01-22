using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnluCo.Bank.WEBAPI.Rules
{
    public class İsUsefullForPass : IRules
    {
       
        bool IRules.isValid(models.Bank_Accounts Account)
        {
            var İsupper = Account.Pass.ToCharArray();
            var isUpper = Account.Pass.Any(e => Char.IsUpper(e));
            var isLower = Account.Pass.Any(Char.IsLower);
            var isDigit = Account.Pass.Any(Char.IsDigit);
            if(isUpper==false || isLower ==false || isDigit == false)
            {
                return false;
            }
            return true;
        }
        
    }
}
