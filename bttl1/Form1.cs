using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bttl1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textA_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length > 0 && !char.IsDigit(ctr.Text, ctr.Text.Length - 1))
                this.errorProvider1.SetError(textA, "Khong phai so");
            else
                this.errorProvider1.Clear();
        }
        private void textA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                String message = "Khong phai so nhap lai";
                String title = "Thong bao";
                MessageBox.Show(message, title);
            }
        }

        private void textB_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length > 0 && !char.IsDigit(ctr.Text, ctr.Text.Length - 1))
                this.errorProvider1.SetError(textB, "Khong phai so");
            else
                this.errorProvider1.Clear();
        }
        private void textB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                String message = "Khong phai so nhap lai";
                String title = "Thong bao";
                MessageBox.Show(message, title);
            }
        }

        private void textketqua_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length > 0 && !char.IsDigit(ctr.Text, ctr.Text.Length - 1))
                this.errorProvider1.SetError(textketqua, "Khong phai so");
            else
                this.errorProvider1.Clear();
        }
        private void textketqua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                String message = "Khong phai so nhap lai";
                String title = "Thong bao";
                MessageBox.Show(message, title);
            }
        }
        //private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    DialogResult r;
        //    r = MessageBox.Show("Bạn có muốn thoát ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        //    if (r == DialogResult.No) e.Cancel = true;
        //}

        private void butcong_Click(object sender, EventArgs e)
        {
            if(double.TryParse(textA.Text,out double a ) && double.TryParse(textB.Text,out double b))
                {
                double ketqua = a + b;
                textketqua.Text = ketqua.ToString();
            }

        }

        private void btntru_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textA.Text, out double a) && double.TryParse(textB.Text, out double b))
            {
                double ketqua = a - b;
                textketqua.Text = ketqua.ToString();
            }

        }

        private void btnx_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textA.Text, out double a) && double.TryParse(textB.Text, out double b))
            {
                double ketqua = a * b;
                textketqua.Text = ketqua.ToString();
            }
        }

        private void btnchia_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textA.Text, out double a) && double.TryParse(textB.Text, out double b))
            {
                double ketqua = a / b;
                textketqua.Text = ketqua.ToString();
            }
        }
    } 
}
