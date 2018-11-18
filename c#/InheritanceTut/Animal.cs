using System;

namespace InheritanceTut
{
    public class Animal
    {
        private string name;
        private string sound; 
        protected AnimalIDInfo animalIDInfo = new AnimalIDInfo();

        public Animal(string name, string sound)
        {
            Name = name;
            Sound = sound;
        }

        // calls the above constructor with the given arguments
        public Animal() : this("No name", "No sound"){ }

        public Animal(string name) : this(name, "No sound"){ }

        // use keyword 'virtual' to allow subclasses to override this method
        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound}");
        }

        public void SetAnimalIDInfo(int idNum, string owner)
        {
            animalIDInfo.IDNum = idNum;
            animalIDInfo.Owner = owner;
        }

        public void GetAnimalIDInfo()
        {
            Console.WriteLine($"{Name} has the ID of {animalIDInfo.IDNum} " +
                              $"and is owned by {animalIDInfo.Owner}");
        }

        public string Name
        {
            get { return name; }
            set
            {
                if(value.Length < 10)
                {
                    name = "No name";
                }
                name = value;
            }
        }

        public string Sound
        {
            get { return sound; }
            set
            {
                if (value.Length < 10)
                {
                    sound = "No sound";
                }
                sound = value;
            }
        }
    }
}
