using System;
using System.Collections.Generic;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] word_list = { "apple", "television", "canada", "maple", "building", "kingdom", "jaguar" };
            Random randGen = new Random();
            String selectedWord = word_list[randGen.Next(0, 8)];
            char guess;
            int tries = 5;
            bool correctGuess = false;
            List<char> guessedList = new List<char>();
            List<char> blanksList = new List<char>();
            for (int i = 0; i < selectedWord.Length; i++)
            {
                blanksList.Add('*');
            }

            do
            {
                Console.Clear();
                correctGuess = false;
                Console.WriteLine(String.Join<char>("", blanksList));
                Console.WriteLine("Guessed: {0}", String.Join<char>(",", guessedList));
                Console.WriteLine("Tries: {0}", tries);
                Console.WriteLine("Guess a letter");
                guess = char.Parse(Console.ReadLine());
                guessedList.Add(guess);
                for (int i = 0; i < selectedWord.Length; i++)
                {
                    if (selectedWord[i] == guess)
                    {
                        blanksList[i] = guess;
                        correctGuess = true;
                    }

                }

                if(!correctGuess)
                {
                    tries--;
                }
            } while (blanksList.Contains('*') && tries > 0);

            if(tries > 0)
            {
                Console.WriteLine("You got it!!!");
            }
            else
            {
                Console.WriteLine("You lose :(. The word was \"{0}\"", selectedWord);
            }
        }
    }
}
