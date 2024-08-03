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
            labelGuessedLettersTitle = new Label();
            labelGuessedLettersList = new Label();
            buttonReset = new Button();
            buttonA = new Button();
            buttonJ = new Button();
            buttonS = new Button();
            buttonT = new Button();
            buttonK = new Button();
            buttonB = new Button();
            buttonU = new Button();
            buttonL = new Button();
            buttonC = new Button();
            buttonW = new Button();
            buttonM = new Button();
            buttonD = new Button();
            buttonX = new Button();
            buttonN = new Button();
            buttonE = new Button();
            buttonV = new Button();
            buttonO = new Button();
            buttonF = new Button();
            buttonY = new Button();
            buttonP = new Button();
            buttonG = new Button();
            buttonZ = new Button();
            buttonQ = new Button();
            buttonH = new Button();
            buttonR = new Button();
            buttonI = new Button();
            panelAllLetterButtons = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            panelAllLetterButtons.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Image = Properties.Resources.hangman1;
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
            labelGuessedWord.Location = new Point(440, 119);
            labelGuessedWord.Name = "labelGuessedWord";
            labelGuessedWord.Size = new Size(59, 32);
            labelGuessedWord.TabIndex = 2;
            labelGuessedWord.Text = "___";
            // 
            // labelGuessedLettersTitle
            // 
            labelGuessedLettersTitle.AutoSize = true;
            labelGuessedLettersTitle.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelGuessedLettersTitle.Location = new Point(440, 192);
            labelGuessedLettersTitle.Name = "labelGuessedLettersTitle";
            labelGuessedLettersTitle.Size = new Size(164, 24);
            labelGuessedLettersTitle.TabIndex = 5;
            labelGuessedLettersTitle.Text = "Guessed letters:";
            // 
            // labelGuessedLettersList
            // 
            labelGuessedLettersList.AutoSize = true;
            labelGuessedLettersList.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelGuessedLettersList.Location = new Point(440, 250);
            labelGuessedLettersList.Name = "labelGuessedLettersList";
            labelGuessedLettersList.Size = new Size(22, 24);
            labelGuessedLettersList.TabIndex = 6;
            labelGuessedLettersList.Text = "_";
            // 
            // buttonReset
            // 
            buttonReset.BackColor = Color.FromArgb(0, 192, 0);
            buttonReset.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonReset.Location = new Point(657, 542);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(116, 45);
            buttonReset.TabIndex = 8;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = false;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonA
            // 
            buttonA.BackgroundImageLayout = ImageLayout.Center;
            buttonA.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonA.Location = new Point(19, 19);
            buttonA.Name = "buttonA";
            buttonA.Size = new Size(55, 55);
            buttonA.TabIndex = 9;
            buttonA.Text = "A";
            buttonA.UseVisualStyleBackColor = true;
            buttonA.Click += GuessLetter;
            // 
            // buttonJ
            // 
            buttonJ.BackgroundImageLayout = ImageLayout.Center;
            buttonJ.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonJ.Location = new Point(49, 80);
            buttonJ.Name = "buttonJ";
            buttonJ.Size = new Size(55, 55);
            buttonJ.TabIndex = 10;
            buttonJ.Text = "J";
            buttonJ.UseVisualStyleBackColor = true;
            buttonJ.Click += GuessLetter;
            // 
            // buttonS
            // 
            buttonS.BackgroundImageLayout = ImageLayout.Center;
            buttonS.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonS.Location = new Point(81, 141);
            buttonS.Name = "buttonS";
            buttonS.Size = new Size(55, 55);
            buttonS.TabIndex = 11;
            buttonS.Text = "S";
            buttonS.UseVisualStyleBackColor = true;
            buttonS.Click += GuessLetter;
            // 
            // buttonT
            // 
            buttonT.BackgroundImageLayout = ImageLayout.Center;
            buttonT.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonT.Location = new Point(142, 141);
            buttonT.Name = "buttonT";
            buttonT.Size = new Size(55, 55);
            buttonT.TabIndex = 14;
            buttonT.Text = "T";
            buttonT.UseVisualStyleBackColor = true;
            buttonT.Click += GuessLetter;
            // 
            // buttonK
            // 
            buttonK.BackgroundImageLayout = ImageLayout.Center;
            buttonK.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonK.Location = new Point(115, 80);
            buttonK.Name = "buttonK";
            buttonK.Size = new Size(55, 55);
            buttonK.TabIndex = 13;
            buttonK.Text = "K";
            buttonK.UseVisualStyleBackColor = true;
            buttonK.Click += GuessLetter;
            // 
            // buttonB
            // 
            buttonB.BackgroundImageLayout = ImageLayout.Center;
            buttonB.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonB.Location = new Point(80, 19);
            buttonB.Name = "buttonB";
            buttonB.Size = new Size(55, 55);
            buttonB.TabIndex = 12;
            buttonB.Text = "B";
            buttonB.UseVisualStyleBackColor = true;
            buttonB.Click += GuessLetter;
            // 
            // buttonU
            // 
            buttonU.BackgroundImageLayout = ImageLayout.Center;
            buttonU.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonU.Location = new Point(203, 141);
            buttonU.Name = "buttonU";
            buttonU.Size = new Size(55, 55);
            buttonU.TabIndex = 17;
            buttonU.Text = "U";
            buttonU.UseVisualStyleBackColor = true;
            buttonU.Click += GuessLetter;
            // 
            // buttonL
            // 
            buttonL.BackgroundImageLayout = ImageLayout.Center;
            buttonL.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonL.Location = new Point(176, 80);
            buttonL.Name = "buttonL";
            buttonL.Size = new Size(55, 55);
            buttonL.TabIndex = 16;
            buttonL.Text = "L";
            buttonL.UseVisualStyleBackColor = true;
            buttonL.Click += GuessLetter;
            // 
            // buttonC
            // 
            buttonC.BackgroundImageLayout = ImageLayout.Center;
            buttonC.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonC.Location = new Point(142, 19);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(55, 55);
            buttonC.TabIndex = 15;
            buttonC.Text = "C";
            buttonC.UseVisualStyleBackColor = true;
            buttonC.Click += GuessLetter;
            // 
            // buttonW
            // 
            buttonW.BackgroundImageLayout = ImageLayout.Center;
            buttonW.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonW.Location = new Point(325, 141);
            buttonW.Name = "buttonW";
            buttonW.Size = new Size(55, 55);
            buttonW.TabIndex = 20;
            buttonW.Text = "W";
            buttonW.UseVisualStyleBackColor = true;
            buttonW.Click += GuessLetter;
            // 
            // buttonM
            // 
            buttonM.BackgroundImageLayout = ImageLayout.Center;
            buttonM.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonM.Location = new Point(237, 80);
            buttonM.Name = "buttonM";
            buttonM.Size = new Size(55, 55);
            buttonM.TabIndex = 19;
            buttonM.Text = "M";
            buttonM.UseVisualStyleBackColor = true;
            buttonM.Click += GuessLetter;
            // 
            // buttonD
            // 
            buttonD.BackgroundImageLayout = ImageLayout.Center;
            buttonD.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonD.Location = new Point(203, 19);
            buttonD.Name = "buttonD";
            buttonD.Size = new Size(55, 55);
            buttonD.TabIndex = 18;
            buttonD.Text = "D";
            buttonD.UseVisualStyleBackColor = true;
            buttonD.Click += GuessLetter;
            // 
            // buttonX
            // 
            buttonX.BackgroundImageLayout = ImageLayout.Center;
            buttonX.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonX.Location = new Point(386, 141);
            buttonX.Name = "buttonX";
            buttonX.Size = new Size(55, 55);
            buttonX.TabIndex = 23;
            buttonX.Text = "X";
            buttonX.UseVisualStyleBackColor = true;
            buttonX.Click += GuessLetter;
            // 
            // buttonN
            // 
            buttonN.BackgroundImageLayout = ImageLayout.Center;
            buttonN.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonN.Location = new Point(298, 80);
            buttonN.Name = "buttonN";
            buttonN.Size = new Size(55, 55);
            buttonN.TabIndex = 22;
            buttonN.Text = "N";
            buttonN.UseVisualStyleBackColor = true;
            buttonN.Click += GuessLetter;
            // 
            // buttonE
            // 
            buttonE.BackgroundImageLayout = ImageLayout.Center;
            buttonE.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonE.Location = new Point(264, 19);
            buttonE.Name = "buttonE";
            buttonE.Size = new Size(55, 55);
            buttonE.TabIndex = 21;
            buttonE.Text = "E";
            buttonE.UseVisualStyleBackColor = true;
            buttonE.Click += GuessLetter;
            // 
            // buttonV
            // 
            buttonV.BackgroundImageLayout = ImageLayout.Center;
            buttonV.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonV.Location = new Point(264, 141);
            buttonV.Name = "buttonV";
            buttonV.Size = new Size(55, 55);
            buttonV.TabIndex = 26;
            buttonV.Text = "V";
            buttonV.UseVisualStyleBackColor = true;
            buttonV.Click += GuessLetter;
            // 
            // buttonO
            // 
            buttonO.BackgroundImageLayout = ImageLayout.Center;
            buttonO.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonO.Location = new Point(359, 80);
            buttonO.Name = "buttonO";
            buttonO.Size = new Size(55, 55);
            buttonO.TabIndex = 25;
            buttonO.Text = "O";
            buttonO.UseVisualStyleBackColor = true;
            buttonO.Click += GuessLetter;
            // 
            // buttonF
            // 
            buttonF.BackgroundImageLayout = ImageLayout.Center;
            buttonF.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonF.Location = new Point(325, 19);
            buttonF.Name = "buttonF";
            buttonF.Size = new Size(55, 55);
            buttonF.TabIndex = 24;
            buttonF.Text = "F";
            buttonF.UseVisualStyleBackColor = true;
            buttonF.Click += GuessLetter;
            // 
            // buttonY
            // 
            buttonY.BackgroundImageLayout = ImageLayout.Center;
            buttonY.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonY.Location = new Point(447, 141);
            buttonY.Name = "buttonY";
            buttonY.Size = new Size(55, 55);
            buttonY.TabIndex = 29;
            buttonY.Text = "Y";
            buttonY.UseVisualStyleBackColor = true;
            buttonY.Click += GuessLetter;
            // 
            // buttonP
            // 
            buttonP.BackgroundImageLayout = ImageLayout.Center;
            buttonP.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonP.Location = new Point(420, 80);
            buttonP.Name = "buttonP";
            buttonP.Size = new Size(55, 55);
            buttonP.TabIndex = 28;
            buttonP.Text = "P";
            buttonP.UseVisualStyleBackColor = true;
            buttonP.Click += GuessLetter;
            // 
            // buttonG
            // 
            buttonG.BackgroundImageLayout = ImageLayout.Center;
            buttonG.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonG.Location = new Point(386, 19);
            buttonG.Name = "buttonG";
            buttonG.Size = new Size(55, 55);
            buttonG.TabIndex = 27;
            buttonG.Text = "G";
            buttonG.UseVisualStyleBackColor = true;
            buttonG.Click += GuessLetter;
            // 
            // buttonZ
            // 
            buttonZ.BackgroundImageLayout = ImageLayout.Center;
            buttonZ.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonZ.Location = new Point(508, 141);
            buttonZ.Name = "buttonZ";
            buttonZ.Size = new Size(55, 55);
            buttonZ.TabIndex = 32;
            buttonZ.Text = "Z";
            buttonZ.UseVisualStyleBackColor = true;
            buttonZ.Click += GuessLetter;
            // 
            // buttonQ
            // 
            buttonQ.BackgroundImageLayout = ImageLayout.Center;
            buttonQ.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonQ.Location = new Point(480, 80);
            buttonQ.Name = "buttonQ";
            buttonQ.Size = new Size(55, 55);
            buttonQ.TabIndex = 31;
            buttonQ.Text = "Q";
            buttonQ.UseVisualStyleBackColor = true;
            buttonQ.Click += GuessLetter;
            // 
            // buttonH
            // 
            buttonH.BackgroundImageLayout = ImageLayout.Center;
            buttonH.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonH.Location = new Point(447, 19);
            buttonH.Name = "buttonH";
            buttonH.Size = new Size(55, 55);
            buttonH.TabIndex = 30;
            buttonH.Text = "H";
            buttonH.UseVisualStyleBackColor = true;
            buttonH.Click += GuessLetter;
            // 
            // buttonR
            // 
            buttonR.BackgroundImageLayout = ImageLayout.Center;
            buttonR.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonR.Location = new Point(23, 141);
            buttonR.Name = "buttonR";
            buttonR.Size = new Size(55, 55);
            buttonR.TabIndex = 34;
            buttonR.Text = "R";
            buttonR.UseVisualStyleBackColor = true;
            buttonR.Click += GuessLetter;
            // 
            // buttonI
            // 
            buttonI.BackgroundImageLayout = ImageLayout.Center;
            buttonI.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonI.Location = new Point(508, 19);
            buttonI.Name = "buttonI";
            buttonI.Size = new Size(55, 55);
            buttonI.TabIndex = 33;
            buttonI.Text = "I";
            buttonI.UseVisualStyleBackColor = true;
            buttonI.Click += GuessLetter;
            // 
            // panelAllLetterButtons
            // 
            panelAllLetterButtons.Controls.Add(buttonR);
            panelAllLetterButtons.Controls.Add(buttonI);
            panelAllLetterButtons.Controls.Add(buttonZ);
            panelAllLetterButtons.Controls.Add(buttonQ);
            panelAllLetterButtons.Controls.Add(buttonH);
            panelAllLetterButtons.Controls.Add(buttonY);
            panelAllLetterButtons.Controls.Add(buttonP);
            panelAllLetterButtons.Controls.Add(buttonG);
            panelAllLetterButtons.Controls.Add(buttonV);
            panelAllLetterButtons.Controls.Add(buttonO);
            panelAllLetterButtons.Controls.Add(buttonF);
            panelAllLetterButtons.Controls.Add(buttonX);
            panelAllLetterButtons.Controls.Add(buttonN);
            panelAllLetterButtons.Controls.Add(buttonE);
            panelAllLetterButtons.Controls.Add(buttonW);
            panelAllLetterButtons.Controls.Add(buttonM);
            panelAllLetterButtons.Controls.Add(buttonD);
            panelAllLetterButtons.Controls.Add(buttonU);
            panelAllLetterButtons.Controls.Add(buttonL);
            panelAllLetterButtons.Controls.Add(buttonC);
            panelAllLetterButtons.Controls.Add(buttonT);
            panelAllLetterButtons.Controls.Add(buttonK);
            panelAllLetterButtons.Controls.Add(buttonB);
            panelAllLetterButtons.Controls.Add(buttonS);
            panelAllLetterButtons.Controls.Add(buttonJ);
            panelAllLetterButtons.Controls.Add(buttonA);
            panelAllLetterButtons.Location = new Point(420, 302);
            panelAllLetterButtons.Name = "panelAllLetterButtons";
            panelAllLetterButtons.Size = new Size(587, 212);
            panelAllLetterButtons.TabIndex = 35;
            // 
            // Hangman
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 623);
            Controls.Add(panelAllLetterButtons);
            Controls.Add(buttonReset);
            Controls.Add(labelGuessedLettersList);
            Controls.Add(labelGuessedLettersTitle);
            Controls.Add(labelGuessedWord);
            Controls.Add(labelGuessWordPrompt);
            Controls.Add(pictureBox);
            MaximizeBox = false;
            Name = "Hangman";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hangman";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            panelAllLetterButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private Label labelGuessWordPrompt;
        private Label labelGuessedWord;
        private Label labelGuessedLettersTitle;
        private Label labelGuessedLettersList;
        private Button buttonReset;
        private Button buttonA;
        private Button buttonJ;
        private Button buttonS;
        private Button buttonT;
        private Button buttonK;
        private Button buttonB;
        private Button buttonU;
        private Button buttonL;
        private Button buttonC;
        private Button buttonW;
        private Button buttonM;
        private Button buttonD;
        private Button buttonX;
        private Button buttonN;
        private Button buttonE;
        private Button buttonV;
        private Button buttonO;
        private Button buttonF;
        private Button buttonY;
        private Button buttonP;
        private Button buttonG;
        private Button buttonZ;
        private Button buttonQ;
        private Button buttonH;
        private Button buttonR;
        private Button buttonI;
        private Panel panelAllLetterButtons;
    }
}
