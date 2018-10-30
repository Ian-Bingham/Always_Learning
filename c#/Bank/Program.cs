using System;
using System.Collections.Generic;

namespace Bank
{
    public class Member
    {
        //private string username, password;
        private float balance;
        private List<string> history;

        //public Member(string username, string password, float balance)
        //{
        //    this.username = username;
        //    this.password = password;
        //    this.balance = balance;
        //    this.history = new List<string>();
        //}
        public Member()
        {
            this.balance = 0f;
            this.history = new List<string>();
        }


        public void Deposit(float amt)
        {
            this.balance += amt;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Successfully deposited ${0} to your account.", amt);
            Console.ResetColor();
            string action = String.Format("Deposited: ${0}.", amt);
            this.history.Add(action);
        }


        public void Withdraw(float amt)
        {
            this.balance -= amt;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Successfully withdrew ${0} to your account.", amt);
            Console.ResetColor();
            string action = String.Format("Withdrew: ${0}.", amt);
            this.history.Add(action);

        }


        public void CheckBalance()
        {
            Console.WriteLine("You have ${0} in your account.", this.balance);
            string action = String.Format("Check Balance: ${0}.", this.balance);
            this.history.Add(action);
        }


        public void PrintHistory()
        {
            Console.WriteLine("Below is a list of your transactions during this session:");
            foreach (string action in this.history)
            {
                Console.WriteLine(action);
            }
        }

        public float getBalance()
        {
            return this.balance;
        }
    }

    // -------------------------------------------------------------------------------

    class Program
    {
        static float AskForAmount(float amt, string tyype)
        {
            //do
            //{
            //    Console.WriteLine("Enter a valid amount you would like to {0}.", tyype);
            //} while (!float.TryParse(Console.ReadLine(), out amt));
            //return amt;

            while (true)
            {
                Console.WriteLine("Enter a valid amount you would like to {0}.", tyype);
                if (!float.TryParse(Console.ReadLine(), out amt))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input.");
                    Console.ResetColor();
                    continue;
                }
                return amt;
            }

        }


        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the bank!");

            Member member = new Member();

            while (true)
            {
                Console.WriteLine("Select an option. 1) Deposit, 2) Withdraw," +
                                  " 3) Check Balance, 4) Print History, 5) Quit.");
                string option = Console.ReadLine();
                float amt = 0f;
                switch (option)
                {
                    case "1":
                        amt = AskForAmount(amt, "deposit");
                        member.Deposit(amt);
                        break;
                    case "2":
                        do
                        {
                            amt = AskForAmount(amt, "withdraw");
                        } while (amt > member.getBalance());
                        member.Withdraw(amt);
                        break;
                    case "3":
                        member.CheckBalance();
                        break;
                    case "4":
                        member.PrintHistory();
                        break;
                    case "5":
                        Console.WriteLine("Have a nice day!");
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter a valid option.");
                        Console.ResetColor();
                        continue;
                }
            }
        }
    }
}
