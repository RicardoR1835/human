using System;

namespace human
{
    class Human
{
    // Fields for Human
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    public int health;
     
    // add a public "getter" property to access health
    public string Health {
        get {
            return $"Yo, your health be {health}";
        }
        }
     
    // Add a constructor that takes a value to set Name, and set the remaining fields to default values
    public Human(string name){
        Name = name;
        Strength = 3;
        Intelligence = 3;
        Dexterity = 3;
        health = 100;
    }
     
    // Add a constructor to assign custom values to all fields
    public Human(string name, int power, int smarts, int dex, int level){
        Name = name;
        Strength = power;
        Intelligence = smarts;
        Dexterity = dex;
        health = level;
    }
     
    // Build Attack method
    public virtual int Attack(Human target)
    {
        int dmg = Strength * 3;
        target.health -= dmg;
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        return target.health;
    }
}
    class Wizard : Human
    {
        public Wizard(string name) : base(name)
        {
            Name = name;
            Intelligence = 25;
            health = 50;
        }

        public override int Attack(Human target)
        {
            int dmg = Intelligence * 5;
            target.health -= dmg;
            health += dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.health;
        }

        public int Heal(Human target)
        {
            target.health += 10;
            Console.WriteLine($"{Name} Healed {target.Name}'s health to {target.health}!");
            return target.health;
        }

        }

    class Ninja : Human
    {
        public Ninja(string name) : base(name)
        {
            Name = name;
            Dexterity = 175;
        }

        public override int Attack(Human target)
        {
            int dmg = Dexterity * 5;
            Random rand = new Random();
            int x = rand.Next(6);
            if(x == 3){
                dmg+= 10;
                target.health -= dmg;
                Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
                return target.health;
            } else {
                target.health -= dmg;
                Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
                return target.health;
            }
        }
        public int Steal(Human target)
        {
            Console.WriteLine(health);
            Console.WriteLine(target.health);
            target.health -= 5;
            health += 5;
            Console.WriteLine(target.health);
            Console.WriteLine(health);
            Console.WriteLine($"{Name} took 5 health from {target.Name} !");
            return target.health;
        }
    }

    class Samuri : Human
    {
        public Samuri(string name) : base(name)
        {
            health = 200;
        }
        public override int Attack(Human target)
        {
            int dmg = Strength * 3;
            if(target.health <= 50){
                target.health = 0;
                Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
                return target.health;
            } else{
                target.health -= dmg;
                Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
                return target.health;
            }
        }

        public int Meditate()
        {
            Console.WriteLine(health);
            int fullHealth = 200 - health;
            if(fullHealth < 0){
                Console.WriteLine($"{Name} is already at full health!");
                return health;
            } else {
                health += fullHealth;
                Console.WriteLine($"{Name} Healed to {health} for full health!");
            }
            return health;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Human Ricky = new Human("Ricky");
            Human Jonte = new Human("jonte", 20, 30, 40, 50);
            // Console.WriteLine(Ricky.Health);
            // Console.WriteLine(Jonte.Attack(Ricky));
            Wizard Novi = new Wizard("Novi");
            // Console.WriteLine(Novi.Health);
            // Console.WriteLine(Novi.Attack(Ricky));
            // Console.WriteLine(Novi.Health);
            Ninja Dave = new Ninja("dave");
            // Console.WriteLine(Dave.Health);
            // Console.WriteLine(Dave.Dexterity);
            Samuri Juma = new Samuri("Juma");
            // Console.WriteLine(Juma.Attack(Novi));
            // Console.WriteLine(Novi.Health);
            // Console.WriteLine(Novi.Heal(Ricky));
            // Console.WriteLine(Dave.Attack(Juma));
            Console.WriteLine(Dave.Steal(Juma));


        }
    }
}
