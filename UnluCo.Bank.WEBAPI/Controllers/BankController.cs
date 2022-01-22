using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using UnluCo.Bank.WEBAPI.Abstract;
using UnluCo.Bank.WEBAPI.Extension;
using UnluCo.Bank.WEBAPI.Rules;

namespace UnluCo.Bank.WEBAPI.Controllers
{
    [Route("api/bank")]
    [ApiController]
    public class BankController : ControllerBase
    {
        private readonly IRules rules ;
        public static İsUsefullForAdress adress = new İsUsefullForAdress();
        public BankController(IRules rules)
        {
            this.rules = rules;
        }
        ControllerTransactions transactions = new ControllerTransactions(adress) ;


        List<models.Bank_Accounts> Accounts=repo.Accounts ;
        
        [HttpGet("GetVip")]
        public IActionResult GetVip()
        {

            try
            {
                var result = transactions.GetVip();
                return Ok(result);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        public IActionResult GetAllAccount()
        {
            try
            {
                var result =transactions.GetAllAccount();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("{id}")]

        public IActionResult GetAccountByİd(int id)
        {
            try
            {
                var result = transactions.GetAccountByİd(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
        [HttpPost]
        public IActionResult CreatedNewAccount([FromForm] models.Bank_Accounts Account)
        {
            try
            {
                var resultt = transactions.CreatedNewAccount(Account);
                if (resultt.Count == 0)
                {
                    return Ok("eklenemedi kurallara uymuyor.");
                }
                return Ok("başarı ile eklendi.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }
        [HttpPut("{id}")]
        public IActionResult UpdateAccount(int id,[FromBody] models.Bank_Accounts NewAccount)
        {
            try
            {
                var resultt = transactions.UpdateAccount(id,NewAccount);
                if (resultt.Count == 0)
                {
                    return Ok("Güncellenemedi.");
                }
                return Ok("başarı ile Güncellendi.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]

        public IActionResult DeleteAccount(int id)
        {
            try
            {
                var resultt = transactions.DeleteAccount(id);
                if (resultt.Count == 0)
                {
                    return Ok("Silinemedi.");
                }
                return Ok("başarı ile Silindi.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpGet("sirala")]

        public IActionResult sirala()
        {
            try
            {
                var resultt = transactions.sirala();

                return Ok(resultt);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("kelimeye_göre_ad_filtrele")]

        public IActionResult filtrele(string kelime)
        {
            try
            {
                var resultt = transactions.filtrele(kelime);

                return Ok(resultt);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPatch("{id}")]

        public IActionResult patch(int id,int amount)
        {
            try
            {
                var resultt = transactions.patch(id, amount);
                if (resultt.Count == 0)
                {
                    return Ok("Güncellenemedi.");
                }
                return Ok("başarı ile Güncellendi.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

  
        

    }
}
