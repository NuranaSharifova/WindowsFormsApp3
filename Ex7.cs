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
    public partial class Ex7 : Form
    {
        public Ex7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime day = new DateTime();
            day = DateTime.Parse(textBox1.Text);
            DateTime dayNow = DateTime.Now;
            TimeSpan Tday = day- dayNow;
            if (day> dayNow)
            {
               if (radioButton1.Checked)
                    textBox2.Text = (Tday.TotalDays / 365).ToString();
               
                if (radioButton2.Checked)
                {
                    textBox2.Text = (Tday.TotalDays / 30).ToString();
                }
                if (radioButton3.Checked)
                {
                    textBox2.Text = ((int)Tday.TotalDays).ToString();
                }
                if (radioButton4.Checked)
                {
                    textBox2.Text = ((int)Tday.TotalMinutes).ToString();
                }
                if (radioButton5.Checked)
                {
                    textBox2.Text = ((int)Tday.TotalSeconds).ToString();
                }
            }
            else
            {
                textBox2.Text = "This day has passed!";
            }
        }

       
    }
}
