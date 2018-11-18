using System;

namespace InheritanceTut
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal whiskers = new Animal()
            {
                Name = "Whiskers",
                Sound = "Meow"
            };

            Dog grover = new Dog()
            {
                Name = "Grover",
                Sound = "Woof",
                Sound2 = "Grrr"
            };

            whiskers.MakeSound();
            grover.MakeSound();

            // Polymorphism
            // Dog IS A Animal
            Animal buddy = new Dog()
            {
                Name = "Buddy",
                Sound = "Pant",
                Sound2 = "Yip"
            };

            // calls the Dog MakeSound method instead of the one in Animal
            // b/c we used the 'virtual' and 'override' keyword in
            // the Animal method and Dog method respectively
            buddy.MakeSound();

            // Animal HAS A AnimalIDInfo
            // Dog HAS A AnimalIDInfo
            whiskers.SetAnimalIDInfo(12345, "Sally Smith");
            grover.SetAnimalIDInfo(67899, "Paul Brown");
            whiskers.GetAnimalIDInfo();
            grover.GetAnimalIDInfo();
        }
    }
}
