using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace joseess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Geográficas")
            {
                label1.Visible = true;
                label2.Visible = true;
                comboBox3.Visible = true;
                comboBox4.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;

            }
            else {
                label1.Visible = false;
                label2.Visible = false;
                comboBox3.Visible = false;
                comboBox4.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender , EventArgs e)
        {
            var temp = comboBox1.SelectedItem;
            comboBox1.SelectedItem = comboBox2.SelectedItem;
            comboBox2.SelectedItem = temp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
