using System;
using Humanity;
namespace Humanity
{
 public class Woman : Human
    {
        
       public float beauty;
        public byte bitchness;
        
        
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
}