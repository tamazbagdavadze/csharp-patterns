
using System;

class Client
{
    private AbstractWater water;
    private AbstractBottle bottle;
    
    public Client(AbstractFactory factory)
    {
        water = factory.CreateWater();
        bottle = factory.CreateBottle();
    }
    
    public void run ()
    {
        bottle.interact(water);
    }
}

abstract class AbstractWater
{

}

abstract class AbstractBottle
{
    public abstract void interact(AbstractWater water);
}

abstract class AbstractFactory
{
    public abstract AbstractWater CreateWater();
    public abstract AbstractBottle CreateBottle();
}


class CocaColaWater : AbstractWater
{
    
}

class PepsiWater : AbstractWater
{
    
}

class CocaColaBottle : AbstractBottle
{
    public override void interact(AbstractWater water)
    {
        throw new NotImplementedException();
    }
}

class PepsiBottle : AbstractBottle
{
    public override void interact(AbstractWater water)
    {
        throw new NotImplementedException();
    }
}


class CocaColaFactory : AbstractFactory
{
    public override AbstractBottle CreateBottle()
    {
        return new CocaColaBottle();
    }

    public override AbstractWater CreateWater()
    {
         return new CocaColaWater();
    }
}

class PepsiFactory : AbstractFactory
{
    public override AbstractBottle CreateBottle()
    {
        return new PepsiBottle();
    }

    public override AbstractWater CreateWater()
    {
         return new PepsiWater();
    }
}