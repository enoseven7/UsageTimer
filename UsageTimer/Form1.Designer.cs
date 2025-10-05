namespace UsageTimer
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            labelTime = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            notifyIcon1 = new NotifyIcon(components);
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            progressBar1 = new ProgressBar();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            progressBar2 = new ProgressBar();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Font = new Font("Creato Display", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTime.ForeColor = Color.White;
            labelTime.Location = new Point(12, 62);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(214, 29);
            labelTime.TabIndex = 0;
            labelTime.Text = "Total: 0d 0h 0m 0s";
            labelTime.Click += label1_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "PC Usage Tracker\r\n";
            notifyIcon1.Visible = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Creato Display", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(277, 42);
            label1.TabIndex = 1;
            label1.Text = "PC Usage Timer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Creato Display Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 101);
            label2.Name = "label2";
            label2.Size = new Size(374, 19);
            label2.TabIndex = 2;
            label2.Text = "A tracker to track how much time is spent on your PC.";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Creato Display Light", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 382);
            button1.Name = "button1";
            button1.Size = new Size(249, 56);
            button1.TabIndex = 3;
            button1.Text = "Reset Timer";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = Color.SpringGreen;
            progressBar1.Location = new Point(12, 227);
            progressBar1.Maximum = 86400;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(776, 23);
            progressBar1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Creato Display Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 264);
            label3.Name = "label3";
            label3.Size = new Size(136, 19);
            label3.TabIndex = 5;
            label3.Text = "Daily Progress Bar";
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.FromArgb(150, 200, 255);
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Creato Display Light", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel1.LinkColor = Color.FromArgb(150, 200, 255);
            linkLabel1.Location = new Point(12, 132);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(102, 23);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Github Link";
            linkLabel1.VisitedLinkColor = Color.FromArgb(150, 200, 255);
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // progressBar2
            // 
            progressBar2.ForeColor = Color.Aquamarine;
            progressBar2.Location = new Point(12, 298);
            progressBar2.Maximum = 3600;
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(776, 23);
            progressBar2.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Creato Display Thin", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 336);
            label4.Name = "label4";
            label4.Size = new Size(141, 19);
            label4.TabIndex = 8;
            label4.Text = "Hourly Progress Bar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Creato Display Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(524, 9);
            label5.Name = "label5";
            label5.Size = new Size(264, 14);
            label5.TabIndex = 9;
            label5.Text = "(Minizing or closing the app will move it to the tray.)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(progressBar2);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(progressBar1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelTime);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private NotifyIcon notifyIcon1;
        private Label label1;
        private Label label2;
        private Button button1;
        private ProgressBar progressBar1;
        private Label label3;
        private LinkLabel linkLabel1;
        private ProgressBar progressBar2;
        private Label label4;
        private Label label5;
    }
}
