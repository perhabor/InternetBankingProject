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
    public class AccountRightController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<AccountRightController> _logger;
        private readonly IMapper _mapper;

        public AccountRightController(IUnitOfWork unitOfWork, ILogger<AccountRightController> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<IActionResult> GetAccountRights()
        {
            try
            {
                var accountrights = await _unitOfWork.AccountRights.GetAll();
                var results = _mapper.Map<List<AccountRightDto>>(accountrights);
                return Ok(accountrights);
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, $"Something went wrong in the {nameof(GetAccountRights)}");
                return StatusCode(500, "Internal server error. Please try again later.");
            }
        }


        [HttpGet("{id:int}")]

        public async Task<IActionResult> GetAccountRight(int id)
        {
            try
            {
                var accountright = await _unitOfWork.AccountRights.Get(q => q.Id == id, new List<string> { "AccountRights" });
                var result = _mapper.Map<List<AccountRightDto>>(accountright);
                return Ok(accountright);
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, $"Something went wrong in the {nameof(GetAccountRights)}");
                return StatusCode(500, "Internal server error. Please try again later.");
            }
        }

    }
}
