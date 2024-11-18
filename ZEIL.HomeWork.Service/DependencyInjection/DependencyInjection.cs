

using Microsoft.Extensions.DependencyInjection;
using ZEIL.HomeWork.Service.Interface;
using ZEIL.HomeWork.Service.Validation;

namespace ZEIL.HomeWork.Service.DependencyInjection
{
    public static class DependencyInjection
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<ILuhnAlgorithmService, LuhnAlgorithmService>();
        }
    }
}
