using System;

class MainClass
{
    public static void Main(string[] args)
    {
    }
   
    
}
class GasCar : Car<GasEngine>
{
    public override void ChangePart<TPart>(TPart NewPart)
    { 
    }
}
class ElectricCar : Car<ElectricEngine>
{
    public override void ChangePart<TPart>(TPart NewPart)
    {
    }
}
abstract class Car<TEngine>
    where TEngine:Engine
{
    public TEngine engine;
    abstract public void ChangePart<TPart>(TPart NewPart) where TPart : Part;
        
}
class Engine { }
class Part { }
class ElectricEngine: Engine { }
class GasEngine: Engine { }
class Wheel: Part { }
class Battery: Part { }
class Differential: Part { }
