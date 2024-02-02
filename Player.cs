using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hangman_WinForms
{
    internal class Player
    {
        public int MaxNumberOfWrongGuesses = 8;
        public int NumberOfWrongGuesses = 0;
        public string GuessedLettersString = string.Empty;
        public char[] GuessedLetters = { };
        public char GuessedLetter = '_';
        public bool IsAlive()
        {
            if (NumberOfWrongGuesses < MaxNumberOfWrongGuesses)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
