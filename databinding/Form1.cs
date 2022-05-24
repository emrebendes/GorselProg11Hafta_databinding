using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace databinding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kutuphaneDataSet.deneme' table. You can move, or remove it, as needed.
            this.denemeTableAdapter.Fill(this.kutuphaneDataSet.deneme);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            denemeTableAdapter.Update(kutuphaneDataSet);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource= denemeTableAdapter.ourSearch("%" + textBox5.Text + "%");
        }

      
    }
}
