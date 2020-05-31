using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form 
    {
        //define the server side connection with new proxy
        ServiceReference1.ServiceClient proxy = new ServiceReference1.ServiceClient();
        bool isEntered = false;
        int secretNum = 0;
        int guess_count = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            guess_text.Text = "";
            try
            {
                int lower = Int32.Parse(lower_text.Text);
                int upper = Int32.Parse(upper_text.Text);

                if (lower < upper)
                {
                    secretNum = proxy.SecretNumber(lower, upper);
                    isEntered = true;
                    response_label.Text = "A secret number has been generated";
                }
                else
                {
                    response_label.Text = "The lower must be less than upper";
                }

            }
            catch (Exception ex) {
                response_label.Text = "Please enter correct lower and upper integers!";
            }

        }
        private void play_btn_Click(object sender, EventArgs e)
        {
            response_label.Text = "";
            if (isEntered)
            {
                attempt_num.Text = (guess_count++).ToString();
                try
                {
                    int guess_num = Int32.Parse(guess_text.Text);
                    if (guess_num < secretNum && guess_num >= Int32.Parse(lower_text.Text) && guess_num <= Int32.Parse(upper_text.Text))
                    {
                        num_reponse.Text = proxy.checkNumber(guess_num, secretNum);
                    }
                    else if (guess_num > secretNum && guess_num >= Int32.Parse(lower_text.Text) && guess_num <= Int32.Parse(upper_text.Text))
                    {
                        num_reponse.Text = proxy.checkNumber(guess_num, secretNum);
                    }
                    else if (guess_num == secretNum)
                    {
                        num_reponse.Text = "correct";
                        response_label.Text = proxy.checkNumber(guess_num, secretNum);
                    }
                    else {
                        response_label.Text = "The number is out of range!";
                    }
                }
                catch (Exception ex)
                {
                    response_label.Text = "Please enter correct guessing number!";
                }
            }
            else
            {
                response_label.Text = "Please generate a secret number first!";
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click_2(object sender, EventArgs e)
        {

        }

        
    }
}
