using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;
using System.IO;


namespace Bank
{
    class Program
    {

        static void ChangeTextColor(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
            return;
        }

        // creates an XML document to keep track of bank users
        static void CreateXML()
        {
            XDocument xmlDoc = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("XML Tree For Bank Members"),
                new XElement("Members")
            );
            xmlDoc.Save("members.xml");
            return;
        }


        // adds a new member to the XML
        static void Register()
        {
            string username, password;
            XDocument xmlDoc;

            // continuously ask the user for a username until their
            // input is unique
            while (true)
            {
                Console.WriteLine("Create a username.");
                username = Console.ReadLine();

                // go through the XML and grab the elements with the same username
                xmlDoc = XDocument.Load("members.xml");
                IEnumerable<string> usernames =
                    from member in xmlDoc.Descendants("Member")
                    where (string)member.Element("Username").Value == username
                    select member.Element("Username").Value;

                // if there are no members with that username, create a new member in the XML
                if (usernames.FirstOrDefault() == null)
                {
                    Console.WriteLine("Create a password.");
                    password = Console.ReadLine();

                    xmlDoc.Element("Members").Add(
                    new XElement("Member",
                         new XElement("Username", username),
                         new XElement("Password", password),
                         new XElement("Balance", 0)
                    ));
                    xmlDoc.Save("members.xml");

                    ChangeTextColor("Successfully created account!", ConsoleColor.DarkGreen);
                    Console.WriteLine("Please login with your newly created username and password.");
                    return;
                }

                else
                {
                    ChangeTextColor("That username is taken. Try again.", ConsoleColor.Red);
                    continue;
                }
            } // END while
        } // END Register()


        // given the username and password, returns the account balance
        static string Login(string username, string password)
        {
            // go through the XML and grab the elements with the corresponding username and password
            XDocument xmlDoc = XDocument.Load("members.xml");
            IEnumerable<string> balances =
                from member in xmlDoc.Descendants("Member")
                where (string)member.Element("Username").Value == username
            && (string)member.Element("Password").Value == password
                select member.Element("Balance").Value;

            // if we found a member with those credentials, return their account balance
            if (balances.FirstOrDefault() != null)
            {
                return balances.FirstOrDefault();
            }

            // else, that member does not exist
            else
            {
                ChangeTextColor("That username and password do not exist", ConsoleColor.Red);
                return null;
            }
        }


        // given the username, update the XML to reflect the member's new account balance
        static void UpdateBalance(string username, double balance)
        {
            // go through the XML and grab the element with the given username
            // and update their account balance
            XDocument xmlDoc = XDocument.Load("members.xml");
            xmlDoc.Descendants("Member")
                  .Where(x => x.Element("Username").Value == username)
                  .FirstOrDefault()
                  .SetElementValue("Balance", balance);
            xmlDoc.Save("members.xml");
            return;
        }


        // ask the user to input an amount for depositing or withdrawing
        static double AskForAmount(string method)
        {
            double amt;

            // continuously ask the user to input a valid number
            while (true)
            {
                Console.WriteLine("Enter a valid amount you would like to {0}.", method);
                if (!double.TryParse(Console.ReadLine(), out amt))
                {
                    ChangeTextColor("Invalid input.\n", ConsoleColor.Red);
                    continue;
                }

                // return the input rounded down two decimal places
                return Math.Floor(amt * 100) / 100;
            }

        }


        // deposits the given amount into the balance
        static double Deposit(string username, double balance, double amt)
        {
            balance += amt;
            UpdateBalance(username, balance);
            ChangeTextColor(string.Format("Successfully deposited ${0} to your account.", amt), ConsoleColor.DarkGreen);
            return balance;
        }


        // withdraws the given amount from the balance
        static double Withdraw(string username, double balance, double amt)
        {
            balance -= amt;
            UpdateBalance(username, balance);
            ChangeTextColor(string.Format("Successfully withdrew ${0} to your account.", amt), ConsoleColor.DarkGreen);
            return balance;
        }


        // prints the list of transactions
        static void PrintHistory(List<string> lst)
        {
            foreach (string line in lst)
            {
                Console.WriteLine(line);
            }
        }


        static void Main(string[] args)
        {
            // main while loop
            // continuously run the program until the user decides to quit
            while (true)
            {
                string username, password, balanceStr = "";
                List<string> history = new List<string>();
                double balance = 0;
                bool logout = false;

                ChangeTextColor("\nWelcome to the bank!", ConsoleColor.DarkCyan);

                // create the XML if it does not exist
                if (!File.Exists("members.xml"))
                {
                    CreateXML();
                }

                // continuously give the option to register multiple users,
                // continue with the rest of the program after successful login,
                // or quit the program entirely
                while (true)
                {
                    Console.WriteLine("\nWould you like to: 1) Register, 2) Login, 3) Quit?");
                    string option1 = Console.ReadLine();
                    switch (option1)
                    {
                        case "1":
                            Register();
                            continue;
                        case "2":
                            Console.WriteLine("Enter your username.");
                            username = Console.ReadLine();
                            Console.WriteLine("Enter your password.");
                            password = Console.ReadLine();

                            // check to see if the login credentials are valid
                            balanceStr = Login(username, password);
                            if (balanceStr == null)
                            {
                                continue;
                            }
                            break;
                        case "3":
                            Console.WriteLine("Have a nice day!");
                            return;
                        default:
                            ChangeTextColor("Invalid option.", ConsoleColor.Red);
                            continue;
                    }
                    break;
                }

                // convert the balance string into type double
                double.TryParse(balanceStr, out balance);

                // transaction while loop
                // continuously ask the user to make transactions until they quit
                while (true)
                {
                    Console.WriteLine("\nSelect an option. 1) Deposit, 2) Withdraw," +
                                      " 3) Check Balance, 4) Print History, 5) Logout, 6) Quit.");
                    string option2 = Console.ReadLine();

                    switch (option2)
                    {
                        case "1":
                            double deposit = AskForAmount("deposit");
                            balance = Deposit(username, balance, deposit);

                            // add to the transaction history
                            history.Add(string.Format("Deposited: ${0}", deposit));
                            break;
                        case "2":
                            double withdraw;

                            // continuously ask the user to withdraw an amount that they own
                            do
                            {
                                withdraw = AskForAmount("withdraw");
                                if(withdraw > balance)
                                {
                                    ChangeTextColor("Insufficient funds.\n", ConsoleColor.Red);
                                }
                            } while (withdraw > balance);
                            balance = Withdraw(username, balance, withdraw);
                            history.Add(string.Format("Withdrew: ${0}", withdraw));
                            break;
                        case "3":
                            Console.WriteLine("You currently have ${0} in your account.", balance);
                            history.Add(string.Format("Balance: ${0}", balance));
                            break;
                        case "4":
                            PrintHistory(history);
                            break;
                        case "5":
                            //Logout(username, balance);
                            ChangeTextColor("Successfully logged out.", ConsoleColor.DarkGreen);
                            logout = true;
                            break;
                        case "6":
                            Console.WriteLine("Have a nice day!");
                            return;
                        default:
                            ChangeTextColor("Please enter a valid option.", ConsoleColor.Red);
                            continue;
                    } // END switch

                    if (logout)
                    {
                        break;
                    }

                } // END transaction while
            } // END main while
        } // END function Main
    } // END class Program
} // END namespace Bank