namespace ZEIL.HomeWork.WebAPI.Test.CreditCard
{
    public abstract class ControllerBaseTest<TService> : UnitTestBase<TService>
    {
        protected dynamic result;

        protected ControllerBaseTest()
        {
        }

        public virtual async Task PerformTestAsync()
        {
            Arrange();
            await ActAsync();
        }

        public override void Act()
        {
            throw new NotImplementedException();
        }
    }
}
