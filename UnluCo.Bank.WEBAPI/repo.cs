using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnluCo.Bank.WEBAPI
{
    public class repo
    {
        public static List<models.Bank_Accounts> Accounts = new List<models.Bank_Accounts>
        {
            new models.Bank_Accounts
            {
                id=2 ,
                Adress="Amasya,merkez,55 evler",
                Pass="Furkan05.",
                name="Furkan",
                tcNumber="123123",
                amount=1231
            },
            new models.Bank_Accounts
            {
                id=1 ,
                name="Selin",
                 Adress="Amasya,merkez,55 evler",
                Pass="Furkan05.",
                tcNumber="134532",
                amount=4234
            },
            new models.Bank_Accounts
            {
                id=5 ,
                name="Ahmet",
                Adress="Amasya,merkez,55 evler",
                Pass="Furkan05.",
                tcNumber="543423",
                amount=1543
            },
            new models.Bank_Accounts
            {
                id=4 ,
                name="Nazlı",
                Adress="Amasya,merkez,55 evler",
                Pass="Furkan05.",
                tcNumber="146354",
                amount=6564
            },
            new models.Bank_Accounts
            {
                id=3 ,
                name="Berkay",
                Adress="Amasya,merkez,55 evler",
                Pass="Furkan05.",
                tcNumber="123454",
                amount=8453
            },
        };

        public List<models.Bank_Accounts> getAllData() 
        {
            return Accounts ;
        }
    }
}
