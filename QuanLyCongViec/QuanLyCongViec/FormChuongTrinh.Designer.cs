namespace QuanLyCongViec
{
    partial class FormChuongTrinh
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTienDoCV = new System.Windows.Forms.Button();
            this.btnBaoCaoCV = new System.Windows.Forms.Button();
            this.btnQuanLyNhanVien = new System.Windows.Forms.Button();
            this.btnQuanLyCV = new System.Windows.Forms.Button();
            this.btnThongKeCV = new System.Windows.Forms.Button();
            this.dgv_FormMain = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FormMain)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(910, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnQuanLyCV);
            this.panel1.Controls.Add(this.btnThongKeCV);
            this.panel1.Controls.Add(this.btnBaoCaoCV);
            this.panel1.Controls.Add(this.btnQuanLyNhanVien);
            this.panel1.Controls.Add(this.btnTienDoCV);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 407);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ CÔNG VIỆC";
            // 
            // btnTienDoCV
            // 
            this.btnTienDoCV.Location = new System.Drawing.Point(18, 200);
            this.btnTienDoCV.Name = "btnTienDoCV";
            this.btnTienDoCV.Size = new System.Drawing.Size(262, 42);
            this.btnTienDoCV.TabIndex = 3;
            this.btnTienDoCV.Text = "Tiến Độ Công Việc";
            this.btnTienDoCV.UseVisualStyleBackColor = true;
            // 
            // btnBaoCaoCV
            // 
            this.btnBaoCaoCV.Location = new System.Drawing.Point(18, 321);
            this.btnBaoCaoCV.Name = "btnBaoCaoCV";
            this.btnBaoCaoCV.Size = new System.Drawing.Size(262, 42);
            this.btnBaoCaoCV.TabIndex = 5;
            this.btnBaoCaoCV.Text = "Báo Cáo Công Việc";
            this.btnBaoCaoCV.UseVisualStyleBackColor = true;
            // 
            // btnQuanLyNhanVien
            // 
            this.btnQuanLyNhanVien.Location = new System.Drawing.Point(18, 79);
            this.btnQuanLyNhanVien.Name = "btnQuanLyNhanVien";
            this.btnQuanLyNhanVien.Size = new System.Drawing.Size(262, 42);
            this.btnQuanLyNhanVien.TabIndex = 1;
            this.btnQuanLyNhanVien.Text = "Quản Lý Nhân Viên";
            this.btnQuanLyNhanVien.UseVisualStyleBackColor = true;
            this.btnQuanLyNhanVien.Click += new System.EventHandler(this.btnQuanLyNhanVien_Click);
            // 
            // btnQuanLyCV
            // 
            this.btnQuanLyCV.Location = new System.Drawing.Point(18, 140);
            this.btnQuanLyCV.Name = "btnQuanLyCV";
            this.btnQuanLyCV.Size = new System.Drawing.Size(262, 42);
            this.btnQuanLyCV.TabIndex = 2;
            this.btnQuanLyCV.Text = "Quản Lý Công Việc";
            this.btnQuanLyCV.UseVisualStyleBackColor = true;
            // 
            // btnThongKeCV
            // 
            this.btnThongKeCV.Location = new System.Drawing.Point(18, 258);
            this.btnThongKeCV.Name = "btnThongKeCV";
            this.btnThongKeCV.Size = new System.Drawing.Size(262, 42);
            this.btnThongKeCV.TabIndex = 4;
            this.btnThongKeCV.Text = "Thống Kê Công Việc";
            this.btnThongKeCV.UseVisualStyleBackColor = true;
            // 
            // dgv_FormMain
            // 
            this.dgv_FormMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_FormMain.Location = new System.Drawing.Point(318, 31);
            this.dgv_FormMain.Name = "dgv_FormMain";
            this.dgv_FormMain.RowHeadersWidth = 51;
            this.dgv_FormMain.RowTemplate.Height = 24;
            this.dgv_FormMain.Size = new System.Drawing.Size(580, 405);
            this.dgv_FormMain.TabIndex = 1;
            // 
            // FormChuongTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 448);
            this.Controls.Add(this.dgv_FormMain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormChuongTrinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChuongTrinh";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormChuongTrinh_FormClosed);
            this.Load += new System.EventHandler(this.FormChuongTrinh_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FormMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQuanLyCV;
        private System.Windows.Forms.Button btnThongKeCV;
        private System.Windows.Forms.Button btnBaoCaoCV;
        private System.Windows.Forms.Button btnQuanLyNhanVien;
        private System.Windows.Forms.Button btnTienDoCV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_FormMain;
    }
}