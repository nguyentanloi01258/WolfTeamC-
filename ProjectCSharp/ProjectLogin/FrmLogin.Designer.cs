﻿
namespace ProjectLogin
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.ckNhoMatKhau = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbEye = new System.Windows.Forms.PictureBox();
            this.pbHEye = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHEye)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDangNhap.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Location = new System.Drawing.Point(286, 407);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(160, 60);
            this.btnDangNhap.TabIndex = 0;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.BtnDangNhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.OrangeRed;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(498, 407);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(160, 60);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(211, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tài Khoản";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTaiKhoan.Location = new System.Drawing.Point(221, 154);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(522, 47);
            this.txtTaiKhoan.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(212, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật Khẩu";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMatKhau.Location = new System.Drawing.Point(221, 269);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(522, 47);
            this.txtMatKhau.TabIndex = 5;
            // 
            // ckNhoMatKhau
            // 
            this.ckNhoMatKhau.AutoSize = true;
            this.ckNhoMatKhau.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckNhoMatKhau.ForeColor = System.Drawing.Color.White;
            this.ckNhoMatKhau.Location = new System.Drawing.Point(221, 334);
            this.ckNhoMatKhau.Name = "ckNhoMatKhau";
            this.ckNhoMatKhau.Size = new System.Drawing.Size(182, 34);
            this.ckNhoMatKhau.TabIndex = 6;
            this.ckNhoMatKhau.Text = "Nhớ mật khẩu";
            this.ckNhoMatKhau.UseVisualStyleBackColor = true;
            this.ckNhoMatKhau.CheckedChanged += new System.EventHandler(this.CkNhoMatKhau_CheckedChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label3.Location = new System.Drawing.Point(1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 522);
            this.label3.TabIndex = 7;
            this.label3.Text = "Đăng Nhập";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pbEye
            // 
            this.pbEye.BackColor = System.Drawing.Color.White;
            this.pbEye.Image = ((System.Drawing.Image)(resources.GetObject("pbEye.Image")));
            this.pbEye.Location = new System.Drawing.Point(711, 231);
            this.pbEye.Name = "pbEye";
            this.pbEye.Size = new System.Drawing.Size(32, 32);
            this.pbEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbEye.TabIndex = 8;
            this.pbEye.TabStop = false;
            this.pbEye.Click += new System.EventHandler(this.PbEye_Click);
            // 
            // pbHEye
            // 
            this.pbHEye.BackColor = System.Drawing.Color.White;
            this.pbHEye.Image = ((System.Drawing.Image)(resources.GetObject("pbHEye.Image")));
            this.pbHEye.Location = new System.Drawing.Point(711, 231);
            this.pbHEye.Name = "pbHEye";
            this.pbHEye.Size = new System.Drawing.Size(32, 32);
            this.pbHEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbHEye.TabIndex = 9;
            this.pbHEye.TabStop = false;
            this.pbHEye.Click += new System.EventHandler(this.PbHEye_Click);
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(108)))), ((int)(((byte)(232)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(755, 523);
            this.ControlBox = false;
            this.Controls.Add(this.pbHEye);
            this.Controls.Add(this.pbEye);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ckNhoMatKhau);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHEye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.CheckBox ckNhoMatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbEye;
        private System.Windows.Forms.PictureBox pbHEye;
    }
}