using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAndAwaitDemo
{
    using System.Threading;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
           // string result = await WaitAsynchronouslyAsync();

            string result = await WaitSynchronouslyAsync();


            textBox1.Text += result;
        }

        private async Task<string> WaitSynchronouslyAsync()
        {
            await Task.Delay(10000);
            return "Finished";
        }

        private async Task<string> WaitAsynchronouslyAsync()
        {
            Thread.Sleep(10000);
            return "Finished";
        }


    }
}
