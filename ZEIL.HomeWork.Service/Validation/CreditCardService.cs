using ZEIL.HomeWork.DTO;
using ZEIL.HomeWork.Service.Interface;

namespace ZEIL.HomeWork.Service.Validation
{
    public class CreditCardService : ICreditCardService
    {
        private readonly ILuhnAlgorithm _luhnAlgorithm;
        public CreditCardService(ILuhnAlgorithm luhnAlgorithm)
        {
            _luhnAlgorithm = luhnAlgorithm;
        }

        public ResultCardNumberValidation ValidateCardNumber(string cardNumber)
        {
            var isValid = _luhnAlgorithm.IsValid(cardNumber);
            var message = isValid ? "Credit Card number is valid" : "Credit Card number is invalid";
            return new ResultCardNumberValidation(isValid, message);
        }
    }
}
