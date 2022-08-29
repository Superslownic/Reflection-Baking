using System;
using System.Collections.Generic;

namespace Reflection.Baking
{
  public static class BakedTypePool
  {
    private static readonly Dictionary<Type, uint> _container= new Dictionary<Type, uint>();
    
    public static uint GetUID(Type type)
    {
      return _container.ContainsKey(type)
        ? _container[type]
        : Add(type);
    }

    private static uint Add(Type type)
    {
      uint id = (uint) _container.Count + 1;
      _container.Add(type, id);
      return id;
    }
  }
}