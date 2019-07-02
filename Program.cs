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
    private int health;
     
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
    public int Attack(Human target)
    {
        target.health -= (5 * Strength);
        return target.health;
    }
}
    class Program
    {
        static void Main(string[] args)
        {
            Human Ricky = new Human("Ricky");
            Human Jonte = new Human("jonte", 20, 30, 40, 50);
            Console.WriteLine(Ricky.Health);
            Console.WriteLine(Jonte.Attack(Ricky));
        }
    }
}
