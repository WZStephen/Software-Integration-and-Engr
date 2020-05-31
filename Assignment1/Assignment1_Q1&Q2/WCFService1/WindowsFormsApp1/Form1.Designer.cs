namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lower_text = new System.Windows.Forms.TextBox();
            this.upper_text = new System.Windows.Forms.TextBox();
            this.guess_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.generate_btn = new System.Windows.Forms.Button();
            this.play_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.response_label = new System.Windows.Forms.Label();
            this.attempt_num = new System.Windows.Forms.Label();
            this.num_reponse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lower_text
            // 
            this.lower_text.Location = new System.Drawing.Point(271, 139);
            this.lower_text.Name = "lower_text";
            this.lower_text.Size = new System.Drawing.Size(100, 21);
            this.lower_text.TabIndex = 0;
            this.lower_text.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // upper_text
            // 
            this.upper_text.Location = new System.Drawing.Point(480, 139);
            this.upper_text.Name = "upper_text";
            this.upper_text.Size = new System.Drawing.Size(100, 21);
            this.upper_text.TabIndex = 1;
            // 
            // guess_text
            // 
            this.guess_text.Location = new System.Drawing.Point(271, 228);
            this.guess_text.Name = "guess_text";
            this.guess_text.Size = new System.Drawing.Size(100, 21);
            this.guess_text.TabIndex = 2;
            this.guess_text.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lower Limit";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(189, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Make a Guess";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(406, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Upper Limit";
            // 
            // generate_btn
            // 
            this.generate_btn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generate_btn.Location = new System.Drawing.Point(599, 137);
            this.generate_btn.Name = "generate_btn";
            this.generate_btn.Size = new System.Drawing.Size(164, 23);
            this.generate_btn.TabIndex = 7;
            this.generate_btn.Text = "Generate a Secret Number";
            this.generate_btn.UseVisualStyleBackColor = true;
            this.generate_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // play_btn
            // 
            this.play_btn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_btn.Location = new System.Drawing.Point(397, 225);
            this.play_btn.Name = "play_btn";
            this.play_btn.Size = new System.Drawing.Size(75, 23);
            this.play_btn.TabIndex = 8;
            this.play_btn.Text = "Play";
            this.play_btn.UseVisualStyleBackColor = true;
            this.play_btn.Click += new System.EventHandler(this.play_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(217, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(411, 27);
            this.label5.TabIndex = 9;
            this.label5.Text = "WELCOME TO Number Guessing Game";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(362, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Attempts:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(362, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "The number is";
            this.label6.Click += new System.EventHandler(this.label6_Click_2);
            // 
            // response_label
            // 
            this.response_label.AutoSize = true;
            this.response_label.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.response_label.ForeColor = System.Drawing.Color.Red;
            this.response_label.Location = new System.Drawing.Point(362, 388);
            this.response_label.Name = "response_label";
            this.response_label.Size = new System.Drawing.Size(0, 15);
            this.response_label.TabIndex = 12;
            // 
            // attempt_num
            // 
            this.attempt_num.AutoSize = true;
            this.attempt_num.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attempt_num.Location = new System.Drawing.Point(425, 302);
            this.attempt_num.Name = "attempt_num";
            this.attempt_num.Size = new System.Drawing.Size(0, 15);
            this.attempt_num.TabIndex = 13;
            // 
            // num_reponse
            // 
            this.num_reponse.AutoSize = true;
            this.num_reponse.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_reponse.Location = new System.Drawing.Point(444, 347);
            this.num_reponse.Name = "num_reponse";
            this.num_reponse.Size = new System.Drawing.Size(0, 15);
            this.num_reponse.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 450);
            this.Controls.Add(this.num_reponse);
            this.Controls.Add(this.attempt_num);
            this.Controls.Add(this.response_label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.play_btn);
            this.Controls.Add(this.generate_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guess_text);
            this.Controls.Add(this.upper_text);
            this.Controls.Add(this.lower_text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lower_text;
        private System.Windows.Forms.TextBox upper_text;
        private System.Windows.Forms.TextBox guess_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button generate_btn;
        private System.Windows.Forms.Button play_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label response_label;
        private System.Windows.Forms.Label attempt_num;
        private System.Windows.Forms.Label num_reponse;
    }
}

