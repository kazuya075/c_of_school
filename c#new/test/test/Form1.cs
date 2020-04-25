using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        Class1 class1;
        public Form1()
        {
            InitializeComponent();

            class1 = new Class1(this);
           


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public void AddListItem(string item)
        {
            listBox1.Items.Add(item);
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
