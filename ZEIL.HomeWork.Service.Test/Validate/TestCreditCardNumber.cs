
namespace ZEIL.HomeWork.Service.Test.Validate
{
    public abstract class TestCreditCardNumber : ValidateServiceTestBase
    {
        protected bool IsValid;
    }

    public class WhenValidatingCreditCardSuccess : TestCreditCardNumber
    {
        private string CardNumber = "79927398713";
        public override void Act()
        {
            IsValid = service.IsValid(CardNumber);
        }

        [Fact]
        public void ShouldReturnTrue()
        {
            PerformTest();
            Assert.True(IsValid);
        }
    }

    public class WhenValidatingCreditCardFail : TestCreditCardNumber
    {
        private string CardNumber = "79927398712";
        public override void Act()
        {
            IsValid = service.IsValid(CardNumber);
        }

        [Fact]
        public void ShouldReturnFalse()
        {
            PerformTest();
            Assert.False(IsValid);
        }
    }
}
