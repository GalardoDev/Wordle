using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace wordle_clone
{

    public partial class Wordle : Form
    {
        int currentRow = 1;

        string[] words = {
            "MUSIC", 
            "HOUSE", 
            "HORSE",
            "UNCLE",
            "TRUCK",
            "MONTH",
            "STEAL",
            "PLANE"
        };

        string correctWord = String.Empty;
        string guessedWord = String.Empty;

        List<TextBox> rowOneTextBoxes = new List<TextBox>();
        List<TextBox> rowTwoTextBoxes = new List<TextBox>();
        List<TextBox> rowThreeTextBoxes = new List<TextBox>();
        List<TextBox> rowFourTextBoxes = new List<TextBox>();
        List<TextBox> rowFiveTextBoxes = new List<TextBox>();

        System.Timers.Timer alertTimer = new System.Timers.Timer();

        NetSpell.SpellChecker.Dictionary.WordDictionary oDict = new NetSpell.SpellChecker.Dictionary.WordDictionary();
        NetSpell.SpellChecker.Spelling oSpell = new NetSpell.SpellChecker.Spelling();

        public Wordle()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Panel.CheckForIllegalCrossThreadCalls = false;

            alertPanel.Hide();
       
            oDict.DictionaryFile = "en-US.dic"; 
            oDict.Initialize();

            oSpell.Dictionary = oDict;

            AddRowsToList();
            GenerateWord();
            UnlockRow();

        }

        private void HideAlertPanel(object sender, ElapsedEventArgs e)
        {
            alertPanel.Hide();
            alertTimer.Stop();
        }

        private void StartHideTimer()
        {
            alertTimer.Interval = 3000;
            alertTimer.Elapsed += HideAlertPanel;
            alertTimer.Start();
        }

        private void GenerateWord()
        {
            Random randomWord = new Random();
            correctWord = words[randomWord.Next(0, words.Length)].ToUpper();
        }

        private void UnlockRow()
        {
            switch(currentRow)
            {
                case 1:
                    {
                        TargetRow("rowOne");
                        break;
                    }

                case 2:
                    {
                        TargetRow("rowTwo");
                        break;
                    }

                case 3:
                    {
                        TargetRow("rowThree");
                        break;
                    }

                case 4:
                    {
                        TargetRow("rowFour");
                        break;
                    }

                case 5:
                    {
                        TargetRow("rowFive");
                        break;
                    }
            }
        }

        private void TargetRow(string row)
        {
            foreach (Control control in this.Controls)
            {
                if ((control is TextBox) && control.Tag.ToString() != row.ToString())
                {
                    //((TextBox)control).ReadOnly = true; // Since there is bug with forecolor of textbox in the case textbox is disabled, I had to do it this way.
                    ((TextBox)control).Enabled = false;
                }

                if ((control is TextBox) && control.Tag.ToString() == row.ToString())
                {
                    //((TextBox)control).ReadOnly = false; // Since there is bug with forecolor of textbox in the case textbox is disabled, I had to do it this way.
                    ((TextBox)control).Enabled = true;
                }
                
            }
        }

        private void AssignCharactersToWord(List<TextBox> targetTextBox)
        {
            for (int i = 0; i < 5; i++)
                guessedWord += targetTextBox[i].Text.ToString().ToUpper();   
        }

        private string GetGuessedWord()
        {
            guessedWord = String.Empty;

            switch(currentRow)
            {
                case 1:
                    {   
                        AssignCharactersToWord(rowOneTextBoxes);
                        break;
                    }

                case 2:
                    {
                        AssignCharactersToWord(rowTwoTextBoxes);
                        break;
                    }

                case 3:
                    {
                        AssignCharactersToWord(rowThreeTextBoxes);
                        break;
                    }

                case 4:
                    {
                        AssignCharactersToWord(rowFourTextBoxes);
                        break;
                    }

                case 5:
                    {
                        AssignCharactersToWord(rowFiveTextBoxes);
                        break;
                    }
            }
            return guessedWord;
        }

        private void TargetTextBox(List<TextBox> targetTextBox)
        {
            for (int i = 0; i < 5; i++)
            {
                if (correctWord.Contains(targetTextBox[i].Text.ToUpper()) && targetTextBox[i].Text.ToUpper() != correctWord[i].ToString())
                {
                    targetTextBox[i].BackColor = Color.FromArgb(255, 179, 64);
                    //targetTextBox[i].ForeColor = Color.White; // does not work cuz of disabled textbox
                }

                if (!correctWord.Contains(targetTextBox[i].Text.ToUpper()))
                {
                    targetTextBox[i].BackColor = Color.Crimson;
                    //targetTextBox[i].ForeColor = Color.White; // does not work cuz of disabled textbox
                }
            }
        }

        private void CheckIncorrectCharacters()
        {
            switch(currentRow)
            {
                case 1:
                    {
                        TargetTextBox(rowOneTextBoxes);
                        break;
                    }

                case 2:
                    {
                        TargetTextBox(rowTwoTextBoxes);
                        break;
                    }

                case 3:
                    {
                        TargetTextBox(rowThreeTextBoxes);
                        break;
                    }

                case 4:
                    {
                        TargetTextBox(rowFourTextBoxes);
                        break;
                    }

                case 5:
                    {
                        TargetTextBox(rowFiveTextBoxes);
                        break;
                    }
            }
        }

        private void TargetValidTextBox(List<TextBox> targetTextBox)
        {
            for (int i = 0; i < 5; i++)
            {
                if (targetTextBox[i].Text.ToUpper() == correctWord[i].ToString())
                {
                    targetTextBox[i].ForeColor = Color.White;
                    targetTextBox[i].BackColor = Color.FromArgb(23, 65, 113);
                }
            }
        }

        private void CheckValidCharacters()
        {
            switch(currentRow)
            {
                case 1:
                    {
                        TargetValidTextBox(rowOneTextBoxes);
                        break;
                    }

                case 2:
                    {
                        TargetValidTextBox(rowTwoTextBoxes);
                        break;
                    }

                case 3:
                    {
                        TargetValidTextBox(rowThreeTextBoxes);
                        break;
                    }

                case 4:
                    {
                        TargetValidTextBox(rowFourTextBoxes);
                        break;
                    }

                case 5:
                    {
                        TargetValidTextBox(rowFiveTextBoxes);
                        break;
                    }
            }
        }

        private void AlertContent(string content, Color color)
        {
            alertLabel.Text = content;
            alertLabel.BackColor = color;
            alertPictureBox.FillColor = color;
            alertPanel.Show();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {

            if (GetGuessedWord().Length != 5)
            {
                AlertContent("Enter all 5 characters", Color.Crimson);
                StartHideTimer();
                return;
            }

            else if (!oSpell.TestWord(GetGuessedWord()))
            {
                AlertContent("Word does not exist in our database!", Color.Crimson);
                StartHideTimer();
                return;
            }

            else
            {
                if (currentRow >= 1 && currentRow <= 5)
                {

                    CheckIncorrectCharacters();
                    CheckValidCharacters();

                    if (correctWord == GetGuessedWord())
                    {
                        AlertContent("You got it correctly!", Color.FromArgb(136, 212, 66));
                        StartHideTimer();
                        return;
                    }
                }
            }

            currentRow++;
            UnlockRow();

        }

        private void ClearRow(List<TextBox> targetTextBox)
        {
            for (int i = 0; i < 5; i++)
                targetTextBox[i].Text = String.Empty;

            guessedWord = String.Empty;

            AlertContent("Row(s) has been cleared!", Color.FromArgb(136, 212, 66));
            StartHideTimer();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            switch(currentRow)
            {
                case 1:
                    {
                        ClearRow(rowOneTextBoxes);
                        break;
                    }

                case 2:
                    {
                        ClearRow(rowTwoTextBoxes);
                        break;
                    }

                case 3:
                    {
                        ClearRow(rowThreeTextBoxes);
                        break;
                    }

                case 4:
                    {
                        ClearRow(rowFourTextBoxes);
                        break;
                    }

                case 5:
                    {
                        ClearRow(rowFiveTextBoxes);
                        break;
                    }
            }

        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            foreach(Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).ForeColor = Color.Black;
                    ((TextBox)control).BackColor = Color.White;
                    ((TextBox)control).Text = String.Empty;
                }
            }

            currentRow = 1;

            GenerateWord();
            UnlockRow();

            AlertContent("New game has started!", Color.FromArgb(136, 212, 66));
            StartHideTimer();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddRowsToList()
        {
            //

            rowOneTextBoxes.Add(rowOneLetterOne);
            rowOneTextBoxes.Add(rowOneLetterTwo);
            rowOneTextBoxes.Add(rowOneLetterThree);
            rowOneTextBoxes.Add(rowOneLetterFour);
            rowOneTextBoxes.Add(rowOneLetterFive);

            //

            rowTwoTextBoxes.Add(rowTwoLetterOne);
            rowTwoTextBoxes.Add(rowTwoLetterTwo);
            rowTwoTextBoxes.Add(rowTwoLetterThree);
            rowTwoTextBoxes.Add(rowTwoLetterFour);
            rowTwoTextBoxes.Add(rowTwoLetterFive);

            //

            rowThreeTextBoxes.Add(rowThreeLetterOne);
            rowThreeTextBoxes.Add(rowThreeLetterTwo);
            rowThreeTextBoxes.Add(rowThreeLetterThree);
            rowThreeTextBoxes.Add(rowThreeLetterFour);
            rowThreeTextBoxes.Add(rowThreeLetterFive);

            // 

            rowFourTextBoxes.Add(rowFourLetterOne);
            rowFourTextBoxes.Add(rowFourLetterTwo);
            rowFourTextBoxes.Add(rowFourLetterThree);
            rowFourTextBoxes.Add(rowFourLetterFour);
            rowFourTextBoxes.Add(rowFourLetterFive);

            // 

            rowFiveTextBoxes.Add(rowFiveLetterOne);
            rowFiveTextBoxes.Add(rowFiveLetterTwo);
            rowFiveTextBoxes.Add(rowFiveLetterThree);
            rowFiveTextBoxes.Add(rowFiveLetterFour);
            rowFiveTextBoxes.Add(rowFiveLetterFive);
        }

    }
}
