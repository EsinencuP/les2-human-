using System;
using Popularity;
namespace Popularity
{


public class Man : Human
{
    public byte Iq;
    public double money;
    public bool orientation;

    public Man() : base()
    {
        Iq = (byte)random.Next(70, 110);
        money = (double)(random.Next(0, 100000) / 10);
        orientation = (random.Next(0, 10) < 5) ? true : false;
    }

    public Man(string x, int y, bool z) : base(x, y)
    {
        Iq = (byte)random.Next(70, 110);
        money = (double)(random.Next(0, 100000) / 10);
        orientation = z;
    }

    public override void Print()
    {
        Console.WriteLine("Hello!");
        base.Print();
        Console.WriteLine($"My IQ  - {this.Iq}");
        Console.WriteLine($"My balance {this.money}$");

        if (orientation == true)
        {
            Console.WriteLine("I am heterosex");
        }
        else
        {
            Console.WriteLine("I am homosex");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
    
    public void drive () 
    {
        if (money > 1000 )
            Console.WriteLine("Im driving a car");
            else
            Console.WriteLine("Im going by bus");
    }
    
    public override void SayHi() 
    {
        if (orientation)
        Console.WriteLine("What's up!");
        else
        Console.WriteLine("Hi!!!");
    }
    
    public override void beerDay() 
    {
        base.beerDay(); // name = "?"
        money /= 2;
        orientation =! orientation;
    }
    
    }
}