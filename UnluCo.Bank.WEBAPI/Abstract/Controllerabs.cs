using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnluCo.Bank.WEBAPI.Abstract
{
    abstract public class Controllerabs
    {
        public abstract List<models.Bank_Accounts> GetVip ();

        public abstract List<models.Bank_Accounts> GetAllAccount();

        public abstract List<models.Bank_Accounts> GetAccountByİd(int id);

        public abstract List<models.Bank_Accounts> CreatedNewAccount(models.Bank_Accounts Account);

        public abstract List<models.Bank_Accounts> UpdateAccount(int id, models.Bank_Accounts NewAccount);

        public abstract List<models.Bank_Accounts> DeleteAccount(int id); 

        public abstract List<models.Bank_Accounts> sirala();

        public abstract List<models.Bank_Accounts> filtrele(string str);

        public abstract List<models.Bank_Accounts> patch(int id, int amount);
    }
}
