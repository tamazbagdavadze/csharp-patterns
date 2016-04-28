class SingletonSimple
{
    private static SingletonSimple instance;

    private SingletonSimple()
    {

    }

    public static SingletonSimple getInstance()
    {
        if (instance == null)
        {
            instance = new SingletonSimple();
        }

        return instance;
    }
}

class SingletonThreadSafe
{
    private static object mutex = new object();
    private static volatile SingletonThreadSafe instance;

    private SingletonThreadSafe()
    {

    }

    public static SingletonThreadSafe getInstance()
    {
        if (instance == null)
        {
            lock (mutex)
            {
                if (instance == null)
                {
                    instance = new SingletonThreadSafe();
                }
            }
        }

        return instance;
    }
}

class SingletonThreadSafeLazy
{
    private static readonly SingletonThreadSafeLazy instance = new SingletonThreadSafeLazy();

    //force laziness, .net >= 4
    static SingletonThreadSafeLazy()
    {

    }

    private SingletonThreadSafeLazy()
    {

    }

    public static SingletonThreadSafeLazy Instance
    {
        get
        {
            return instance;
        }
    }
}

class SingletonThreadSafeFullyLazy
{
    private static class SingletonHolder
    {
        internal static readonly SingletonThreadSafeFullyLazy instance = new SingletonThreadSafeFullyLazy();
        //forces laziness
        static SingletonHolder()
        {

        }
    }

    private SingletonThreadSafeFullyLazy()
    {

    }

    public static SingletonThreadSafeFullyLazy Instance => SingletonHolder.instance;
}

// .net >= 4
/*
class SingletonThreadSafeFullyLazy2
{
    private static Lazy<SingletonThreadSafeFullyLazy2> LazyInstance = new Lazy<SingletonThreadSafeFullyLazy2>(() => new SingletonThreadSafeFullyLazy2(), true);

    private SingletonThreadSafeFullyLazy2()
    {

    }

    public static SingletonThreadSafeFullyLazy2 getInstance => LazyInstance.value;
}
*/