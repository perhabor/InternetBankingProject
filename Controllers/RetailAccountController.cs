using AutoMapper;
using InternetBankingProject.DTO;
using InternetBankingProject.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetBankingProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RetailAccountController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public RetailAccountController(IUnitOfWork unitOfWork, ILogger logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;

            _logger = logger;
            _mapper = mapper;

        }

      
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<IActionResult> GetRetailAccounts()
        {
            try
            {
                var retailaccounts = await _unitOfWork.RetailAccounts.GetAll();
                var results = _mapper.Map<IList<RetailAccountDto>>(retailaccounts);
                return Ok(retailaccounts);
                
               
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, $"Something went wrong in the {nameof(GetRetailAccounts)}");
                return StatusCode(500, "Internal server error. Please try again later.");
            }
        }


        [HttpGet("{id:int}")]

        public async Task<IActionResult> GetRetailAccount(int id)
        {
            try
            {
                var retailaccount = await _unitOfWork.RetailAccounts.Get(q => q.Id == id, new List<string> { "RetailAccounts" });
                var result = _mapper.Map<RetailAccountDto>(retailaccount);
                return Ok(retailaccount);
              
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, $"Something went wrong in the {nameof(GetRetailAccounts)}");
                return StatusCode(500, "Internal server error. Please try again later.");
            }
        }

    }
}
