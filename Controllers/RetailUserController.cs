using AutoMapper;
using internetBankingProject.Models;
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
    public class RetailUserController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public RetailUserController(IUnitOfWork unitOfWork,ILogger logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;

            _logger = logger;
            _mapper = mapper;

        }

        [HttpGet]

        public async Task<IActionResult> GetRetailUsers()
        {
            try
            {
                var retailusers   = await _unitOfWork.RetailUsers.GetAll();
                var results = _mapper.Map<IList<RetailUserDto>>(retailusers);
                return Ok(retailusers);
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, $"Something went wrong in the {nameof(GetRetailUsers)}");
                return StatusCode(500, "Internal server error. Please try again later.");
            }
        }


      [HttpGet("{id:int}")]

        public async Task<IActionResult> GetRetailUser(int id)
        {
            try
            {
                var retailuser = await _unitOfWork.RetailUsers.Get(q => q.Id == id, new List<string> { "RetailUsers" });
                var result = _mapper.Map<RetailUserDto>(retailuser);
                return Ok(retailuser);
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, $"Something went wrong in the {nameof(GetRetailUsers)}");
                return StatusCode(500, "Internal server error. Please try again later.");
            }
        }


    }
}
