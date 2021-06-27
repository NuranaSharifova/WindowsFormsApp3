using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Ex6 : Form
    {
        string days;
        public Ex6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                DateTime day = new DateTime();
                day = DateTime.Parse(textBox1.Text);

                days = day.ToString("dddd").ToUpper();
              
            }
            MessageBox.Show($"It is{days}", "Information", MessageBoxButtons.OK);
        }
    }
}
