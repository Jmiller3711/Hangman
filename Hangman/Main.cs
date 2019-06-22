using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Main : Form
    {
        private string SecretWord { get; set; }
        private int WrongGuesses { get; set; }
        private List<SecretWordDictionary<string, string>> SecretWordDictionary { get; set; }

        public Main()
        {
            InitializeComponent();

            //pictureBox1.Image = Image.FromFile("C:\\Users\\Jordan\\Desktop\\Hangman0.png");
            pictureBox1.Image = Properties.Resources.Hangman0;


            WrongGuesses = 0;

            var buttons = new List<Button> { button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28 };
            foreach (var button in buttons)
            {
                button.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e) //New Game
        {
            label1.Text = "______________";
            //pictureBox1.Image = Image.FromFile("C:\\Users\\Jordan\\Desktop\\Hangman0.png");
            pictureBox1.Image = Properties.Resources.Hangman0;

            var newGame = new NewGame();
            newGame.ShowDialog();
            if (newGame.SecretWord == null) return;
            SecretWord = newGame.SecretWord.ToUpper();
            WrongGuesses = 0;

            SecretWordDictionary = new List<SecretWordDictionary<string, string>>();
            foreach (var letter in SecretWord)
            {
                SecretWordDictionary.Add(new SecretWordDictionary<string, string> { First = "_", Second = letter.ToString() });
            }

            var buttons = new List<Button> { button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28 };
            foreach (var button in buttons)
            {
                button.Enabled = true;
            }

            UpdateLabelText();
        }

        private void button2_Click(object sender, EventArgs e) //A
        {
            button2.Enabled = false;
            ProcessGuess("A");
        }

        private void button3_Click(object sender, EventArgs e) //B
        {
            button3.Enabled = false;
            ProcessGuess("B");
        }

        private void button4_Click(object sender, EventArgs e) //C
        {
            button4.Enabled = false;
            ProcessGuess("C");
        }

        private void button5_Click(object sender, EventArgs e) //D
        {
            button5.Enabled = false;
            ProcessGuess("D");
        }

        private void button6_Click(object sender, EventArgs e) //E
        {
            button6.Enabled = false;
            ProcessGuess("E");
        }

        private void button7_Click(object sender, EventArgs e) //F
        {
            button7.Enabled = false;
            ProcessGuess("F");
        }

        private void button8_Click(object sender, EventArgs e) //G
        {
            button8.Enabled = false;
            ProcessGuess("G");
        }

        private void button9_Click(object sender, EventArgs e) //H
        {
            button9.Enabled = false;
            ProcessGuess("H");
        }

        private void button10_Click(object sender, EventArgs e) //I
        {
            button10.Enabled = false;
            ProcessGuess("I");
        }

        private void button11_Click(object sender, EventArgs e) //J
        {
            button11.Enabled = false;
            ProcessGuess("J");
        }

        private void button12_Click(object sender, EventArgs e) //K
        {
            button12.Enabled = false;
            ProcessGuess("K");
        }

        private void button13_Click(object sender, EventArgs e) //L
        {
            button13.Enabled = false;
            ProcessGuess("L");
        }

        private void button14_Click(object sender, EventArgs e) //M
        {
            button14.Enabled = false;
            ProcessGuess("M");
        }

        private void button15_Click(object sender, EventArgs e) //N
        {
            button15.Enabled = false;
            ProcessGuess("N");
        }

        private void button16_Click(object sender, EventArgs e) //O
        {
            button16.Enabled = false;
            ProcessGuess("O");
        }

        private void button17_Click(object sender, EventArgs e) //P
        {
            button17.Enabled = false;
            ProcessGuess("P");
        }

        private void button18_Click(object sender, EventArgs e) //Q
        {
            button18.Enabled = false;
            ProcessGuess("Q");
        }

        private void button19_Click(object sender, EventArgs e) //R
        {
            button19.Enabled = false;
            ProcessGuess("R");
        }

        private void button20_Click(object sender, EventArgs e) //S
        {
            button20.Enabled = false;
            ProcessGuess("S");
        }

        private void button21_Click(object sender, EventArgs e) //T
        {
            button21.Enabled = false;
            ProcessGuess("T");
        }

        private void button22_Click(object sender, EventArgs e) //U
        {
            button22.Enabled = false;
            ProcessGuess("U");
        }

        private void button23_Click(object sender, EventArgs e) //V
        {
            button23.Enabled = false;
            ProcessGuess("V");
        }

        private void button24_Click(object sender, EventArgs e) //W
        {
            button24.Enabled = false;
            ProcessGuess("W");
        }

        private void button25_Click(object sender, EventArgs e) //X
        {
            button25.Enabled = false;
            ProcessGuess("X");
        }

        private void button26_Click(object sender, EventArgs e) //Y
        {
            button26.Enabled = false;
            ProcessGuess("Y");
        }

        private void button27_Click(object sender, EventArgs e) //Z
        {
            button27.Enabled = false;
            ProcessGuess("Z");
        }

        private void button28_Click(object sender, EventArgs e) //Guess
        {
            var guess = new Guess(SecretWord);
            guess.ShowDialog();
            if (guess.UserCancelled) return;
            if (guess.GuessResult)
            {
                //pictureBox1.Image = Image.FromFile("C:\\Users\\Jordan\\Desktop\\HangmanWin.png");
                pictureBox1.Image = Properties.Resources.Hangman0;
                var buttons = new List<Button> { button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28 };
                foreach (var button in buttons)
                {
                    button.Enabled = false;
                }
                label1.Text = SecretWord;
            }
            else
            {
                GameOver();
            }
        }

        private void ProcessGuess(string letter)
        {
            if (SecretWord.Contains(letter))
            {
                UpdateLabel(letter);
                CheckForWin();
            }
            else
            {
                WrongGuesses++;
                UpdatePicture();
            }
        }

        private void CheckForWin()
        {
            var winner = true;
            foreach (var pair in SecretWordDictionary)
            {
                if (pair.First == "_")
                {
                    winner = false;
                    break;
                }
            }

            if (winner)
            {
                //pictureBox1.Image = Image.FromFile("C:\\Users\\Jordan\\Desktop\\HangmanWin.png");
                pictureBox1.Image = Properties.Resources.HangmanWin;

                var buttons = new List<Button> { button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28 };
                foreach (var button in buttons)
                {
                    button.Enabled = false;
                }
                label1.Text = SecretWord;
            }
        }

        private void UpdateLabel(string letterGuess)
        {
            foreach (var pair in SecretWordDictionary)
            {
                if (pair.Second == letterGuess)
                {
                    pair.First = letterGuess;
                }
            }
            UpdateLabelText();
        }

        private void UpdatePicture()
        {
            if (WrongGuesses == 1)
            {
                //pictureBox1.Image = Image.FromFile("C:\\Users\\Jordan\\Desktop\\Hangman1.png");
                pictureBox1.Image = Properties.Resources.Hangman1;
            }
            else if (WrongGuesses == 2)
            {
                //pictureBox1.Image = Image.FromFile("C:\\Users\\Jordan\\Desktop\\Hangman2.png");
                pictureBox1.Image = Properties.Resources.Hangman2;
            }
            else if (WrongGuesses == 3)
            {
                //pictureBox1.Image = Image.FromFile("C:\\Users\\Jordan\\Desktop\\Hangman3.png");
                pictureBox1.Image = Properties.Resources.Hangman3;
            }
            else if (WrongGuesses == 4)
            {
                //pictureBox1.Image = Image.FromFile("C:\\Users\\Jordan\\Desktop\\Hangman4.png");
                pictureBox1.Image = Properties.Resources.Hangman4;
            }
            else if (WrongGuesses == 5)
            {
                //pictureBox1.Image = Image.FromFile("C:\\Users\\Jordan\\Desktop\\Hangman5.png");
                pictureBox1.Image = Properties.Resources.Hangman5;
            }
            else if (WrongGuesses == 6)
            {
                GameOver();
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        private void UpdateLabelText()
        {
            var labelText = "";
            foreach (var pair in SecretWordDictionary)
            {
                labelText += pair.First + " ";
            }
            label1.Text = labelText.TrimEnd();
        }

        private void GameOver()
        {
            //pictureBox1.Image = Image.FromFile("C:\\Users\\Jordan\\Desktop\\Hangman6.png");
            pictureBox1.Image = Properties.Resources.Hangman6;

            var buttons = new List<Button> { button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28 };
            foreach (var button in buttons)
            {
                button.Enabled = false;
            }
            label1.Text = SecretWord;
        }
    }
}
