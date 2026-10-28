namespace LuQuangMinh_6551071053_VP103_LTTQ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpThongTinSach = new GroupBox();
            txtGiaTien = new TextBox();
            txtTenSach = new TextBox();
            txtMaSach = new TextBox();
            lblGiaTien = new Label();
            lblTenSach = new Label();
            lblMaSach = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            grpDanhSachSach = new GroupBox();
            dgvDuLieu = new DataGridView();
            grpThongTinSach.SuspendLayout();
            grpDanhSachSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDuLieu).BeginInit();
            SuspendLayout();
            // 
            // grpThongTinSach
            // 
            grpThongTinSach.Controls.Add(txtGiaTien);
            grpThongTinSach.Controls.Add(txtTenSach);
            grpThongTinSach.Controls.Add(txtMaSach);
            grpThongTinSach.Controls.Add(lblGiaTien);
            grpThongTinSach.Controls.Add(lblTenSach);
            grpThongTinSach.Controls.Add(lblMaSach);
            grpThongTinSach.Location = new Point(12, 12);
            grpThongTinSach.Name = "grpThongTinSach";
            grpThongTinSach.Size = new Size(250, 340);
            grpThongTinSach.TabIndex = 0;
            grpThongTinSach.TabStop = false;
            grpThongTinSach.Text = "Thông tin sách";
            // 
            // txtGiaTien
            // 
            txtGiaTien.Location = new Point(27, 283);
            txtGiaTien.Name = "txtGiaTien";
            txtGiaTien.Size = new Size(125, 27);
            txtGiaTien.TabIndex = 5;
            // 
            // txtTenSach
            // 
            txtTenSach.Location = new Point(27, 179);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.Size = new Size(125, 27);
            txtTenSach.TabIndex = 4;
            // 
            // txtMaSach
            // 
            txtMaSach.Location = new Point(27, 71);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new Size(125, 27);
            txtMaSach.TabIndex = 3;
            // 
            // lblGiaTien
            // 
            lblGiaTien.AutoSize = true;
            lblGiaTien.Location = new Point(27, 260);
            lblGiaTien.Name = "lblGiaTien";
            lblGiaTien.Size = new Size(63, 20);
            lblGiaTien.TabIndex = 2;
            lblGiaTien.Text = "Giá tiền:";
            // 
            // lblTenSach
            // 
            lblTenSach.AutoSize = true;
            lblTenSach.Location = new Point(27, 156);
            lblTenSach.Name = "lblTenSach";
            lblTenSach.Size = new Size(68, 20);
            lblTenSach.TabIndex = 1;
            lblTenSach.Text = "Tên sách:";
            // 
            // lblMaSach
            // 
            lblMaSach.AutoSize = true;
            lblMaSach.Location = new Point(27, 48);
            lblMaSach.Name = "lblMaSach";
            lblMaSach.Size = new Size(66, 20);
            lblMaSach.TabIndex = 0;
            lblMaSach.Text = "Mã sách:";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(317, 37);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(417, 37);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(517, 37);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(617, 37);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // grpDanhSachSach
            // 
            grpDanhSachSach.Controls.Add(dgvDuLieu);
            grpDanhSachSach.Location = new Point(268, 98);
            grpDanhSachSach.Name = "grpDanhSachSach";
            grpDanhSachSach.Size = new Size(520, 254);
            grpDanhSachSach.TabIndex = 5;
            grpDanhSachSach.TabStop = false;
            grpDanhSachSach.Text = "Danh sách sách";
            // 
            // dgvDuLieu
            // 
            dgvDuLieu.AllowUserToAddRows = false;
            dgvDuLieu.AllowUserToDeleteRows = false;
            dgvDuLieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDuLieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDuLieu.Location = new Point(6, 26);
            dgvDuLieu.MultiSelect = false;
            dgvDuLieu.Name = "dgvDuLieu";
            dgvDuLieu.ReadOnly = true;
            dgvDuLieu.RowHeadersWidth = 51;
            dgvDuLieu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDuLieu.Size = new Size(508, 216);
            dgvDuLieu.TabIndex = 0;
            dgvDuLieu.CellClick += dgvDuLieu_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 359);
            Controls.Add(grpDanhSachSach);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(grpThongTinSach);
            Name = "Form1";
            Text = "Quản lý Sách / Thư viện - VP103";
            grpThongTinSach.ResumeLayout(false);
            grpThongTinSach.PerformLayout();
            grpDanhSachSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDuLieu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpThongTinSach;
        private Label lblGiaTien;
        private Label lblTenSach;
        private Label lblMaSach;
        private TextBox txtGiaTien;
        private TextBox txtTenSach;
        private TextBox txtMaSach;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
        private GroupBox grpDanhSachSach;
        private DataGridView dgvDuLieu;
    }
}
