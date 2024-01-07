using System;

public abstract class Pokemon
{
     public int HP { get; protected set; } 
     public int Attack { get; protected set; } 
     public int Defense { get; protected set; } 
     public int SpecialAtack { get; protected set; } 
     public int SpecialDefense { get; protected set; } 
     public int Speed { get; protected set; } 
     
     public abstract void Hit();
}

public class Slowpoke : Pokemon
{
    public Slowpoke()
    { 
        HP = 90;
        Attack = 65;
        Defense = 65;
        SpecialAtack = 40;
        SpecialDefense = 40;
        Speed = 15;   
    }
    
    sealed public override void Hit() => Console.WriteLine ("+Did nothing+");
    
    public void Sleep() => Console.WriteLine ("+Sleep+");
}

public class Pichu : Pokemon
{
    public Pichu()
    { 
        HP = 20;
        Attack = 40;
        Defense = 15;
        SpecialAtack = 35;
        SpecialDefense = 35;
        Speed = 60;   
    }
    
    public override void Hit() => Console.WriteLine ("Use +Weak lightning+");
}

public class Pikachu : Pichu
{
    public Pikachu()
    {
        HP += 15;    
        Attack += 15;
        Defense += 25;
        SpecialAtack += 15;
        SpecialDefense += 15;
        Speed += 30;
    }
    
    public override void Hit()
    {
        base.Hit();
        Console.WriteLine (" than use +Flash+");
    }
}

public class Raichu : Pikachu
{
    private const int SleepTime = 12;
    
    public Raichu()
    {
        HP += 25;
        Attack += 35;
        Defense += 15;
        SpecialAtack += 40;
        SpecialDefense += 30;
        Speed += 20;
    }
    
    sealed public override void Hit() => Console.WriteLine ("Use +Strong lightning+");
    
    public void SleepLong() => Console.WriteLine ($"+Sleep {SleepTime} hours+");
}

public class PokemonWorld
{
    public static void Main(string[] args)
    {
        Slowpoke slowpoke = new Slowpoke();
        
        Pichu pichu = new Pichu();
        Pikachu pikachu = new Pikachu();
        Raichu raichu = new Raichu();
        
        Console.WriteLine($"-{typeof(Slowpoke).Name}: ");
        slowpoke.Hit();
        slowpoke.Sleep();
        
        Console.WriteLine($"\n-{typeof(Pichu).Name}: ");
        pichu.Hit();
        Console.WriteLine($"\n-{typeof(Pikachu).Name}: ");
        pikachu.Hit();
        Console.WriteLine($"\n-{typeof(Raichu).Name}: ");
        raichu.Hit();
        raichu.SleepLong();
    }
}