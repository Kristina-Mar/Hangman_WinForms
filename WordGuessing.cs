using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_WinForms
{
    internal class WordGuessing
    {
        public char[] guessedWord;
        public char[] UncoveredGuessedWord;
        public string Category = string.Empty;
        public WordGuessing()
        {
            SetNewWord();
        }
        public void SetNewWord()
        {
            WordsToBeGuessed wordsToBeGuessed = new WordsToBeGuessed();
            wordsToBeGuessed.PickAWord();
            guessedWord = wordsToBeGuessed.ChosenWord.ToCharArray();
            UncoveredGuessedWord = new char[guessedWord.Length];
            for (int i = 0; i < guessedWord.Length; i++)
            // The program first shows the guessed word in underscores - the player knows the word length.
            {
                UncoveredGuessedWord[i] = '_';
            }
            Category = wordsToBeGuessed.Category;
        }
        public bool DoesWordIncludeGuessedLetter(char guessedLetter)
        {
            if (guessedWord.Contains(guessedLetter))
            {
                for (int i = 0; i < guessedWord.Length; i++)
                {
                    if (guessedWord[i] == guessedLetter) // Replaces the underscore with the correctly guessed letter.
                    {
                        UncoveredGuessedWord[i] = guessedLetter;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsWordGuessed() // Checks whether all the underscores have been replaced with correctly guessed letters.
        {
            if (UncoveredGuessedWord.Contains('_'))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
