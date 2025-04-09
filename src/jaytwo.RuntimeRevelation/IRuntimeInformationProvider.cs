namespace jaytwo.RuntimeRevelation;

public interface IRuntimeInformationProvider
{
    Architecture GetProcessArchitecture();

    OSPlatform GetOSPlatform();
}
