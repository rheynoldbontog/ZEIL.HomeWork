using ZEIL.HomeWork.Service.Interface;

namespace ZEIL.HomeWork.Service.Validation
{
    public class LuhnAlgorithm : ILuhnAlgorithm
    {
        public bool IsValid(string number)
        {
            var sum = 0;
            var alternate = false;

            //iterate over the number string from right to left
            for (var i = number.Length - 1; i >= 0; i--)
            {
                //parse each character as a digit
                if (!char.IsDigit(number[i]))
                    return false;

                var digit = int.Parse(number[i].ToString());

                //double every second digit
                if (alternate)
                {
                    digit *= 2;
                    //if the result is greater than 9, subtract 9
                    if (digit > 9)
                        digit -= 9;
                }

                sum += digit;
                alternate = !alternate;
            }

            var partialSum = 10 - (sum % 10);
            return partialSum % 10 == 0;
        }
    }
}
