namespace Hangman_WinForms
{
    partial class Hangman
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox = new PictureBox();
            labelGuessWordPrompt = new Label();
            labelGuessedWord = new Label();
            textBoxGuessLetter = new TextBox();
            labelGuessLetter = new Label();
            labelGuessedLettersTitle = new Label();
            labelGuessedLettersList = new Label();
            buttonGuess = new Button();
            buttonReset = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(45, 32);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(350, 500);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // labelGuessWordPrompt
            // 
            labelGuessWordPrompt.AutoSize = true;
            labelGuessWordPrompt.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelGuessWordPrompt.Location = new Point(440, 57);
            labelGuessWordPrompt.Name = "labelGuessWordPrompt";
            labelGuessWordPrompt.Size = new Size(178, 24);
            labelGuessWordPrompt.TabIndex = 1;
            labelGuessWordPrompt.Text = "Guess the animal:";
            // 
            // labelGuessedWord
            // 
            labelGuessedWord.AutoSize = true;
            labelGuessedWord.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelGuessedWord.Location = new Point(440, 132);
            labelGuessedWord.Name = "labelGuessedWord";
            labelGuessedWord.Size = new Size(59, 32);
            labelGuessedWord.TabIndex = 2;
            labelGuessedWord.Text = "___";
            // 
            // textBoxGuessLetter
            // 
            textBoxGuessLetter.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxGuessLetter.Location = new Point(607, 217);
            textBoxGuessLetter.MaxLength = 1;
            textBoxGuessLetter.Name = "textBoxGuessLetter";
            textBoxGuessLetter.Size = new Size(46, 32);
            textBoxGuessLetter.TabIndex = 3;
            // 
            // labelGuessLetter
            // 
            labelGuessLetter.AutoSize = true;
            labelGuessLetter.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelGuessLetter.Location = new Point(440, 225);
            labelGuessLetter.Name = "labelGuessLetter";
            labelGuessLetter.Size = new Size(148, 24);
            labelGuessLetter.TabIndex = 4;
            labelGuessLetter.Text = "Guess a letter:";
            // 
            // labelGuessedLettersTitle
            // 
            labelGuessedLettersTitle.AutoSize = true;
            labelGuessedLettersTitle.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelGuessedLettersTitle.Location = new Point(440, 304);
            labelGuessedLettersTitle.Name = "labelGuessedLettersTitle";
            labelGuessedLettersTitle.Size = new Size(164, 24);
            labelGuessedLettersTitle.TabIndex = 5;
            labelGuessedLettersTitle.Text = "Guessed letters:";
            // 
            // labelGuessedLettersList
            // 
            labelGuessedLettersList.AutoSize = true;
            labelGuessedLettersList.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelGuessedLettersList.Location = new Point(440, 385);
            labelGuessedLettersList.Name = "labelGuessedLettersList";
            labelGuessedLettersList.Size = new Size(22, 24);
            labelGuessedLettersList.TabIndex = 6;
            labelGuessedLettersList.Text = "_";
            // 
            // buttonGuess
            // 
            buttonGuess.BackColor = Color.RoyalBlue;
            buttonGuess.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGuess.Location = new Point(692, 217);
            buttonGuess.Name = "buttonGuess";
            buttonGuess.Size = new Size(82, 32);
            buttonGuess.TabIndex = 7;
            buttonGuess.Text = "Guess";
            buttonGuess.UseVisualStyleBackColor = false;
            buttonGuess.Click += LetterGuess;
            // 
            // buttonReset
            // 
            buttonReset.BackColor = Color.FromArgb(0, 192, 0);
            buttonReset.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonReset.Location = new Point(588, 469);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(89, 36);
            buttonReset.TabIndex = 8;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = false;
            buttonReset.Click += buttonReset_Click;
            // 
            // Hangman
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 565);
            Controls.Add(buttonReset);
            Controls.Add(buttonGuess);
            Controls.Add(labelGuessedLettersList);
            Controls.Add(labelGuessedLettersTitle);
            Controls.Add(labelGuessLetter);
            Controls.Add(textBoxGuessLetter);
            Controls.Add(labelGuessedWord);
            Controls.Add(labelGuessWordPrompt);
            Controls.Add(pictureBox);
            MaximizeBox = false;
            Name = "Hangman";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hangman";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private Label labelGuessWordPrompt;
        private Label labelGuessedWord;
        private TextBox textBoxGuessLetter;
        private Label labelGuessLetter;
        private Label labelGuessedLettersTitle;
        private Label labelGuessedLettersList;
        private Button buttonGuess;
        private Button buttonReset;
    }
}
