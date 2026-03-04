using System;
using Humanity;
namespace Humanity 
{

public abstract class Human : IHoliday
{
    public string name;
    public int age;
    public Random random = new Random();

    public Human()
    {
        string[] names = { "Sasha", "Vasea", "Alex", "Valea", "Jenea" };
        name = names[random.Next(0, names.Length)];
        age = random.Next(6, 99);
    }

    public Human(string a, int b)
    {
        name = a;
        age = b;
    }

    public virtual void Print()
    {
        Console.WriteLine($"My name is {this.name}");
        Console.WriteLine($"My age is {this.age}");
       
    }
    
    public abstract void SayHi();
    
    public virtual void beerDay()
    {
        name = "?";
        
    }
    
    
}
}