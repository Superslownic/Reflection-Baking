using System.Collections.Generic;
using System.Reflection;

namespace ReflectionBaking
{
  public static class AssembliesPool
  {
    private static readonly Dictionary<string, Assembly> _assemblies = new Dictionary<string, Assembly>();

    public static Assembly GetOrLoadAssembly(string name)
    {
      if (_assemblies.ContainsKey(name))
        return _assemblies[name];

      Assembly assembly = Assembly.Load(name);
      _assemblies.Add(name, assembly);

      return assembly;
    }
  }
}