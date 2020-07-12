using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MicroServices.Banking.Application.Interfaces;
using MicroServices.Banking.Domain.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MicroServices.Banking.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BankingController : ControllerBase
    {
        private readonly ILogger<BankingController> _logger;
        private readonly IAccountService _accountService;

        public BankingController(ILogger<BankingController> logger, IAccountService accountService)
        {
            _logger = logger;
            _accountService = accountService;
        }

        [HttpGet]
        public IEnumerable<Account> Get()
        {
            return _accountService.GetAccounts();
        }
    }
}
