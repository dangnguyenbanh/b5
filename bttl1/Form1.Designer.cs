namespace bttl1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.butcong = new System.Windows.Forms.Button();
            this.btntru = new System.Windows.Forms.Button();
            this.btnx = new System.Windows.Forms.Button();
            this.btnchia = new System.Windows.Forms.Button();
            this.textA = new System.Windows.Forms.TextBox();
            this.textB = new System.Windows.Forms.TextBox();
            this.textketqua = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "A=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "kết quả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "B=";
            // 
            // butcong
            // 
            this.butcong.Location = new System.Drawing.Point(92, 234);
            this.butcong.Name = "butcong";
            this.butcong.Size = new System.Drawing.Size(75, 23);
            this.butcong.TabIndex = 3;
            this.butcong.Text = "+";
            this.butcong.UseVisualStyleBackColor = true;
            this.butcong.Click += new System.EventHandler(this.butcong_Click);
            // 
            // btntru
            // 
            this.btntru.Location = new System.Drawing.Point(220, 234);
            this.btntru.Name = "btntru";
            this.btntru.Size = new System.Drawing.Size(75, 23);
            this.btntru.TabIndex = 4;
            this.btntru.Text = "-";
            this.btntru.UseVisualStyleBackColor = true;
            this.btntru.Click += new System.EventHandler(this.btntru_Click);
            // 
            // btnx
            // 
            this.btnx.Location = new System.Drawing.Point(333, 234);
            this.btnx.Name = "btnx";
            this.btnx.Size = new System.Drawing.Size(75, 23);
            this.btnx.TabIndex = 5;
            this.btnx.Text = "x";
            this.btnx.UseVisualStyleBackColor = true;
            this.btnx.Click += new System.EventHandler(this.btnx_Click);
            // 
            // btnchia
            // 
            this.btnchia.Location = new System.Drawing.Point(443, 234);
            this.btnchia.Name = "btnchia";
            this.btnchia.Size = new System.Drawing.Size(75, 23);
            this.btnchia.TabIndex = 6;
            this.btnchia.Text = "/";
            this.btnchia.UseVisualStyleBackColor = true;
            this.btnchia.Click += new System.EventHandler(this.btnchia_Click);
            // 
            // textA
            // 
            this.textA.Location = new System.Drawing.Point(179, 56);
            this.textA.Name = "textA";
            this.textA.Size = new System.Drawing.Size(100, 20);
            this.textA.TabIndex = 7;
            this.textA.TextChanged += new System.EventHandler(this.textA_TextChanged);
            // 
            // textB
            // 
            this.textB.Location = new System.Drawing.Point(443, 48);
            this.textB.Name = "textB";
            this.textB.Size = new System.Drawing.Size(100, 20);
            this.textB.TabIndex = 8;
            this.textB.TextChanged += new System.EventHandler(this.textB_TextChanged);
            // 
            // textketqua
            // 
            this.textketqua.Location = new System.Drawing.Point(179, 120);
            this.textketqua.Name = "textketqua";
            this.textketqua.Size = new System.Drawing.Size(100, 20);
            this.textketqua.TabIndex = 9;
            this.textketqua.TextChanged += new System.EventHandler(this.textketqua_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 335);
            this.Controls.Add(this.textketqua);
            this.Controls.Add(this.textB);
            this.Controls.Add(this.textA);
            this.Controls.Add(this.btnchia);
            this.Controls.Add(this.btnx);
            this.Controls.Add(this.btntru);
            this.Controls.Add(this.butcong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butcong;
        private System.Windows.Forms.Button btntru;
        private System.Windows.Forms.Button btnx;
        private System.Windows.Forms.Button btnchia;
        private System.Windows.Forms.TextBox textA;
        private System.Windows.Forms.TextBox textB;
        private System.Windows.Forms.TextBox textketqua;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

