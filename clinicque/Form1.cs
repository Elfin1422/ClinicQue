using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinicque
{
    public partial class Form1 : Form
    {
        string name;
        double age = 0;
        string reason;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void namebox_TextChanged(object sender, EventArgs e)
        {
            name = namebox.Text;
        }

        private void reasonbox_TextChanged(object sender, EventArgs e)
        {
            reason = reasonbox.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
         }

        private void ClearBtn_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void agebox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
