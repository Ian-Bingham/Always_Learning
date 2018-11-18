using System;
namespace WarriorWars
{
    public class Warrior
    {
        public string Name { get; set; }
        public int HP { get; set; } = 50;
        public int MinDmg { get; set; } = 5;
        public int MaxDmg { get; set; } = 10;
        public int MinDef { get; set; } = 1;
        public int MaxDef { get; set; } = 5;
        public string Action { get; set; }

        public Warrior(string name)
        {
            Name = name;
        }

        public int Attack()
        {
            Action = "attack";
            return new Random().Next(MinDmg + 1, MaxDmg + 1);
        }

        public int PowerfulStrike()
        {
            Action = "powerful strike";
            return new Random().Next(MinDmg * 3 + 1, MaxDmg * 2 + 1);
        }

        public int Defend()
        {
            Action = "defend";
            return new Random().Next(MinDef, MaxDef + 1);
        }

        public int Counter()
        {
            Action = "counter";
            return 1;
        }

        public bool IsDead()
        {
            return HP <= 0;
        }
    }
}
