namespace jaytwo.RuntimeRevelation;

public static class IRuntimeInformationProviderExtensions
{
    public static RuntimeInformation GetRuntimeInformation(this IRuntimeInformationProvider provider) => new RuntimeInformation(provider);
}
