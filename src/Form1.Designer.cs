namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            panel2 = new Panel();
            button3 = new Button();
            label4 = new Label();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            checkBox1 = new CheckBox();
            button2 = new Button();
            button1 = new Button();
            label5 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(linkLabel2);
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(24, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 358);
            panel2.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Control;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(53, 222);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 4;
            button3.Text = "CLAIM";
            button3.UseVisualStyleBackColor = false;
            button3.Click += btnClaimClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(5, 145);
            label4.Name = "label4";
            label4.Size = new Size(213, 63);
            label4.TabIndex = 3;
            label4.Text = "LAST CHANCE TO GET\r\n 20% OFF ON ANY\r\nPURCHASE!";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(-2, 304);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(90, 25);
            linkLabel2.TabIndex = 2;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Job Portal";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(-2, 329);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(140, 25);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Terms of Service";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 0);
            label3.Name = "label3";
            label3.Size = new Size(186, 128);
            label3.TabIndex = 0;
            label3.Text = "🛍️";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(27, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(475, 358);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 217);
            label2.Name = "label2";
            label2.Size = new Size(143, 25);
            label2.TabIndex = 6;
            label2.Text = "I am not a robot";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.Location = new Point(48, 220);
            checkBox1.Name = "checkBox1";
            checkBox1.RightToLeft = RightToLeft.No;
            checkBox1.Size = new Size(22, 21);
            checkBox1.TabIndex = 5;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(264, 280);
            button2.Name = "button2";
            button2.Size = new Size(161, 49);
            button2.TabIndex = 4;
            button2.Text = "Return";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnReturnClicked;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(48, 280);
            button1.Name = "button1";
            button1.Size = new Size(161, 49);
            button1.TabIndex = 3;
            button1.Text = "Delete Account";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnDeleteAccountClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 155);
            label5.Name = "label5";
            label5.Size = new Size(306, 25);
            label5.TabIndex = 2;
            label5.Text = "Enter reason for departure (required!)";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            label5.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 31);
            label1.Name = "label1";
            label1.Size = new Size(358, 84);
            label1.TabIndex = 1;
            label1.Text = "We are sorry to see\r\nyou go!";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click_1;
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.ControlText;
            textBox1.Location = new Point(48, 183);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(377, 28);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Account Deletion Portal";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private TextBox textBox1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private Label label3;
        private Button button1;
        private Label label4;
        private Button button2;
        private Button button3;
        private Label label5;
        private CheckBox checkBox1;
        private Label label2;
    }
}
