using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wordle_clone
{
    public partial class Wordle : Form
    {
        int currentRow = 1;

        string[] words = {"Music", "House", "Horse"};

        string correctWord = "";
        string guessedWord = "";

        List<TextBox> rowOneTextBoxes = new List<TextBox>();
        List<TextBox> rowTwoTextBoxes = new List<TextBox>();
        List<TextBox> rowThreeTextBoxes = new List<TextBox>();
        List<TextBox> rowFourTextBoxes = new List<TextBox>();
        List<TextBox> rowFiveTextBoxes = new List<TextBox>();

        NetSpell.SpellChecker.Dictionary.WordDictionary oDict = new NetSpell.SpellChecker.Dictionary.WordDictionary();
        NetSpell.SpellChecker.Spelling oSpell = new NetSpell.SpellChecker.Spelling();

        public Wordle()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            oDict.DictionaryFile = "en-US.dic"; 
            oDict.Initialize();

            oSpell.Dictionary = oDict;

            AddRowsToList();
            GenerateWord();
            UnlockRow();

        }

        private void GenerateWord()
        {
            Random randomWord = new Random();
            correctWord = words[randomWord.Next(0, words.Length)];
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
                    ((TextBox)control).Enabled = false;
                }

                if ((control is TextBox) && control.Tag.ToString() == row.ToString())
                {
                    ((TextBox)control).Enabled = true;
                }
                

            }
        }

        private string GetGuessedWord()
        {
            switch(currentRow)
            {
                case 1:
                    {
                        //guessedWord = String.Concat(rowOneLetterOne.Text + rowOneLetterTwo.Text + rowOneLetterThree.Text + rowOneLetterFour.Text + rowOneLetterFive.Text);

                        for (int i = 0; i < 5; i++)
                        {
                            guessedWord += rowOneTextBoxes[i].Text.ToString();
                        }
                        break;
                    }

                case 2:
                    {
                        //guessedWord = String.Concat(rowTwoLetterOne.Text + rowTwoLetterTwo.Text + rowTwoLetterThree.Text + rowTwoLetterFour.Text + rowTwoLetterFive.Text);
                        for (int i = 0; i < 5; i++)
                        {
                            guessedWord += rowTwoTextBoxes[i].Text.ToString();
                        }
                        break;
                    }

                case 3:
                    {
                        //guessedWord = String.Concat(rowThreeLetterOne.Text + rowThreeLetterTwo.Text + rowThreeLetterThree.Text + rowThreeLetterFour.Text + rowThreeLetterFive.Text);
                        for (int i = 0; i < 5; i++)
                        {
                            guessedWord += rowThreeTextBoxes[i].Text.ToString();
                        }
                        break;
                    }

                case 4:
                    {
                        //guessedWord = String.Concat(rowFourLetterOne.Text + rowFourLetterTwo.Text + rowFourLetterThree.Text + rowFourLetterFour.Text + rowFourLetterFive.Text);
                        for (int i = 0; i < 5; i++)
                        {
                            guessedWord += rowFourTextBoxes[i].Text.ToString();
                        }
                        break;
                    }

                case 5:
                    {
                        //guessedWord = String.Concat(rowFiveLetterOne.Text + rowFiveLetterTwo.Text + rowFiveLetterThree.Text + rowFiveLetterFour.Text + rowFiveLetterFive.Text);
                        for (int i = 0; i < 5; i++)
                        {
                            guessedWord += rowFiveTextBoxes[i].Text.ToString();
                        }
                        break;
                    }
            }
            return guessedWord;
        }

        private void CheckIncorrectCharacters()
        {
            switch(currentRow)
            {
                case 1:
                    {
                        if (correctWord.Contains(rowOneLetterOne.Text) && rowOneLetterOne.Text != correctWord[0].ToString())
                            rowOneLetterOne.BackColor = Color.FromArgb(255, 179, 64);

                        if (correctWord.Contains(rowOneLetterTwo.Text) && rowOneLetterTwo.Text != correctWord[1].ToString())
                            rowOneLetterOne.BackColor = Color.FromArgb(255, 179, 64);

                        if (correctWord.Contains(rowOneLetterThree.Text) && rowOneLetterThree.Text != correctWord[1].ToString())
                            rowOneLetterOne.BackColor = Color.FromArgb(255, 179, 64);

                        if (correctWord.Contains(rowOneLetterFour.Text) && rowOneLetterFour.Text != correctWord[1].ToString())
                            rowOneLetterOne.BackColor = Color.FromArgb(255, 179, 64);

                        if (correctWord.Contains(rowOneLetterFive.Text) && rowOneLetterFive.Text != correctWord[1].ToString())
                            rowOneLetterOne.BackColor = Color.FromArgb(255, 179, 64);

                        break;
                    }

                case 2:
                    {
                        if (correctWord.Contains(rowTwoLetterOne.Text) && rowTwoLetterOne.Text != correctWord[0].ToString())
                            rowOneLetterOne.BackColor = Color.FromArgb(255, 179, 64);

                        if (correctWord.Contains(rowTwoLetterTwo.Text) && rowTwoLetterTwo.Text != correctWord[1].ToString())
                            rowOneLetterOne.BackColor = Color.FromArgb(255, 179, 64);

                        if (correctWord.Contains(rowTwoLetterThree.Text) && rowTwoLetterThree.Text != correctWord[1].ToString())
                            rowOneLetterOne.BackColor = Color.FromArgb(255, 179, 64);

                        if (correctWord.Contains(rowTwoLetterFour.Text) && rowTwoLetterFour.Text != correctWord[1].ToString())
                            rowOneLetterOne.BackColor = Color.FromArgb(255, 179, 64);

                        if (correctWord.Contains(rowTwoLetterFive.Text) && rowTwoLetterFive.Text != correctWord[1].ToString())
                            rowOneLetterOne.BackColor = Color.FromArgb(255, 179, 64);

                        break;
                    }
            }
        }

        private void CheckValidCharacters()
        {
            switch(currentRow)
            {
                case 1:
                    {
                        for(int i = 0; i < 5; i++)
                        {
                            if (rowOneTextBoxes[i].Text == correctWord[i].ToString())
                                rowOneTextBoxes[i].BackColor = Color.Green;
                        }
                        break;
                    }

                case 2:
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            if (rowTwoTextBoxes[i].Text == correctWord[i].ToString())
                                rowTwoTextBoxes[i].BackColor = Color.Green;
                        }
                        break;
                    }

                case 3:
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            if (rowThreeTextBoxes[i].Text == correctWord[i].ToString())
                                rowThreeTextBoxes[i].BackColor = Color.Green;
                        }
                        break;
                    }

                case 4:
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            if (rowFourTextBoxes[i].Text == correctWord[i].ToString())
                                rowFourTextBoxes[i].BackColor = Color.Green;
                        }
                        break;
                    }

                case 5:
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            if (rowFiveTextBoxes[i].Text == correctWord[i].ToString())
                                rowFiveTextBoxes[i].BackColor = Color.Green;
                        }
                        break;
                    }
            }
        }

        private void checkButton_Click(object sender, EventArgs e)
        {

            if (!oSpell.TestWord(GetGuessedWord()))
            {
                MessageBox.Show("Word does not exist in our database :(");
                return;
            }

            else
            {
                guessedWord = String.Empty;
                currentRow++;
                UnlockRow();
            }

            if(currentRow >= 1 && currentRow <= 5)
            {
                CheckIncorrectCharacters();
                CheckValidCharacters();
            }

            if (correctWord == GetGuessedWord())
            {
                MessageBox.Show("You got it correctly!");
                return;
            }
        }

        /*private void Wordle_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("textchanged func called");

            foreach(Control control in this.Controls)
            {
                if(control is TextBox)
                {
                    ((TextBox)control).Text.ToUpper();
                }
            }
        }*/

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
