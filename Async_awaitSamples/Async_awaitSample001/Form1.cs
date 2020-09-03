using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Async_awaitSample001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Task<string> intergerTask = TaskMethodAsync();

            textBox1.Text = $"我是第二行 {DateTime.Now.ToString("hh:mm:ss.fff")}";

            string result = await intergerTask;
            textBox1.Text += result;

        }

        async Task<string> TaskMethodAsync()
        {
            await Task.Delay(5000);
            return $" 我是第一個被執行的 {DateTime.Now.ToString("hh:mm:ss.fff")}";
        }
    }
}
