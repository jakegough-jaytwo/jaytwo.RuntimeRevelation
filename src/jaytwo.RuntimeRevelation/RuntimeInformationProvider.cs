namespace jaytwo.RuntimeRevelation;

internal class RuntimeInformationProvider : IRuntimeInformationProvider
{
    public Architecture GetProcessArchitecture()
    {
        switch (System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture)
        {
            case System.Runtime.InteropServices.Architecture.X86:
                return Architecture.X86;
            case System.Runtime.InteropServices.Architecture.X64:
                return Architecture.X64;
            case System.Runtime.InteropServices.Architecture.Arm:
                return Architecture.ARM;
            case System.Runtime.InteropServices.Architecture.Arm64:
                return Architecture.ARM64;
            default:
                return Architecture.Unknown;
        }
    }

    public OSPlatform GetOSPlatform()
    {
        if (System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(System.Runtime.InteropServices.OSPlatform.Linux))
        {
            return OSPlatform.Linux;
        }
        else if (System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(System.Runtime.InteropServices.OSPlatform.Windows))
        {
            return OSPlatform.Windows;
        }
        else if (System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(System.Runtime.InteropServices.OSPlatform.OSX))
        {
            return OSPlatform.OSX;
        }
        else
        {
            return OSPlatform.Unknown;
        }
    }
}
