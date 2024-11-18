using ZEIL.HomeWork.Service.Validation;


namespace ZEIL.HomeWork.Service.Test.Base
{
    public abstract class LuhnAlgorithmTestBase : UnitTestBase<LuhnAlgorithm>
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

        protected override LuhnAlgorithm CreateService()
        {
            return new LuhnAlgorithm();
        }
    }
}
