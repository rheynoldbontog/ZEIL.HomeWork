using Microsoft.AspNetCore.Mvc;
using ZEIL.HomeWork.Service.Interface;

namespace ZEIL.HomeWork.WebAPI.Controllers
{
    [Route("api/creditcard")]
    [ApiController]
    public class CreditCardController : ControllerBase
    {
        private readonly ICreditCardService _creditCardService;
        public CreditCardController(ICreditCardService creditCardService)
        {
            _creditCardService = creditCardService;
        }

        [Route("isvalid/{cardNo}")]
        [HttpPost]
        public ActionResult ValidateCard([FromRoute] string cardNo)
        {
            if (string.IsNullOrEmpty(cardNo))
                return BadRequest("Card number must not be empty.");

            try
            {
                var result = _creditCardService.ValidateCardNumber(cardNo);

                return Ok(result);
            }
            catch
            {
                return BadRequest("There's an error in posting credit card.");
            }
        }
    }
}
