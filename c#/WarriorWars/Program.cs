using System;
using System.Collections.Generic;

namespace WarriorWars
{
    class Program
    {
        static void Main(string[] args)
        {
            // create the players for the game
            Warrior player = new Warrior("David");
            Warrior cpu = new Warrior("Goliath");
            List<Warrior> playerList = new List<Warrior>() { player, cpu };
            int playerTurn = 0;
            int playerAction;
            int cpuAction;

            Console.WriteLine("Welcome to the tournament!");
            Console.WriteLine("You are playing as David vs. Goliath (CPU)\n");

            do
            {
                DisplayHP(playerList);

                // player attack
                if (playerTurn == 0)
                {
                    playerAction = PlayerChoice(player, "offense");
                    cpuAction = CPUChoice(cpu, "defense");
                    PerformAction(player, cpu, playerAction, cpuAction);
                }

                //player defend
                else
                {
                    playerAction = PlayerChoice(player, "defense");
                    cpuAction = CPUChoice(cpu, "offense");
                    PerformAction(cpu, player, cpuAction, playerAction);
                }

                playerTurn = 1 - playerTurn; // change turns
            } while (!player.IsDead() && !cpu.IsDead());

            // display the winner
            DisplayHP(playerList);
            Warrior winner = player.IsDead() ? cpu : player;
            Console.WriteLine($"\n{winner.Name} won the fight!");
        }

        // ask the player what action they want to take
        // returns the attack value or defend value
        static int PlayerChoice(Warrior player, string action)
        {
            string choice;

            // continuously ask for a valid offense option
            if (string.Equals(action, "offense"))
            {
                do
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("(A)ttack or (P)owerful Strike?");
                    Console.ResetColor();
                    choice = Console.ReadLine().ToUpper();
                    Console.WriteLine();

                    if (choice == "A")
                        return player.Attack();
                    else if (choice == "P")
                        return player.PowerfulStrike();
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Invalid option\n");
                        Console.ResetColor();
                    }
                } while (true);
            }

            // continuously ask for a valid defense option
            else if (string.Equals(action, "defense"))
            {
                do
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("(D)efend or (C)ounter?");
                    Console.ResetColor();
                    choice = Console.ReadLine().ToUpper();
                    Console.WriteLine();

                    if (choice == "D")
                        return player.Defend();
                    else if (choice == "C")
                        return player.Counter();
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Invalid option\n");
                        Console.ResetColor();
                    }
                } while (true);
            }
            else
                return -1;
        }

        // randomly select an action for the cpu to take
        // returns the attack value or defend value
        static int CPUChoice(Warrior cpu, string action)
        {
            int randNum = new Random().Next(0, 2);

            if (string.Equals(action, "offense"))
                return (randNum == 0) ? cpu.Attack() : cpu.PowerfulStrike();
            else if (string.Equals(action, "defense"))
                return (randNum == 0) ? cpu.Defend() : cpu.Counter();
             else
                return -1;
        }

        // calculate the amount of damage taken
        // p1 is the attacker, p2 is the defender
        static void PerformAction(Warrior p1, Warrior p2, int p1Action ,int p2Action)
        {
            int damage = 0;

            // successful counter
            if (String.Equals(p1.Action, "powerful strike")
                       && String.Equals(p2.Action, "counter"))
            {
                p1.HP -= p1Action;
                Console.WriteLine($"{p1.Name} attempted a powerful strike, " +
                                  $"but {p2.Name} countered!");
                Console.WriteLine($"{p1.Name} inflicted {p1Action} damage to himself");
                return;
            }

            // successful powerful strike
            else if(String.Equals(p1.Action, "powerful strike")
                       && String.Equals(p2.Action, "defend"))
            {
                damage = p1Action - p2Action;
                p2.HP -= damage;
                Console.WriteLine($"{p1.Name} performs a powerful strike!");
            }

            // successful attack, failed counter
            // 3 damage penalty for failed counter
            else if (String.Equals(p1.Action, "attack")
                       && String.Equals(p2.Action, "counter"))
            {
                damage = p1Action - p2Action - 3;
                p2.HP -= damage;
                Console.WriteLine($"{p2.Name} failed to counter");
            }

            // successful defend
            else if (String.Equals(p1.Action, "attack")
                       && String.Equals(p2.Action, "defend"))
            {
                damage = p1Action - p2Action;
                p2.HP -= damage;
                Console.WriteLine($"{p2.Name} defends");
            }
            else {}

            Console.WriteLine($"{p1.Name} attacks {p2.Name} for {damage} damage");
            return;
        }

        // show the HP of both players
        static void DisplayHP(List<Warrior> playerList)
        {
            foreach (Warrior player in playerList)
                Console.WriteLine($"{player.Name}: {player.HP} HP");
        }
    }
}
