using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class frmArabic : Form
    {
        public frmArabic()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form frm = new MainForm();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
        int Length(string S1)
        {
            return S1.Length;
        }
        public int CountWords(string input)
        {
            string[] separators = { " ", "\t", "\n" }; // يمكنك تعديل الفواصل حسب الحاجة

            string[] words = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

        public short CountSpaces(string Word)
        {
            short Counter = 0;
            for (int i = 0; i < Word.Length; i++)
                if (Word[i] == ' ')
                    Counter++;
            return Counter;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lblChar.Text = Length(textBox1.Text).ToString();
            lblWords.Text = CountWords(textBox1.Text).ToString();
            lblSpaces.Text = CountSpaces(textBox1.Text).ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblChar.Text = "0";
            lblSpaces.Text = "0";
            lblWords.Text = "0";
            textBox1.Text = "";
        }
        private bool IsEnglishCharacter(char c)
        {
            // English character range
            return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z');

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is an English character
            if (IsEnglishCharacter(e.KeyChar))
            {
                e.Handled = true; // Prevent the character from being entered
            }
        }

        private void btnChangeFroeColor_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void btnChangeBackColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.BackColor = colorDialog1.Color;
            }
        }
    }
}
