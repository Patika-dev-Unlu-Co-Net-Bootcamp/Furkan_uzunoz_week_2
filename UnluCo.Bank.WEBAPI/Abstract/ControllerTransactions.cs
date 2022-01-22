using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnluCo.Bank.WEBAPI.Extension;
using UnluCo.Bank.WEBAPI.models;
using UnluCo.Bank.WEBAPI.Rules;

namespace UnluCo.Bank.WEBAPI.Abstract
{
    public class ControllerTransactions : Controllerabs
    {
        List<models.Bank_Accounts> Accounts = repo.Accounts;

        List<models.Bank_Accounts> AccountDublicate = new List<Bank_Accounts>();

        private readonly IRules rules;
        public ControllerTransactions(IRules rules)
        {
            this.rules = rules;
        }
        
        public override List<Bank_Accounts> CreatedNewAccount(Bank_Accounts Account)
        {
            AccountDublicate.Clear();
            var account = Accounts.Where(account => account.id == Account.id).SingleOrDefault();
            if (account is not null)
            {
                return AccountDublicate ;
            }
            var result = rules.isValid(Account);
            if (result == true)
            {
                Accounts.Add(Account);
                AccountDublicate.Add(Account);
                
            }
            return AccountDublicate ;
        }

        public override List<Bank_Accounts> DeleteAccount(int id)
        {
            AccountDublicate.Clear();
            var account = Accounts.SingleOrDefault(account => account.id == id);
            if (account is null)
            {
                return AccountDublicate ;
            }
            AccountDublicate.Add(account);
            Accounts.Remove(account);
            return AccountDublicate ;
        }

        public override List<Bank_Accounts> filtrele(string str)
        {
            AccountDublicate.Clear();
            var accounts = Accounts.Where(p => p.name.Contains(str));
            if (accounts is null)
            {
                return AccountDublicate;
            }
            foreach (var item in accounts)
            {
                AccountDublicate.Add(item);
            }
           
            return AccountDublicate ;
        }

        public override List<Bank_Accounts> GetAccountByİd(int id)
        {
            AccountDublicate.Clear();
            var acount = Accounts.Where(acount => acount.id == id).SingleOrDefault();

            if (acount is null)
            {
                return AccountDublicate;
            }
            AccountDublicate.Add(acount);
            return AccountDublicate ;
        }

        public override List<Bank_Accounts> GetAllAccount()
        {
            AccountDublicate.Clear();
            var allacounts = Accounts.OrderBy(x => x.id).ToList<models.Bank_Accounts>();
            return allacounts ; 
        }

        public override List<Bank_Accounts> GetVip()
        {
            AccountDublicate.Clear();
            int x = 0;
            foreach (var acc in Accounts)
            {
                if (acc.amount.isAccVip())
                {
                    AccountDublicate.Add(acc);
                    x++;
                }
            }
            
            return AccountDublicate ;
        }

        public override List<Bank_Accounts> patch(int id, int amount)
        {
            AccountDublicate.Clear();
            var account = Accounts.SingleOrDefault(account => account.id == id);
            if (account is null)
            {
                return AccountDublicate;
            }
            account.amount = amount != default ? amount : account.amount;

            AccountDublicate.Add(account);
            return AccountDublicate ;
        }

        public override List<Bank_Accounts> sirala()
        {
            AccountDublicate.Clear();

            var account = Accounts.OrderBy(x => x.name).ToList();

            return account ;
        }

        public override List<Bank_Accounts> UpdateAccount(int id, Bank_Accounts NewAccount)
        {

            AccountDublicate.Clear();

            var account = Accounts.Where(account => account.id == id).SingleOrDefault();
            if (account is null)
            {
                return AccountDublicate;
            }
            account.id = NewAccount.id != default ? NewAccount.id : account.id;
            account.name = NewAccount.name != default ? NewAccount.name : account.name;
            account.tcNumber = NewAccount.tcNumber != default ? NewAccount.tcNumber : account.tcNumber;
            account.amount = NewAccount.amount != default ? NewAccount.amount : account.amount;

            AccountDublicate.Add(account);

            return AccountDublicate ;
        }
    }
}
