namespace Net.Chdk.Meta.Providers.Camera.Ml
{
    sealed class MlBootProvider : BootProvider
    {
        protected override string GetBootFileSystem(uint modelId) => "exFAT";
    }
}
