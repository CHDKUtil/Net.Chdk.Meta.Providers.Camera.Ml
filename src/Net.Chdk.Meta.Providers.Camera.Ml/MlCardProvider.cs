using Net.Chdk.Meta.Providers.Camera.Eos;

namespace Net.Chdk.Meta.Providers.Camera.Ml
{
    sealed class MlCardProvider : EosCardProvider
    {
        protected override string GetCardType(uint modelId) => "SD";
    }
}
