using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZEIL.HomeWork.DTO;

namespace ZEIL.HomeWork.Service.Interface
{
    public interface ICreditCardService
    {
        ResultCardNumberValidation ValidateCardNumber(string cardNumber);
    }
}
