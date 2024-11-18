using Microsoft.AspNetCore.Mvc;
using ZEIL.HomeWork.Service.Interface;
using ZEIL.HomeWork.WebAPI.Controllers;
using ZEIL.HomeWork.DTO;
using Moq;


namespace ZEIL.HomeWork.WebAPI.Test.CreditCard.TestPost
{
    public abstract class TestValidateCard : ControllerBaseTest<CreditCardController>
    {
        protected Mock<ICreditCardService> _mockCreditCardService = new Mock<ICreditCardService>();

        protected string cardNo = string.Empty;
        protected override CreditCardController CreateService()
        {
            return new CreditCardController(_mockCreditCardService.Object);
        }

        public override void ResetMockedServices()
        {
            _mockCreditCardService.Reset();
        }

        public override Task ActAsync()
        {
            throw new NotImplementedException();
        }
    }

    public class WhenCardNoIsEmpty : TestValidateCard
    {
        public override void Act()
        {
            result = service.ValidateCard(cardNo);
        }

        [Fact]
        public void ShouldReturnBadRequestResult()
        {
            PerformTest();
            Assert.IsType<BadRequestObjectResult>(result);
        }

    }

    public class WhenCardNoIsValid : TestValidateCard
    {
        public override void Arrange()
        {
            base.Arrange();
            _mockCreditCardService.Setup(service =>
                service.ValidateCardNumber(It.Is<string>(cardNo => cardNo == cardNo)))
                .Returns(new ResultCardNumberValidation(true, "Credit Card number is valid"));
        }

        public override void Act()
        {
            cardNo = "79927398713";
            result = service.ValidateCard(cardNo);
        }

        [Fact]
        public void ShouldReturnOkResult()
        {
            PerformTest();
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void ShouldReturnValidResult()
        {
            PerformTest();
            Assert.True(result.Value.IsValid);
        }

        [Fact]
        public void ShouldReturnValidMessageResult()
        {
            PerformTest();
            Assert.Equal("Credit Card number is valid", result.Value.Message);
        }
    }

    public class WhenCardNoIsInValid : TestValidateCard
    {
        public override void Arrange()
        {
            base.Arrange();
            _mockCreditCardService.Setup(service =>
                    service.ValidateCardNumber(It.Is<string>(cardNo => cardNo == cardNo)))
                .Returns(new ResultCardNumberValidation(false, "Credit Card number is invalid"));
        }

        public override void Act()
        {
            cardNo = "79927398712";
            result = service.ValidateCard(cardNo);
        }

        [Fact]
        public void ShouldReturnOkResult()
        {
            PerformTest();
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void ShouldReturnValidResult()
        {
            PerformTest();
            Assert.False(result.Value.IsValid);
        }

        [Fact]
        public void ShouldReturnValidMessageResult()
        {
            PerformTest();
            Assert.Equal("Credit Card number is invalid", result.Value.Message);
        }
    }
}
