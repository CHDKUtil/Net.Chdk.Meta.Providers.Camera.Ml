namespace Net.Chdk.Meta.Providers.Camera.Ml
{
    sealed class MlCameraBootProvider : CameraBootProvider
    {
        protected override string GetBootFileSystem(uint modelId) => "exFAT";
    }
}
