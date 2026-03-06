public abstract class Human : IHoliday
{
    string name;
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
    
class Woman : Human
    {
        
        float beauty;
        byte bitchness;
        
        
        public Woman() : base()
        {
            beauty = (float)random.Next(0, 1);
            bitchness = (byte)random.Next(0, 10);
            
        }
        
        public Woman(string a, int b, byte c) : base(a, b)
        {
            beauty = (float)random.Next(0, 1);
            bitchness = c;
            
        }
        
        // $"{a = (b>c)? true:false}"
        
        public override void Print()
        {
            Console.WriteLine($"Hello im a woman");
            base.Print();
            Console.WriteLine($"beauty {this.beauty}");
            Console.WriteLine($"bitchness {this.bitchness}");
            Console.WriteLine();
            Console.WriteLine();
            
        }
    
     public void makeUp ()
     {
         beauty = 1f;
         Console.WriteLine("Ola-la, Im prity now...");
         
     }
     
     public override void SayHi() 
    {
        
        if (bitchness< 7)
        Console.WriteLine("Hi hi hi!");
        else
        Console.WriteLine("F*ck");
    }
    
    public override void beerDay() 
    {
    
        beauty /= 2;
        bitchness = (byte)10;
        
    }
    
    
}
