using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form 
    {
        //Connect to RESTful API
        Uri baseUri = new Uri("http://localhost:52736/Service.svc");
        UriTemplate get_secretNum = new UriTemplate("/secretNum?lower={lower}&upper={upper}");
        UriTemplate get_checkNum = new UriTemplate("/checkNum?userNum={userNum}&secretNum={secretNum}");

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

                //data to be send
                string[] secretArray = { lower.ToString(), upper.ToString() };

                //Method to call RESTful API service
                string get_screteNum() {
                    Uri completeSecretUri = get_secretNum.BindByPosition(baseUri, secretArray);
                    WebClient channel = new WebClient();
                    byte[] abc = channel.DownloadData(completeSecretUri);
                    Stream strm = new MemoryStream(abc);
                    DataContractSerializer obj = new DataContractSerializer(typeof(int));
                    string secretNumString = obj.ReadObject(strm).ToString();
                    return secretNumString;
                }
                if (lower < upper)
                { 
                    secretNum = Int32.Parse(get_screteNum());

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
            string[] checkArray = { guess_text.Text, secretNum.ToString() };

            //Method to call RESTful API service
            string get_checked(){
                Uri completeCheckUri = get_checkNum.BindByPosition(baseUri, checkArray);
                WebClient channel = new WebClient();
                byte[] abc = channel.DownloadData(completeCheckUri);
                Stream strm = new MemoryStream(abc);
                DataContractSerializer obj = new DataContractSerializer(typeof(string));
                string checkNumString = obj.ReadObject(strm).ToString();
                return checkNumString;
            }

            if (isEntered)
            {
                attempt_num.Text = (guess_count++).ToString();
                try
                {
                    int guess_num = Int32.Parse(guess_text.Text);
                    if (guess_num < secretNum && guess_num >= Int32.Parse(lower_text.Text) && guess_num <= Int32.Parse(upper_text.Text))
                    {
                        num_reponse.Text = get_checked();
                    }
                    else if (guess_num > secretNum && guess_num >= Int32.Parse(lower_text.Text) && guess_num <= Int32.Parse(upper_text.Text))
                    {
                        num_reponse.Text = get_checked();
                    }
                    else if (guess_num == secretNum)
                    {
                        num_reponse.Text = get_checked();
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
