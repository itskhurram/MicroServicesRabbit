using MicroServices.Banking.Application.Interfaces;
using MicroServices.Banking.Application.Models;
using MicroServices.Banking.Domain.Models;

using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;

namespace MicroServices.Banking.API.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class BankingController : ControllerBase {
        private readonly IAccountService _accountService;

        public BankingController(IAccountService accountService) {
            _accountService = accountService;
        }

        [HttpGet]
        public IEnumerable<Account> Get() {
            return _accountService.GetAccounts();
        }
        [HttpPost]
        public IActionResult Post([FromBody] AccountTransfer accountTransfer) {
            _accountService.Transfer(accountTransfer);
            return Ok(null);
        }
    }
}
