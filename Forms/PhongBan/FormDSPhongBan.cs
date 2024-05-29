using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS_LinQ.Forms.PhongBan
{
    public partial class FormDSPhongBan : Form
    {
        BL_PhongBan dbPB = new BL_PhongBan();
        public FormDSPhongBan()
        {
            InitializeComponent();
        }
        public void LoadDataPB()
        {
            try
            {
                dgvPHONGBAN.DataSource = dbPB.LayPhongBan();
                DataGridViewColumnCollection columns = dgvPHONGBAN.Columns;
                while (columns.Count > 8)
                {
                    columns.RemoveAt(columns.Count - 1);
                }
                dgvPHONGBAN.AutoResizeColumns();
                txtMaPB.Enabled = false;
                txtTenPB.Enabled = false;
                cmbTrPhong.Enabled = false;
                txtDiadiem.Enabled = false;
                dtpNgayNhanChuc.Enabled = false;
                BL_NhanVien nhanVien = new BL_NhanVien();
                cmbTrPhong.DataSource = nhanVien.GetAllMaNV();
                dtpNgayNhanChuc.Format = DateTimePickerFormat.Custom;
                dtpNgayNhanChuc.CustomFormat = "dd/MM/yyyy";
                
                dgvPHONGBAN_CellClick(null, null);
            }
            catch (SqlException)
            {

            }
        }
        private void FormDSPhongBan_Load(object sender, EventArgs e)
        {
            LoadDataPB();
        }

        private void dgvPHONGBAN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvPHONGBAN.CurrentCell.RowIndex;
            this.txtMaPB.Text =
            dgvPHONGBAN.Rows[r].Cells[0].Value.ToString();
            this.txtTenPB.Text =
            dgvPHONGBAN.Rows[r].Cells[1].Value.ToString();
            this.cmbTrPhong.Text =
            dgvPHONGBAN.Rows[r].Cells[2].Value.ToString();
            this.dtpNgayNhanChuc.Value = DateTime.Parse(
            dgvPHONGBAN.Rows[r].Cells[3].Value.ToString());
            this.txtDiadiem.Text = dgvPHONGBAN.Rows[r].Cells[4].Value.ToString();
        }

        private void btnXuatExcelPB_Click(object sender, EventArgs e)
        {
            // Create a new SaveFileDialog to prompt the user to choose a destination folder and filename
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            BL_Export bL_Export = new BL_Export();
            bL_Export.ExportToExcelPhongBan(saveFileDialog);
        }

        private void btnSuaPB_Click(object sender, EventArgs e)
        {
            txtMaPB.Enabled = false;
            txtTenPB.Enabled = true;
            cmbTrPhong.Enabled = true;
            txtDiadiem.Enabled = true;
            dtpNgayNhanChuc.Enabled = true;
        }

        private void btnLuuPB_Click(object sender, EventArgs e)
        {
            BL_PhongBan phongBan = new BL_PhongBan();
            string MaPB = txtMaPB.Text;
            string TenPB = txtTenPB.Text.Trim();
            string TrPhong = cmbTrPhong.Text.Trim();
            DateTime ngnhanchuc = dtpNgayNhanChuc.Value;
            string Diadiem = txtDiadiem.Text.Trim();

            if (phongBan.CapNhatPhongBan(MaPB, TenPB, TrPhong, ngnhanchuc, Diadiem))
            {
                MessageBox.Show("Sửa thành công!");
                LoadDataPB();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }

        private void btnXoaPB_Click(object sender, EventArgs e)
        {
            if (dbPB.XoaPhongBan(txtMaPB.Text))
            {
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Bị lỗi chưa xử lý được");
            };
            LoadDataPB();
        }

        private void dgvPHONGBAN_SelectionChanged(object sender, EventArgs e)
        {
            dgvPHONGBAN.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (dgvPHONGBAN.SelectedCells.Count > 0)
            {
                int rowIndex = dgvPHONGBAN.SelectedCells[0].RowIndex;
                dgvPHONGBAN.Rows[rowIndex].Selected = true;
            }
        }
    }
}
