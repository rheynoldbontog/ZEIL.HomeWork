using ZEIL.HomeWork.DTO;
using ZEIL.HomeWork.Service.Test.Base;

namespace ZEIL.HomeWork.Service.Test.CreditCardService
{
    public abstract class TestValidateNumber : LuhnAlgorithmTestBase
    {
        protected bool result;
    }

    public class WhenNumberValid : TestValidateNumber
    {
        private string CardNumber = "79927398713";

        public override void Act()
        {
            result = service.IsValid(CardNumber);
        }

        [Fact]
        public void ShouldReturnTrue()
        {
            PerformTest();
            Assert.True(result);
        }

    }

    public class WhenNumberInvalid : TestValidateNumber
    {
        private string CardNumber = "79927398712";
        public override void Act()
        {
            result = service.IsValid(CardNumber);
        }

        [Fact]
        public void ShouldReturnFalse()
        {
            PerformTest();
            Assert.False(result);
        }
    }
}
