using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İzleme_Lİstesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        showlar show=new showlar();
            
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            show.showhazırla();
            foreach (var item in show.dizi)
            {
                listBox1.Items.Add(item);
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string b;
            b = textBox1.Text;
            show.showekle(b);
            show.showhazırla();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            show.showhazırla();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            show.izlenmedurumu(textBox2.Text);
            
        }
    }
}
