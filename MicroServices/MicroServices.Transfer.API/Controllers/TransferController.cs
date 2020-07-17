using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MicroServices.Transfer.Application.Interfaces;
using MicroServices.Transfer.Domain.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MicroServices.Transfer.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransferController : ControllerBase
    {
        private readonly ITransferService _transferService;
        public TransferController(ITransferService transferService)
        {
            _transferService = transferService;
        }

        [HttpGet]
        public IEnumerable<TransferLog> Get()
        {
            return _transferService.GetTransferLogs();
        }
    }
}
