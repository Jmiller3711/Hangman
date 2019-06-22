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
    public partial class NewGame : Form
    {
        public string SecretWord { get; set; }

        public NewGame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text.Contains(" ") || textBox1.Text.Length > 14)
            {
                MessageBox.Show("Please enter a word with less than 14 characters and with no spaces");
                return;
            }
            SecretWord = textBox1.Text;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                var easyWords = new string[] { "apple", "guitar", "remote", "banana", "bottle", "phone", "computer", "hangman", "lamp", "football", "book" };
                SecretWord = GetRandomWord(easyWords);
            }
            else if (radioButton2.Checked)
            {
                var mediumWords = new string[] { "zippy", "zombie", "papaya", "banana", "guava", "jazzy" };
                SecretWord = GetRandomWord(mediumWords);
            }
            else if (radioButton3.Checked)
            {
                var hardWords = new string[] { "awkward", "bagpipes", "banjo", "croquet", "crypt", "dwarves", "gazebo", "haiku", "ivory", "jinx", "pajama", "yacht", "sky" };
                SecretWord = GetRandomWord(hardWords);
            }
            else
            {
                MessageBox.Show("Please select a difficulty!");
                return;
            }
            Close();
        }

        private string GetRandomWord(string[] words)
        {
            Random rnd = new Random();
            return words[rnd.Next(0, words.Length)];
        }
    }
}
