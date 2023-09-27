using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2
{
    public partial class Form1 : Form
    {
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btndangky;
        private TextBox txttendangnhap;
        private TextBox txtdiachigmail;
        private TextBox txtmatkhau;
        private ErrorProvider errorProvider1;
        private IContainer components;
        private TextBox txtxnmatkhau;
        private Label label5;
        private object txtXacNhan;

        public Form1()
        {
            InitializeComponent();
        }
        public static bool IsEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            return Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttendangnhap_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btndangky = new System.Windows.Forms.Button();
            this.txttendangnhap = new System.Windows.Forms.TextBox();
            this.txtdiachigmail = new System.Windows.Forms.TextBox();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.txtxnmatkhau = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorProvider1.SetIconAlignment(this.label1, System.Windows.Forms.ErrorIconAlignment.TopRight);
            this.label1.Location = new System.Drawing.Point(61, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorProvider1.SetIconAlignment(this.label2, System.Windows.Forms.ErrorIconAlignment.TopRight);
            this.label2.Location = new System.Drawing.Point(61, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa chỉ gmail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Xác nhận mật khẩu";
            // 
            // btndangky
            // 
            this.btndangky.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangky.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.errorProvider1.SetIconAlignment(this.btndangky, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProvider1.SetIconPadding(this.btndangky, 5);
            this.btndangky.Location = new System.Drawing.Point(260, 260);
            this.btndangky.Name = "btndangky";
            this.btndangky.Size = new System.Drawing.Size(119, 33);
            this.btndangky.TabIndex = 4;
            this.btndangky.Text = "Đăng ký";
            this.btndangky.UseVisualStyleBackColor = true;
            this.btndangky.Click += new System.EventHandler(this.btndangky_Click);
            // 
            // txttendangnhap
            // 
            this.txttendangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttendangnhap.Location = new System.Drawing.Point(238, 56);
            this.txttendangnhap.Name = "txttendangnhap";
            this.txttendangnhap.Size = new System.Drawing.Size(183, 24);
            this.txttendangnhap.TabIndex = 5;
            this.txttendangnhap.TextChanged += new System.EventHandler(this.txttendangnhap_TextChanged);
            // 
            // txtdiachigmail
            // 
            this.txtdiachigmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiachigmail.Location = new System.Drawing.Point(238, 100);
            this.txtdiachigmail.Name = "txtdiachigmail";
            this.txtdiachigmail.Size = new System.Drawing.Size(183, 24);
            this.txtdiachigmail.TabIndex = 6;
            this.txtdiachigmail.TextChanged += new System.EventHandler(this.txtdiachigmail_TextChanged);
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmatkhau.Location = new System.Drawing.Point(238, 147);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(183, 24);
            this.txtmatkhau.TabIndex = 7;
            this.txtmatkhau.TextChanged += new System.EventHandler(this.txtmatkhau_TextChanged);
            // 
            // txtxnmatkhau
            // 
            this.txtxnmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtxnmatkhau.Location = new System.Drawing.Point(238, 200);
            this.txtxnmatkhau.Multiline = true;
            this.txtxnmatkhau.Name = "txtxnmatkhau";
            this.txtxnmatkhau.Size = new System.Drawing.Size(183, 27);
            this.txtxnmatkhau.TabIndex = 8;
            this.txtxnmatkhau.TextChanged += new System.EventHandler(this.txtxnmatkhau_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.errorProvider1.SetIconAlignment(this.label5, System.Windows.Forms.ErrorIconAlignment.TopRight);
            this.label5.Location = new System.Drawing.Point(219, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "ĐĂNG KÝ TÀI KHOẢN";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(623, 305);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtxnmatkhau);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.txtdiachigmail);
            this.Controls.Add(this.txttendangnhap);
            this.Controls.Add(this.btndangky);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void txttendangnhap_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(ctr, "Tên đăng nhập là bắt buộc");
            else
                this.errorProvider1.Clear();
        }

        private void txtdiachigmail_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(ctr, "Địa chỉ email là bắt buộc");
            else if (IsEmail(txtdiachigmail.Text) == false)
                this.errorProvider1.SetError(ctr, "Địa chỉ email không đúng định dạng");
            else
                this.errorProvider1.Clear();
        }

        private void txtmatkhau_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(ctr, "Mật khẩu là bắt buộc");
            else
                this.errorProvider1.Clear();
        }

        private void txtxnmatkhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void btndangky_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txttendangnhap.Text))
                MessageBox.Show("Tên đăng nhập không được để trống");
            else if (string.IsNullOrWhiteSpace(txtdiachigmail.Text))
                MessageBox.Show("Địa chỉ email không được để trống");
            else if (IsEmail(txtdiachigmail.Text) == false)
                MessageBox.Show("Địa chỉ email không đúng định dạng");
            else if (string.IsNullOrWhiteSpace(txtmatkhau.Text))
                MessageBox.Show("Mật khẩu không được để trống");
            else if (String.Compare(txtmatkhau.Text, txtxnmatkhau.Text, false) != 0)
            {


                MessageBox.Show("Xác nhận mật khẩu không đúng");
            }
            else
            {
                string s;
                s = "Tên đăng nhập: " + txttendangnhap.Text + "\n";
                s = s + "Địa chỉ email: " + txtdiachigmail.Text + "\n";
                s = s + "Mật khẩu: " + txtmatkhau.Text + "\n";
                MessageBox.Show(s);
            }
        }
        private void txtXacNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                if (string.IsNullOrWhiteSpace(txttendangnhap.Text))
                    MessageBox.Show("Tên đăng nhập không được để trống");
                else if (string.IsNullOrWhiteSpace(txtdiachigmail.Text))
                    MessageBox.Show("Địa chỉ email không được để trống");
                else if (IsEmail(txtdiachigmail.Text) == false)
                    MessageBox.Show("Địa chỉ email không đúng định dạng");
                else if (string.IsNullOrWhiteSpace(txtmatkhau.Text))
                    MessageBox.Show("Mật khẩu không được để trống");
                else if (String.Compare(txtmatkhau.Text, txtxnmatkhau.Text, false) != 0)
                    MessageBox.Show("Xác nhận mật khẩu không đúng");
                else
                {
                    string s;
                    s = "Tên đăng nhập: " + txttendangnhap.Text + "\n";
                    s = s + "Địa chỉ email: " + txtdiachigmail.Text + "\n";
                    s = s + "Mật khẩu: " + txtmatkhau.Text + "\n";
                    MessageBox.Show(s);
                }
            }
        }
    }

}
