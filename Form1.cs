using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sınav_Ortalama_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vize1;
            int vize2;
            int final;
            double ortalama;
            vize1=Convert.ToInt32(textBox2.Text);
            vize2 = Convert.ToInt32(textBox3.Text);
            final = Convert.ToInt32(textBox4.Text);
            ortalama = (vize1 * 0.2 + vize2 * 0.2) + (final * 0.6);
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(textBox3.Text);
            listBox4.Items.Add(textBox4.Text);
            listBox5.Items.Add(ortalama);
            if(ortalama>=50)
            {
                MessageBox.Show(textBox1.Text + " " + "dersten GEÇTİ");
                listBox6.Items.Add(textBox1.Text);
            }
            else
            {
                MessageBox.Show(textBox1.Text + " " + "dersten KALDI");
                listBox7.Items.Add(textBox1.Text);
            }

        }
    }
}
