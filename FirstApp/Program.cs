using System;

class MainClass
{
    public static void Main(string[] args)
    {
    }
   
    
}
class Record<T1, T2> 
{
    public T1 id;
    public T2 value;
    public DateTime Date;
}
class Car<TPart, TEngine>
    where TEngine:Engine
{
    public TEngine engine;
    public void ChangePart<TPart>(TPart NewPart) where TPart:Part
        {
        }
}
class Engine { }
class Part { }
class ElectricEngine: Engine { }
class GasEngine: Engine { }
class Wheel: Part { }
class Battery: Part { }
class Differential: Part { }
