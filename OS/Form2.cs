using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // reading the file to get user's data
            StreamReader file2 = new StreamReader("crs_reg.txt");
            string file_content = file2.ReadToEnd();
            richTextBox1.Text = file_content;
            file2.Close();
        }
    }
}
