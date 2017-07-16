using Microsoft.Extensions.DependencyInjection;
using Net.Chdk.Meta.Providers.Camera.Eos;

namespace Net.Chdk.Meta.Providers.Camera.Ml
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMlProviders(this IServiceCollection serviceCollection)
        {
            return serviceCollection
                .AddEosCameraProviders()
                .AddSingleton<ICameraBootProvider, MlCameraBootProvider>()
                .AddSingleton<IEosCameraCardProvider, MlCameraCardProvider>();
        }
    }
}
