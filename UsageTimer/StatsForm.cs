using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace UsageTimer
{
    public partial class StatsForm : Form
    {
        private string statsFile = Path.Combine(Application.UserAppDataPath, "usage.json");

        public StatsForm()
        {
            InitializeComponent();
            LoadChart();
        }

        private void LoadChart()
        {
            var chart = new Chart { Dock = DockStyle.Fill };
            var chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);

            var series = new Series("Usage (minutes)");
            series.ChartType = SeriesChartType.Column;

            if (File.Exists(statsFile))
            {
                string json = File.ReadAllText(statsFile);
                var data = JsonSerializer.Deserialize<Dictionary<string, double>>(json);

                foreach (var entry in data.OrderBy(x => x.Key))
                    series.Points.AddXY(entry.Key, entry.Value);
            }

            chart.Series.Add(series);
            this.Controls.Add(chart);
        }

        private void StatsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
