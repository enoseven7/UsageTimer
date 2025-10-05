using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace UsageTimer
{
    public partial class Form1 : Form
    {
        private DateTime startTime;
        private double totalSeconds = 0;
        private string saveFile = "time_log.txt";
        public Form1()
        {
            InitializeComponent();

            this.Text = "PC Usage Tracker";

            if (File.Exists(saveFile))
                totalSeconds = double.Parse(File.ReadAllText(saveFile));

            startTime = DateTime.Now;


            timer1.Interval = 1000;
            timer1.Enabled = true;

            linkLabel1.Links.Add(0, linkLabel1.Text.Length, "https://github.com/enoseven7");

            // Tray icon restore event
            notifyIcon1.DoubleClick += (s, e) =>
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                notifyIcon1.Visible = false;
            };

            ContextMenuStrip trayMenu = new ContextMenuStrip();
            trayMenu.Items.Add("Open", null, (s, e) =>
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                notifyIcon1.Visible = false;
            });
            trayMenu.Items.Add("Exit", null, (s, e) => Application.Exit());

            notifyIcon1.ContextMenuStrip = trayMenu;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = e.Link.LinkData as string;
            if (!string.IsNullOrEmpty(url))
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            totalSeconds++;


            int days = (int)(totalSeconds / 86400);
            int hours = (int)((totalSeconds % 86400) / 3600);
            int minutes = (int)((totalSeconds % 3600) / 60);
            int seconds = (int)(totalSeconds % 60);

            labelTime.Text = $"Total: {days}d {hours}h {minutes}m {seconds}s";
            notifyIcon1.Text = $"Total: {days}d {hours}h {minutes}m {seconds}s";

            if (seconds == 0)
                File.WriteAllText(saveFile, totalSeconds.ToString());

            int secondsToDay = (int)(totalSeconds % 86400);
            int secondsToHour = (int)(totalSeconds % 3600);
            progressBar1.Value = Math.Min(secondsToDay, progressBar1.Maximum);
            progressBar2.Value = Math.Min(secondsToHour, progressBar2.Maximum);

            this.Text = $"PC Usage Tracker - Total: {days}d {hours}h {minutes}m {seconds}s";
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            File.WriteAllText("window_pos.txt", $"{this.Left},{this.Top}");
            base.OnFormClosing(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            if (File.Exists("window_pos.txt"))
            {
                var pos = File.ReadAllText("window_pos.txt").Split(',');
                this.Left = int.Parse(pos[0]);
                this.Top = int.Parse(pos[1]);
            }
            base.OnLoad(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to reset your tracked time? This cannot be undone.",
                "Confirm Reset",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                totalSeconds = 0;
                File.WriteAllText(saveFile, "0");
                labelTime.Text = "Total: 0d 0h 0m 0s";
                progressBar1.Value = 0;
                progressBar2.Value = 0;
            }

        }

        private void SetAutoStart()
        {
            string runKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
            string appName = "PCUsageTracker"; // name that will appear in startup
            string exePath = "\"" + Application.ExecutablePath + "\""; // full path to your app

            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(runKey, true))
            {
                key.SetValue(appName, exePath); // add to startup
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetAutoStart();
        }
    }
}
