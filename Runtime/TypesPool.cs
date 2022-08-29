using System;
using System.Collections.Generic;
using System.Reflection;

namespace Reflection.Baking
{
  public static class TypesPool
  {
    private static readonly Dictionary<string, Type> _types = new Dictionary<string, Type>();

    public static Type GetOrLoadType(string assemblyName, string typeName)
    {
      if (_types.ContainsKey(typeName))
        return _types[typeName];

      Assembly assembly = AssembliesPool.GetOrLoadAssembly(assemblyName);
      Type type = assembly.GetType(typeName);

      _types.Add(typeName, type);
      return type;
    }
  }
}