using System;
namespace InheritanceTut
{
    // Dog inherits from Animal
    // C# does NOT support multiple inheritance
    // i.e. Can't make a man dog by doing - Dog : Animal, Person
    public class Dog : Animal
    {
        // provide a default value
        public string Sound2 { get; set; } = "No sound2";

        // use keyword 'base' to call the super class, Animal, constructor
        // also initialize the Sound2 property
        public Dog(string name, 
                   string sound = "No sound", 
                   string sound2 = "No sound 2")
            :base(name, sound)
        {
            Sound2 = sound2;
        }

        // use the 'override' keyword to override the super class method
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound} and {Sound2}.");
        }
    }
}
