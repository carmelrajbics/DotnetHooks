using SampleHook;
using System.Diagnostics;
using System.Reflection;

internal class StartupHook
{
    public static void Initialize()
    {
        AppDomain.CurrentDomain.ProcessExit += CurrentDomain_ProcessExit;
        Console.Clear();

        Console.WriteLine("Started from Hooks!!");

        int processorCount = Environment.ProcessorCount;
        string processorName = Process.GetCurrentProcess().ProcessorAffinity.ToString();

        // Print the number of CPU cores and the processor name.
        Console.WriteLine($"Number of CPU cores: {processorCount}");
        Console.WriteLine($"Processor name: {processorName}");

        //var loadContext = new HooksAssemblyLoadContext();
        //var assembly = loadContext.LoadFromAssemblyName(new AssemblyName("HookProxy"));
        //assembly.CreateInstance("HookProxy.MatrixCollector");
        // assembly.CreateInstance("HookProxy.LogRedirctor");

    }

    private static void CurrentDomain_ProcessExit(object? sender, EventArgs e)
    {
        Console.WriteLine("Shutdown from hook!");
    }
}
