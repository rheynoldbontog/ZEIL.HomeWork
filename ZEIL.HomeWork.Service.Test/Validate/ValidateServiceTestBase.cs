using ZEIL.HomeWork.Service.Validation;

namespace ZEIL.HomeWork.Service.Test.Validate
{
    public class ValidateServiceTestBase : UnitTestBase<LuhnAlgorithmService>
    {
        public override void Act()
        {
            throw new NotImplementedException();
        }

        public override Task ActAsync()
        {
            throw new NotImplementedException();
        }

        public override void ResetMockedServices()
        {
            
        }

        protected override LuhnAlgorithmService CreateService()
        {
            return new LuhnAlgorithmService();
        }
    }
}
