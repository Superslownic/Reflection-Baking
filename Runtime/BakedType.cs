namespace ReflectionBaking
{
  public static class BakedType<T>
  {
    public static readonly uint UID = BakedTypePool.GetUID(typeof(T));
  }
}