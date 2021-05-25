using System;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        int step = 0;
        char symbol = ' ';

        public void CheckSymbol()
        {
            if(step%2==0)
            {
                symbol = 'x';
            }
            else
            {
                symbol = 'o';
            }
        }

        public bool Check()
        {
            if((button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "") ||
               (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "") ||
               (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "") ||
               (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "") ||
               (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "") ||
               (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "") ||
               (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "") ||
               (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != ""))
            {
                return true;
            }
            else 
            {
                return false; 
            }         
        }

        public void CheckVictory()
        {            
            if (Check())
            {
                if (step % 2 == 1)
                {
                    MessageBox.Show("X Победили");
                }
                else
                {
                    MessageBox.Show("O Победили");
                }
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
            if(step == 8)
            {
                MessageBox.Show("Ничья");
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckSymbol();
            button1.Text = symbol.ToString();
            button1.Enabled = false;
            step++;

            CheckVictory();  
        }
   
        private void button2_Click(object sender, EventArgs e)
        {
            CheckSymbol();
            button2.Text = symbol.ToString();
            button2.Enabled = false;
            step++;

            CheckVictory();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CheckSymbol();
            button3.Text = symbol.ToString();
            button3.Enabled = false;
            step++;

            CheckVictory();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CheckSymbol();
            button4.Text = symbol.ToString();
            button4.Enabled = false;
            step++;

            CheckVictory();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CheckSymbol();
            button5.Text = symbol.ToString();
            button5.Enabled = false;
            step++;

            CheckVictory();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CheckSymbol();
            button6.Text = symbol.ToString();
            button6.Enabled = false;
            step++;

            CheckVictory();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CheckSymbol();
            button7.Text = symbol.ToString();
            button7.Enabled = false;
            step++;

            CheckVictory();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CheckSymbol();
            button8.Text = symbol.ToString();
            button8.Enabled = false;
            step++;

            CheckVictory();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CheckSymbol();
            button9.Text = symbol.ToString();
            button9.Enabled = false;
            step++;

            CheckVictory();
        }

    }

   
}
