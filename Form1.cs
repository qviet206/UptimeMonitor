using System;
using System.Drawing;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GUI_UPTIME_MONITOR
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private static readonly HttpClient client = new HttpClient { Timeout = TimeSpan.FromSeconds(5) };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvMonitor.ColumnCount = 5;
            dgvMonitor.Columns[0].Name = "ID";
            dgvMonitor.Columns[1].Name = "URL";
            dgvMonitor.Columns[2].Name = "STATUS";
            dgvMonitor.Columns[3].Name = "RESPONCE TIME";
            dgvMonitor.Columns[4].Name = "LAST CHECK";
            timer.Interval = 5000;
            timer.Tick += async (s, ev) => await CheckAllWebsites();
        }
        private async void Timer_Tick_Event(object sender, EventArgs e)
        {
            await CheckAllWebsites();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int id = dgvMonitor.Rows.Count + 1;
            dgvMonitor.Rows.Add(id, txtUrl.Text, "...", "-", "-");
            txtUrl.Clear();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }
        private async Task CheckAllWebsites()
        {
            foreach (DataGridViewRow row in dgvMonitor.Rows)
            {
                if (!row.IsNewRow && row.Cells[1].Value != null)
                {
                    string url = row.Cells[1].Value.ToString();
                    if (!url.StartsWith("http")) url = "http://" + url;

                    var watch = System.Diagnostics.Stopwatch.StartNew();
                    bool isUp = await CheckWebsite(url);
                    watch.Stop();

                    row.Cells[2].Value = isUp ? "UP" : "DOWN";
                    row.Cells[3].Value = isUp ? $"{watch.ElapsedMilliseconds} ms" : "-";
                    row.Cells[4].Value = DateTime.Now.ToString("HH:mm:ss");
                    row.Cells[2].Style.ForeColor = isUp ? Color.Lime : Color.Red;
                }
            }
        }
        private async Task<bool> CheckWebsite(string url)
        {
            using (HttpClient localClient = new HttpClient())
            {
                try
                {
                    localClient.Timeout = TimeSpan.FromSeconds(5);

                    if (!url.StartsWith("http")) url = "http://" + url;
                    var response = await localClient.GetAsync(url, HttpCompletionOption.ResponseHeadersRead);

                    return response.IsSuccessStatusCode;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}