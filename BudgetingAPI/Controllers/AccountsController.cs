using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BudgetingAPI.Models;
using BudgetingAPI.Repositories;
using AutoMapper;
using BudgetingAPI.DataTransferObjects;

namespace BudgetingAPI.Controllers
{
    //TODO : Just check api/controller to controller
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly ILogger<AccountsController> _logger;
        private IAccountRepository accountRepository;
        private readonly IMapper mapper;
        public AccountsController(ILogger<AccountsController> logger, IMapper mapper, IAccountRepository accountRepository )
        {
            this._logger = logger;
            this.accountRepository = accountRepository;
            this.mapper = mapper;
        }

        [HttpGet("id")]
        public ActionResult<AccountDto> Get(int id)
        {
            try
            {
                AccountDto account = accountRepository.GetAccountById(id);
                return account;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}