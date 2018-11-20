using System;
using System.Collections.Generic;

namespace InheritanceTut
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal tiger = new Animal("Tiger", "Rawr");
            Dog dog = new Dog("Grover", "Woof", "Grrr");
            Cat cat = new Cat("Cat", "Meow");

            // Polymorphism
            // Dog IS A Animal (b/c of inheritance)
            // Cat IS A Animal (b/c of inheritance)
            Animal a1 = tiger;
            Animal a2 = dog;
            Animal a3 = cat;

            // we can include Dog and Cat objects in our list
            // b/c they are both considered an Animal (polymorphism)
            List<Animal> animalList = new List<Animal>()
            {
                a1, a2, a3
            };

            // loop through our list of animals and check
            // what type of object it is
            foreach(Animal a in animalList)
            {
                // if the item in our list is of type Dog
                // create a tmp Dog object so we can call Dog MakeSound()
                if(a is Dog)
                {
                    Dog tmp = a as Dog;
                    tmp.MakeSound();
                }

                // if the item in our list is of type Cat
                // create a tmp Cat object so we can call Cat MakeSound()
                else if (a is Cat)
                {
                    Cat tmp = a as Cat;
                    tmp.MakeSound();
                }
                else
                {
                    a.MakeSound();
                }
            }

            // Animal HAS A AnimalIDInfo
            // Dog HAS A AnimalIDInfo
            tiger.SetAnimalIDInfo(12345, "Sally Smith");
            dog.SetAnimalIDInfo(67899, "Paul Brown");
            tiger.GetAnimalIDInfo();
            dog.GetAnimalIDInfo();
        }
    }
}
