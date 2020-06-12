using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clients
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void receiverID_TextChanged(object sender, EventArgs e)
        {

        }

        protected void senderID_TextChanged(object sender, EventArgs e)
        {

        }

        protected void messageText_TextChanged(object sender, EventArgs e)
        {

        }

        protected void sendMessageButton_Click(object sender, EventArgs e)
        {
            string senderId = senderID.Text;
            string receiverId = receiverID.Text;
            string msg = messageText.Text;

            ServiceReference1.Service1Client proxy = new ServiceReference1.Service1Client();
            proxy.sendMsg(senderId, receiverId, msg);
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}