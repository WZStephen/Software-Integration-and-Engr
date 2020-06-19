using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;


namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Perform_btn_Click(object sender, EventArgs e)
        {
            string file_string;
            Stopwatch timer = new Stopwatch(); ;

            try{
                //read the number of input thread from text field
                int threads = Int32.Parse(threads_tf.Text);

                //set the status text(starting)
                status_label.Text = "In process, please wait!";

                //read the file into string
                using (StreamReader fileReader =
                    new StreamReader(FileUpload1.PostedFile.InputStream)){
                    file_string = fileReader.ReadToEnd();
                }

                //start to perform single thread computing and measure the time                
                timer.Start();
                List<KeyValuePair<string, int>> singleThread = utilities.NameNode(file_string, 1);
                timer.Stop();
                singleExeTime_label.Text = timer.ElapsedMilliseconds + " ms";

                //start to perform multi-thread computing and measure the time
                timer.Restart();
                List<KeyValuePair<string, int>> muti_thread = utilities.NameNode(file_string, threads);
                timer.Stop();
                multiExeTime_label.Text = timer.ElapsedMilliseconds + " ms";

                //reset the timer
                timer.Reset();

                // display the returned result
                string printResult = "";
                foreach (KeyValuePair<string, int> curPair in muti_thread){
                    printResult += "String: " + curPair.Key + "---Count: " + curPair.Value + "<br/>";
                }
                result_label.Text = printResult;
                result_label.ForeColor = Color.Green;

                //set the status text(finished)
                status_label.Text = "DONE!";
                status_label.ForeColor = Color.Green;

                // clean the fileupload buff
                FileUpload1.Attributes.Clear();
            }
            catch (Exception ex){
                result_label.Text = "Error, Please input all required resources!";
                result_label.ForeColor= Color.Red;
            }
        }
    }
}