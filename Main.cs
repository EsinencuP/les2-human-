using System;

class Program
{
    static void Main()
    {
        Human[] Party = new Human[6];
        for(int i = 0; i < Party.Length; i +=2)
        {
        Party[i] = new Man();
        Party[i+1] = new Woman();
        }
        
        for (int i=0; i < Party.Length; i++ )
        {
            Party[i].Print();
        }
        
        Man Bob = new Man();
        Human Siri = new Woman();
        Siri.Print();
        ((Woman)Siri).makeUp();
       /* 
        for (int i= 0; i < Party.Length; i++)
        if (Party[i] is Woman)
            ((Woman)Party[i]).makeUp();
            
            for (int i= 0; i < Party.Length; i++)
        if (Party[i] is Man)
            ((Man)Party[i]).drive();
            */
            
            for (int i= 0; i < Party.Length; i++)
                {
                    
                    Party[i].SayHi();
                    Party[i].beerDay();
                    Console.WriteLine("After Party");
                    Party[i].SayHi();
                }
            //
    }
}


