
namespace ZEIL.HomeWork.Service.Test
{
    public abstract class UnitTestBase<TService>
    {
        protected TService service;
        protected abstract TService CreateService();
        public virtual void Arrange()
        {
            ResetMockedServices();
            service = CreateService();
        }

        public abstract void ResetMockedServices();
        public abstract void Act();
        public abstract Task ActAsync();
        public virtual void PerformTest()
        {
            Arrange();
            Act();
        }

        public virtual void PerformTestAsync()
        {
            Arrange();
            ActAsync();
        }
    }
}
