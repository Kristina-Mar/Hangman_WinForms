using Microsoft.VisualBasic.Devices;
using System.Text.RegularExpressions;

namespace Hangman_WinForms
{
    public partial class Hangman : Form
    {
        Player player = new Player();
        WordGuessing wordGuessing = new WordGuessing();
        public Hangman()
        {
            InitializeComponent();
            labelGuessWordPrompt.Text = $"Guess the {wordGuessing.Category}:";
            labelGuessedWord.Text = String.Join(" ", wordGuessing.UncoveredGuessedWord);
            labelGuessedLettersList.Text = string.Empty;
        }
 
        public void DrawHangman()
        {
            player.NumberOfWrongGuesses++;
            switch (player.NumberOfWrongGuesses)
            {
                case (1):
                    pictureBox.Image = Properties.Resources.hangman2;
                    break;
                case (2):
                    pictureBox.Image = Properties.Resources.hangman3;
                    break;
                case (3):
                    pictureBox.Image = Properties.Resources.hangman4;
                    break;
                case (4):
                    pictureBox.Image = Properties.Resources.hangman5;
                    break;
                case (5):
                    pictureBox.Image = Properties.Resources.hangman6;
                    break;
                case (6):
                    pictureBox.Image = Properties.Resources.hangman7;
                    break;
                case (7):
                    pictureBox.Image = Properties.Resources.hangman8;
                    break;
                default:
                    break;
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            pictureBox.Image = Properties.Resources.hangman1;
            player.NumberOfWrongGuesses = 0;
            Array.Clear(wordGuessing.guessedWord);
            Array.Clear(wordGuessing.UncoveredGuessedWord);
            wordGuessing.SetNewWord();
            labelGuessWordPrompt.Text = $"Guess the {wordGuessing.Category}:";
            labelGuessedWord.Text = String.Join(" ", wordGuessing.UncoveredGuessedWord);
            player.GuessedLettersString = string.Empty;
            Array.Clear(player.GuessedLetters);
            labelGuessedLettersList.Text = string.Empty;
            panelAllLetterButtons.Enabled = true;
            foreach (Button b in panelAllLetterButtons.Controls)
            {
                b.Enabled = true;
                b.BackColor = Color.White;
            }
        }
        private void DidIWin(bool didIWin)
        {
            string boxText = string.Empty;
            string boxCaption = string.Empty;
            if (didIWin)
            {
                boxText = "You win! Would you like to play again?";
                boxCaption = "Congratulations";
            }
            else
            {
                boxText = $"Game over. The word was {String.Join("", wordGuessing.guessedWord)}. Would you like to try again ? ";
                boxCaption = "Game over";
            }
            DialogResult playAgain = MessageBox.Show(boxText, boxCaption, MessageBoxButtons.YesNo);
            if (playAgain == DialogResult.Yes)
            {
                buttonReset.PerformClick();
            }
        }

        private void GuessLetter(object sender, EventArgs e)
        {
            ((Button)sender).Enabled = false;
            player.GuessedLetters = player.GuessedLettersString.ToCharArray();
            player.GuessedLetter = '_';
            player.GuessedLetter = ((Button)sender).Text.First();
            player.GuessedLettersString += player.GuessedLetter;
            player.GuessedLetters = player.GuessedLettersString.ToCharArray();
            labelGuessedLettersList.Text = String.Join(", ", player.GuessedLetters); // Writes out the letters the player has already guessed.
            if (wordGuessing.DoesWordIncludeGuessedLetter(player.GuessedLetter))
            {
                labelGuessedWord.Text = String.Join(" ", wordGuessing.UncoveredGuessedWord);
                ((Button)sender).BackColor = Color.Green;
                if (wordGuessing.IsWordGuessed())
                {
                    DidIWin(true);
                }
            }
            else
            {
                ((Button)sender).BackColor = Color.Red;
                DrawHangman();
                if (!player.IsAlive())
                {
                    DidIWin(false);
                }
            }
        }
    }
}
