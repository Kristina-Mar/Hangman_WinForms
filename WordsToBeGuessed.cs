using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_WinForms
{
    internal class WordsToBeGuessed
    {
        public string Category = string.Empty;
        private List<string> animals = new List<string> { "ARMADILLO", "ORANGUTAN", "ELEPHANT", "CROCODILE", "PLATYPUS", "BUTTERFLY", "GIRAFFE", "ANTEATER", "PENGUIN", "ANGLERFISH", "SEAHORSE", "CHEETAH", "MOSQUITO", "ALPACA", "CHICKEN", "BUFFALO", "PEACOCK", "PELICAN" };
        private List<string> countries = new List<string> { "MONTENEGRO", "TAJIKISTAN", "PARAGUAY", "BULGARIA", "INDONESIA", "LITHUANIA", "ARGENTINA", "MONGOLIA", "AZERBAIJAN", "SINGAPORE", "BAHRAIN", "LESOTHO", "MOZAMBIQUE", "TANZANIA", "ETHIOPIA", "BOTSWANA", "GUATEMALA" };
        private List<string> fruitNVeg = new List<string> { "BROCCOLI", "CAULIFLOWER", "ZUCCHINI", "WATERMELON", "RASPBERRY", "LYCHEE", "GRAPEFRUIT", "PARSNIP", "ARTICHOKE", "BEETROOT", "SPINACH", "NECTARINE", "WATERCRESS", "BLACKCURRANT", "PASSIONFRUIT", "JACKFRUIT" };
        public string ChosenWord = string.Empty;
        private Random randomNumberGenerator = new Random();
        public void PickAWord()
        {
            List<List<string>> allWords = new List<List<string>> { animals, countries, fruitNVeg };
            int listNumber = randomNumberGenerator.Next(allWords.Count);
            int wordNumber = randomNumberGenerator.Next(allWords[listNumber].Count);
            ChosenWord = allWords[listNumber][wordNumber];
            switch (listNumber)
            {
                case 0:
                    Category = "animal";
                    break;
                case 1:
                    Category = "country";
                    break;
                case 2:
                    Category = "fruit or vegetable";
                    break;
                default:
                    break;
            }
        }
    }
}
