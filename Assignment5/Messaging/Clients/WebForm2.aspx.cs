using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clients
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        bool purge = false;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void purgeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (purgeCheckBox.Checked)
            {
                purge = true;
            }
            else
            {
                purge = false;
            }
        }

        protected void receiverID_TextChanged(object sender, EventArgs e)
        {

        }

        protected void receiveButton_Click(object sender, EventArgs e)
        {
            string receiverId = receiverID.Text;
            ServiceReference1.Service1Client proxy = new ServiceReference1.Service1Client();
            string[] response = proxy.receiveMsg(receiverId, purge);
            MessageText.Text = "";

            int index = 0;
            foreach (string message in response)
            {
                MessageText.Text += message;
                MessageText.Text += "\n";

                if (index % 3 == 2)
                {
                    MessageText.Text += "\n";
                }
                index++;
            }
        }

        protected void MessageText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}