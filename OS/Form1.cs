namespace OS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_f1_Click(object sender, EventArgs e)
        {
            // sending data to an external file 
            StreamWriter file = new StreamWriter("crs_reg.txt");
            file.WriteLine("Name: " + NameBox.Text);
            file.WriteLine("age: " + AgeBox.Text);

            // sending radiobutton values
            if (r2.Checked)
                file.WriteLine("Gender: Male");

            else file.WriteLine("Gender: Female");

            // sending address value
            file.WriteLine("Address: " + combx.Text);

            // sending checkboxes values
            string chkstring = "";
            bool first_element = true;
            foreach (var chk in chklst1.CheckedItems)
            {
                if (first_element)
                    chkstring += chk;
                else chkstring += " - " + chk;
                first_element = false;
            }



            file.WriteLine("Courses: " + chkstring);

            // closing the writer streamfile
            file.Flush();
            file.Close();

            // openning form2
            string s = NameBox.Text;
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }
    }
}