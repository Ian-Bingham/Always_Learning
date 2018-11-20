using System;
namespace InheritanceTut
{
    public class Cat : Animal
    {
        public Cat(string name, string sound) :base(name, sound) 
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} is sleeping");
        }
    }
}
