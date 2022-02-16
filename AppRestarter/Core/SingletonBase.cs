namespace AppRestarter.Core
{
    public abstract class SingletonBase<TInterface, TConcrete> : ISingletonBase<TInterface, TConcrete> where TConcrete : class, TInterface, new()
    {
        private static TInterface _instance;
        public static TInterface GetInstance() => _instance ??= new TConcrete();
    }
}
