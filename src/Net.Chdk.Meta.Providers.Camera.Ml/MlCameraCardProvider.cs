using Net.Chdk.Meta.Providers.Camera.Eos;

namespace Net.Chdk.Meta.Providers.Camera.Ml
{
    sealed class MlCameraCardProvider : EosCameraCardProvider
    {
        protected override string GetCardType(uint modelId) => "SD";
    }
}
