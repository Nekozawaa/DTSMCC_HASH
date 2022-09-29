using DTSMCC_Exam2.Repositories.Data;
using DTSMCC_Exam2.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace DTSMCC_Exam2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        AccountRepository accountRepository;
        public AccountController(AccountRepository accountRepository)
        {
            this.accountRepository = accountRepository;
        }

        [HttpPost]
        public IActionResult Login(Login login)
        {
            var data = accountRepository.Login(login);
            if(data != null)
                return Ok(new { message = "Berhasil Login", statusCode = 200, data = data });
            return BadRequest(new { message = "Gagal Login", statusCode = 400});
        }

        [HttpPost]
        public IActionResult Regist(Regist regist)
        {
            var result = accountRepository.Regist(regist);
            if (result != null)
                return Ok(new { statusCode = 200, message = "berhasil menambahkan data" });
            return BadRequest(new { statusCode = 400, message = "gagal menambahkan data" });
        }
    }
}
