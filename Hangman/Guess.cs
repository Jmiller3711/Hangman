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
    public partial class Guess : Form
    {
        private string SecretWord { get; set; }
        public bool GuessResult = false;
        public bool UserCancelled = false;

        public Guess(string secretWord)
        {
            InitializeComponent();
            SecretWord = secretWord;
            GuessResult = false;
            UserCancelled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserCancelled = true;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToUpper() == SecretWord)
            {
                GuessResult = true;
            }
            Close();
        }
    }
}
