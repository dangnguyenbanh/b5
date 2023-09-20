using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_1
{
    public partial class Form1 : Form
    {
        ErrorProvider errorProvider;
        public Form1()
        {
            errorProvider = new ErrorProvider();
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age;
            string s;
            s = "My name is: " + txtYourName.Text + "\n";
            age = DateTime.Now.Year - Convert.ToInt32(txtYear.Text);
            s = s + "Age: " + age.ToString();
            MessageBox.Show(s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtYourName.Clear();
            txtYear.Clear();
            txtYourName.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider.SetError(ctr, "You must enter Your Name");
            else
                this.errorProvider.Clear();

        }
        private void frmBT_FormChosing(object sender,FormClosingEventArgs e)
        {
            DialogResult r;
            r=MessageBox.Show("Bạn có muốn thoát ?", "Thoát",MessageBoxButtons.YesNo,MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if(ctr.Text.Length == 0 && !Char.IsDigit(ctr.Text[ctr.Text.Length - 11]))
                this.errorProvider.SetError(ctr, "this is not avalid number");
            else
                this.errorProvider.Clear();

        }

    }
}
