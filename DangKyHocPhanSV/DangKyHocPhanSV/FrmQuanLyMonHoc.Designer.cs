﻿
namespace DangKyHocPhanSV
{
    partial class FrmQuanLyMonHoc
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
            this.cbbCTDT = new System.Windows.Forms.ComboBox();
            this.panel = new System.Windows.Forms.Panel();
            this.btnXoaMH = new System.Windows.Forms.Button();
            this.btnTimMH = new System.Windows.Forms.Button();
            this.txtMaMonHoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnThemMonHoc = new System.Windows.Forms.Button();
            this.txtNhapTenMH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNhapMaMH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNhapTinChi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThemMHDT = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNhapMaMHDT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnXoaMHDT = new System.Windows.Forms.Button();
            this.txtMaMHDT = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTimMHDT = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbbNganh = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbbMonHoc = new System.Windows.Forms.ComboBox();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbCTDT
            // 
            this.cbbCTDT.FormattingEnabled = true;
            this.cbbCTDT.Location = new System.Drawing.Point(189, 72);
            this.cbbCTDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbCTDT.Name = "cbbCTDT";
            this.cbbCTDT.Size = new System.Drawing.Size(182, 24);
            this.cbbCTDT.TabIndex = 107;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Snow;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.btnXoaMH);
            this.panel.Controls.Add(this.btnTimMH);
            this.panel.Controls.Add(this.txtMaMonHoc);
            this.panel.Controls.Add(this.label5);
            this.panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel.Location = new System.Drawing.Point(9, 57);
            this.panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(404, 61);
            this.panel.TabIndex = 97;
            // 
            // btnXoaMH
            // 
            this.btnXoaMH.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnXoaMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaMH.Location = new System.Drawing.Point(316, 17);
            this.btnXoaMH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoaMH.Name = "btnXoaMH";
            this.btnXoaMH.Size = new System.Drawing.Size(80, 35);
            this.btnXoaMH.TabIndex = 70;
            this.btnXoaMH.Text = "Xóa ";
            this.btnXoaMH.UseVisualStyleBackColor = false;
            this.btnXoaMH.Click += new System.EventHandler(this.btnXoaMH_Click);
            // 
            // btnTimMH
            // 
            this.btnTimMH.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnTimMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimMH.Location = new System.Drawing.Point(234, 17);
            this.btnTimMH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimMH.Name = "btnTimMH";
            this.btnTimMH.Size = new System.Drawing.Size(77, 35);
            this.btnTimMH.TabIndex = 59;
            this.btnTimMH.Text = "Tìm kiếm";
            this.btnTimMH.UseVisualStyleBackColor = false;
            this.btnTimMH.Click += new System.EventHandler(this.btnTimMH_Click);
            // 
            // txtMaMonHoc
            // 
            this.txtMaMonHoc.BackColor = System.Drawing.SystemColors.Menu;
            this.txtMaMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMonHoc.Location = new System.Drawing.Point(122, 21);
            this.txtMaMonHoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaMonHoc.Name = "txtMaMonHoc";
            this.txtMaMonHoc.Size = new System.Drawing.Size(98, 26);
            this.txtMaMonHoc.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SeaShell;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã môn học";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(617, 626);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(142, 35);
            this.btnReturn.TabIndex = 100;
            this.btnReturn.Text = "Quay trở lại";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnThemMonHoc
            // 
            this.btnThemMonHoc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnThemMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMonHoc.Location = new System.Drawing.Point(250, 131);
            this.btnThemMonHoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThemMonHoc.Name = "btnThemMonHoc";
            this.btnThemMonHoc.Size = new System.Drawing.Size(142, 35);
            this.btnThemMonHoc.TabIndex = 59;
            this.btnThemMonHoc.Text = "Thêm ";
            this.btnThemMonHoc.UseVisualStyleBackColor = false;
            this.btnThemMonHoc.Click += new System.EventHandler(this.btnThemMonHoc_Click);
            // 
            // txtNhapTenMH
            // 
            this.txtNhapTenMH.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNhapTenMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapTenMH.Location = new System.Drawing.Point(139, 54);
            this.txtNhapTenMH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNhapTenMH.Name = "txtNhapTenMH";
            this.txtNhapTenMH.Size = new System.Drawing.Size(182, 26);
            this.txtNhapTenMH.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SeaShell;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 62;
            this.label3.Text = "Tên Môn Học";
            // 
            // txtNhapMaMH
            // 
            this.txtNhapMaMH.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNhapMaMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapMaMH.Location = new System.Drawing.Point(139, 15);
            this.txtNhapMaMH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNhapMaMH.Name = "txtNhapMaMH";
            this.txtNhapMaMH.Size = new System.Drawing.Size(182, 26);
            this.txtNhapMaMH.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SeaShell;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Môn Học";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtNhapTinChi);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnThemMonHoc);
            this.panel1.Controls.Add(this.txtNhapTenMH);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNhapMaMH);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(8, 121);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 177);
            this.panel1.TabIndex = 99;
            // 
            // txtNhapTinChi
            // 
            this.txtNhapTinChi.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNhapTinChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapTinChi.Location = new System.Drawing.Point(139, 90);
            this.txtNhapTinChi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNhapTinChi.Name = "txtNhapTinChi";
            this.txtNhapTinChi.Size = new System.Drawing.Size(182, 26);
            this.txtNhapTinChi.TabIndex = 65;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.SeaShell;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 93);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 19);
            this.label8.TabIndex = 64;
            this.label8.Text = "Số Tín Chỉ";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 1);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(407, 36);
            this.label4.TabIndex = 96;
            this.label4.Text = "Quản lý Môn Học";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(435, 1);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(408, 36);
            this.label2.TabIndex = 101;
            this.label2.Text = "Quản lý Môn Học - Đào Tạo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThemMHDT
            // 
            this.btnThemMHDT.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnThemMHDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMHDT.Location = new System.Drawing.Point(247, 131);
            this.btnThemMHDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThemMHDT.Name = "btnThemMHDT";
            this.btnThemMHDT.Size = new System.Drawing.Size(142, 35);
            this.btnThemMHDT.TabIndex = 59;
            this.btnThemMHDT.Text = "Thêm ";
            this.btnThemMHDT.UseVisualStyleBackColor = false;
            this.btnThemMHDT.Click += new System.EventHandler(this.btnThemMHDT_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.SeaShell;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 74);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 19);
            this.label6.TabIndex = 66;
            this.label6.Text = "Chương trình đào tạo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.SeaShell;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 41);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 19);
            this.label7.TabIndex = 62;
            this.label7.Text = "Môn Học ";
            // 
            // txtNhapMaMHDT
            // 
            this.txtNhapMaMHDT.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNhapMaMHDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapMaMHDT.Location = new System.Drawing.Point(189, 9);
            this.txtNhapMaMHDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNhapMaMHDT.Name = "txtNhapMaMHDT";
            this.txtNhapMaMHDT.Size = new System.Drawing.Size(182, 26);
            this.txtNhapMaMHDT.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.SeaShell;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã MH - DT";
            // 
            // btnXoaMHDT
            // 
            this.btnXoaMHDT.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnXoaMHDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaMHDT.Location = new System.Drawing.Point(343, 17);
            this.btnXoaMHDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoaMHDT.Name = "btnXoaMHDT";
            this.btnXoaMHDT.Size = new System.Drawing.Size(68, 35);
            this.btnXoaMHDT.TabIndex = 70;
            this.btnXoaMHDT.Text = "Xóa ";
            this.btnXoaMHDT.UseVisualStyleBackColor = false;
            this.btnXoaMHDT.Click += new System.EventHandler(this.btnXoaMHDT_Click);
            // 
            // txtMaMHDT
            // 
            this.txtMaMHDT.BackColor = System.Drawing.SystemColors.Menu;
            this.txtMaMHDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMHDT.Location = new System.Drawing.Point(123, 20);
            this.txtMaMHDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaMHDT.Name = "txtMaMHDT";
            this.txtMaMHDT.Size = new System.Drawing.Size(126, 26);
            this.txtMaMHDT.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Snow;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnXoaMHDT);
            this.panel3.Controls.Add(this.btnTimMHDT);
            this.panel3.Controls.Add(this.txtMaMHDT);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(428, 57);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(416, 61);
            this.panel3.TabIndex = 102;
            // 
            // btnTimMHDT
            // 
            this.btnTimMHDT.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnTimMHDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimMHDT.Location = new System.Drawing.Point(253, 17);
            this.btnTimMHDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimMHDT.Name = "btnTimMHDT";
            this.btnTimMHDT.Size = new System.Drawing.Size(84, 35);
            this.btnTimMHDT.TabIndex = 59;
            this.btnTimMHDT.Text = "Tìm kiếm";
            this.btnTimMHDT.UseVisualStyleBackColor = false;
            this.btnTimMHDT.Click += new System.EventHandler(this.btnTimMHDT_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.SeaShell;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 20);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 22);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mã MH - DT";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Snow;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cbbNganh);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.cbbMonHoc);
            this.panel2.Controls.Add(this.cbbCTDT);
            this.panel2.Controls.Add(this.btnThemMHDT);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtNhapMaMHDT);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(428, 121);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 177);
            this.panel2.TabIndex = 103;
            // 
            // cbbNganh
            // 
            this.cbbNganh.FormattingEnabled = true;
            this.cbbNganh.Location = new System.Drawing.Point(189, 104);
            this.cbbNganh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbNganh.Name = "cbbNganh";
            this.cbbNganh.Size = new System.Drawing.Size(182, 24);
            this.cbbNganh.TabIndex = 110;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.SeaShell;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 106);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 19);
            this.label11.TabIndex = 109;
            this.label11.Text = "Ngành";
            // 
            // cbbMonHoc
            // 
            this.cbbMonHoc.FormattingEnabled = true;
            this.cbbMonHoc.Location = new System.Drawing.Point(189, 41);
            this.cbbMonHoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbMonHoc.Name = "cbbMonHoc";
            this.cbbMonHoc.Size = new System.Drawing.Size(182, 24);
            this.cbbMonHoc.TabIndex = 108;
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Location = new System.Drawing.Point(9, 301);
            this.dgvDanhSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersVisible = false;
            this.dgvDanhSach.RowHeadersWidth = 51;
            this.dgvDanhSach.RowTemplate.Height = 24;
            this.dgvDanhSach.Size = new System.Drawing.Size(834, 320);
            this.dgvDanhSach.TabIndex = 104;
            // 
            // FrmQuanLyMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 680);
            this.Controls.Add(this.dgvDanhSach);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmQuanLyMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Môn Học";
            this.Load += new System.EventHandler(this.FrmQuanLyMonHoc_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbCTDT;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnXoaMH;
        private System.Windows.Forms.Button btnTimMH;
        private System.Windows.Forms.TextBox txtMaMonHoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnThemMonHoc;
        private System.Windows.Forms.TextBox txtNhapTenMH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNhapMaMH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNhapTinChi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThemMHDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNhapMaMHDT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnXoaMHDT;
        private System.Windows.Forms.TextBox txtMaMHDT;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnTimMHDT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbbNganh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbbMonHoc;
        private System.Windows.Forms.DataGridView dgvDanhSach;
    }
}