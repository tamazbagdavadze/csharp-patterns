
class Client2
{
    void foo()
    {
        Creator creator = null;
        Product product = null;
        
        creator = new ConcreteCreator();
        product = creator.FactoryMethod();
        
        creator.AnOperation();
    }
}

abstract class Creator
{
    Product product;
    public abstract Product FactoryMethod();
    
    public void AnOperation()
    {
        product = FactoryMethod();
    }
}

abstract class Product
{
    
}

class ConcreteCreator : Creator
{
    public override Product FactoryMethod()
    {
        return new ConcreteProduct();
    }
}

class ConcreteProduct : Product
{
    
}