using System.Reflection;
using System.Runtime.Loader;

namespace SampleHook;

public class HooksAssemblyLoadContext // : AssemblyLoadContext
{
    //private readonly AssemblyDependencyResolver _resolver;

    //public HooksAssemblyLoadContext()
    //{
    //    _resolver = new AssemblyDependencyResolver(Assembly.GetExecutingAssembly().Location);
    //}

    //protected override Assembly? Load(AssemblyName assemblyName)
    //{
    //    var assembly = _resolver.ResolveAssemblyToPath(assemblyName);

    //    if (assembly != null)
    //    {
    //        return LoadFromAssemblyPath(assembly);
    //    }
    //    return null;
    //}
}
