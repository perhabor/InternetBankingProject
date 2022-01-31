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
    public class DeliveryModeController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<DeliveryModeController> _logger;
        private readonly IMapper _mapper;

        public DeliveryModeController(IUnitOfWork unitOfWork, ILogger<DeliveryModeController> logger,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<IActionResult> GetDeliveryModes()
        {
            try
            {
                var deliveryModes = await _unitOfWork.DeliveryModes.GetAll();
                var results = _mapper.Map<List<DeliveryModeDto>>(deliveryModes);
                return Ok(deliveryModes);
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, $"Something went wrong in the {nameof(GetDeliveryModes)}");
                return StatusCode(500, "Internal server error. Please try again later.");
            }
        }


        [HttpGet("{id:int}")]

        public async Task<IActionResult> GetDeliveryMode(int id)
        {
            try
            {
                var deliverymode = await _unitOfWork.DeliveryModes.GetAll();
                var results = _mapper.Map<List<DeliveryModeDto>>(deliverymode);
                return Ok(deliverymode);
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, $"Something went wrong in the {nameof(GetDeliveryModes)}");
                return StatusCode(500, "Internal server error. Please try again later.");
            }
        }

    }
}
