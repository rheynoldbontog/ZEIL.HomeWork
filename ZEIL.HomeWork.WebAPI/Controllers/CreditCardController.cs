using Microsoft.AspNetCore.Mvc;
using ZEIL.HomeWork.Service.Interface;

namespace ZEIL.HomeWork.WebAPI.Controllers
{
    [Route("api/creditcard")]
    [ApiController]
    public class CreditCardController : ControllerBase
    {
        private readonly ILuhnAlgorithmService _luhnAlgorithmService;
        public CreditCardController(ILuhnAlgorithmService luhnAlgorithmService)
        {
            _luhnAlgorithmService = luhnAlgorithmService;
        }

        [Route("isvalid/{cardNo}")]
        [HttpPost]
        public async Task<ActionResult> ValidateCard([FromRoute] string cardNo)
        {
            if (string.IsNullOrEmpty(cardNo))
                return BadRequest("Card number must not be empty.");

            try
            {
                bool validate = _luhnAlgorithmService.IsValid(cardNo);

                return Ok(validate);
            }
            catch
            {
                return BadRequest("There's an error in posting credit card.");
            }
        }
    }
}
