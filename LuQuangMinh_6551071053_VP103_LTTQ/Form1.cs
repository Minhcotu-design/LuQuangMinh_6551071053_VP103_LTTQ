
using LuQuangMinh_6551071053_VP103_LTTQ.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
   

namespace LuQuangMinh_6551071053_VP103_LTTQ
{
    public partial class Form1 : Form
    {
        private DbContextOptions<DuLieuContext>? _options;
        private bool _coKetNoi = false;
        private string? _maDangChon = null;
        public Form1()
        {
            InitializeComponent();
            dgvDuLieu.CellClick -= dgvDuLieu_CellClick;
            dgvDuLieu.CellClick += dgvDuLieu_CellClick;
            CapNhatNut();
            try
            {
                var config = new ConfigurationBuilder()
                    .SetBasePath(AppContext.BaseDirectory)
                    .AddJsonFile("appsettings.json")
                    .AddJsonFile("appsettings.Development.json", optional: true)
                    .Build();
                string? connectionString = config.GetConnectionString("DefaultConnection");
                if (string.IsNullOrWhiteSpace(connectionString))
                {
                    MessageBox.Show("Thiếu chuỗi kết nối.");
                    return;
                }
                var optionsBuilder = new DbContextOptionsBuilder<DuLieuContext>();
                optionsBuilder.UseSqlServer(connectionString);
                _options = optionsBuilder.Options;
                using var db = new DuLieuContext(_options);
                bool canConnect = db.Database.CanConnect();
                if (!canConnect)
                {
                    MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu.");
                    return;
                }
                _coKetNoi = true;
                LoadDuLieu();
                CapNhatNut();
            }
            catch (Exception ex)
            {
                _coKetNoi = false;
                MessageBox.Show(
                    "Lỗi kết nối: " + ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                CapNhatNut();
            }
        }
        private void LoadDuLieu()
        {
            if (!_coKetNoi || _options == null) return;
            using var db = new DuLieuContext(_options);

            var danhSach = db.CongViecs
                .AsNoTracking()
                .ToList();

            dgvDuLieu.DataSource = danhSach;
            dgvDuLieu.ClearSelection();

            _maDangChon = null;

            CapNhatNut();
        }

        private void dgvDuLieu_CellClick(
            object? sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (!_coKetNoi)
                return;

            if (!dgvDuLieu.Columns.Contains("MaSach") ||
                !dgvDuLieu.Columns.Contains("TenSach") ||
                !dgvDuLieu.Columns.Contains("GiaTien"))
            {
                MessageBox.Show(
                    "Tên cột trên DataGridView không khớp với code.");
                return;
            }

            var row = dgvDuLieu.Rows[e.RowIndex];
            if (row.Cells["MaSach"].Value == null) return;
            _maDangChon = row.Cells["MaSach"].Value?.ToString();
            txtMaSach.Text = row.Cells["MaSach"].Value?.ToString();
            txtTenSach.Text = row.Cells["TenSach"].Value?.ToString();
            txtGiaTien.Text = row.Cells["GiaTien"].Value?.ToString();
            CapNhatNut();
        }


        private void CapNhatNut()
        {
            btnThem.Enabled = _coKetNoi;
            btnSua.Enabled = _coKetNoi && !string.IsNullOrWhiteSpace(_maDangChon);
            btnXoa.Enabled = _coKetNoi && !string.IsNullOrWhiteSpace(_maDangChon);
            btnThoat.Enabled = true;
        }

        private bool KiemTraNhap()
        {
            if (string.IsNullOrWhiteSpace(txtMaSach.Text))
            {
                MessageBox.Show("Mã sách không được để trống.");
                txtMaSach.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTenSach.Text))
            {
                MessageBox.Show("Tên sách không được để trống.");
                txtTenSach.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtGiaTien.Text))
            {
                MessageBox.Show("Giá tiền không được để trống.");
                txtGiaTien.Focus();
                return false;
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraNhap())
                return;

            try
            {
                using var db = new DuLieuContext(_options!);

                string maSach = txtMaSach.Text.Trim();

                bool biTrungMa = db.CongViecs
                    .Any(x => x.MaSach == maSach);

                if (biTrungMa)
                {
                    MessageBox.Show(
                        "Mã sách đã tồn tại. Vui lòng nhập mã khác.",
                        "Trùng mã sách",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtMaSach.Focus();
                    txtMaSach.SelectAll();
                    return;
                }

                var dulieu = new CongViec
                {
                    MaSach = maSach,
                    TenSach = txtTenSach.Text.Trim(),
                    GiaTien = txtGiaTien.Text.Trim()
                };

                db.CongViecs.Add(dulieu);
                db.SaveChanges();

                XoaNhap();
                LoadDuLieu();

                MessageBox.Show(
                    "Thêm thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi thêm: " + ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void XoaNhap()
        {
            txtGiaTien.Clear();
            txtTenSach.Clear();
            txtMaSach.Clear();
            _maDangChon = null;
            dgvDuLieu.ClearSelection();
            CapNhatNut();
        }


        private void btnSua_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_maDangChon))
            {
                MessageBox.Show("Vui lòng chọn sách cần sửa.");
                return;
            }
            if (!KiemTraNhap())
                return;

            try
            {
                using var db = new DuLieuContext(_options!);
                var dulieu = db.CongViecs
                    .FirstOrDefault(x => x.MaSach == _maDangChon);
                if (dulieu == null)
                {
                    MessageBox.Show("Sách không tồn tại.");
                    return;
                }
                dulieu.TenSach = txtTenSach.Text.Trim();
                dulieu.GiaTien = txtGiaTien.Text.Trim();
                db.SaveChanges();
                XoaNhap();
                LoadDuLieu();
                MessageBox.Show(
                    "Sửa thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi sửa: " + ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void btnXoa_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_maDangChon))
            {
                MessageBox.Show("Vui lòng chọn sách cần xóa.");
                return;
            }
            DialogResult ketQua = MessageBox.Show("Muốn xóa cuốn sách này không?", "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (ketQua != DialogResult.Yes)
                return;

            try
            {
                using var db = new DuLieuContext(_options!);
                var dulieu = db.CongViecs.FirstOrDefault(x => x.MaSach == _maDangChon);
                if (dulieu == null)
                {
                    MessageBox.Show("Sách không tồn tại.");
                    return;
                }
                db.CongViecs.Remove(dulieu);
                db.SaveChanges();
                XoaNhap();
                LoadDuLieu();
                MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show(
                "Bạn có muốn thoát không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
                Application.Exit();
        }
    }
}
