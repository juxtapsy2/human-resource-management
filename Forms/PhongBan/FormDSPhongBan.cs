using QLNS_EntityFramework.BS_Layer;
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

namespace QLNS_EntityFramework.Forms.PhongBan
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
                while (columns.Count > 5)
                {
                    columns.RemoveAt(columns.Count - 1);
                }
                dgvPHONGBAN.AutoResizeColumns();
                txtMaPB.Enabled = false;
                txtTenPB.Enabled = false;
                cmbTrPhong.Enabled = false;
                dtpNgayNhanChuc.Enabled = false;
                txtDiadiem.Enabled = false;
                BL_NhanVien dbNV = new BL_NhanVien();
                cmbTrPhong.DataSource = dbNV.GetAllMaNV();
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
            // Thứ tự dòng hiện hành 
            int r = dgvPHONGBAN.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            this.txtMaPB.Text =
            dgvPHONGBAN.Rows[r].Cells[0].Value.ToString();
            this.txtTenPB.Text =
            dgvPHONGBAN.Rows[r].Cells[1].Value.ToString();
            this.cmbTrPhong.Text =
            dgvPHONGBAN.Rows[r].Cells[2].Value.ToString();
            dtpNgayNhanChuc.Value = DateTime.Parse(dgvPHONGBAN.Rows[r].Cells[3].Value.ToString());
            this.txtDiadiem.Text =
            dgvPHONGBAN.Rows[r].Cells[4].Value.ToString();
        }

        private void btnXuatExcelPB_Click(object sender, EventArgs e)
        {
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
            BL_PhongBan bL_PhongBan = new BL_PhongBan();
            string MaPB = txtMaPB.Text;
            string TenPB = txtTenPB.Text.Trim();
            string TrPhong = cmbTrPhong.Text.Trim();
            DateTime ngnhanchuc = dtpNgayNhanChuc.Value;
            string Diadiem = txtDiadiem.Text.Trim();
            if (bL_PhongBan.CapNhatPhongBan(MaPB, TenPB, TrPhong, ngnhanchuc, Diadiem))
            {
                MessageBox.Show("Thêm phòng ban thành công!");
                LoadDataPB();
            }
            else
            {
                MessageBox.Show("Thêm phòng ban thất bại!");
            }
            LoadDataPB();
        }

        private void btnXoaPB_Click(object sender, EventArgs e)
        {
            BL_PhongBan dbPB = new BL_PhongBan();
            if (dbPB.XoaPhongBan(txtMaPB.Text.ToString()))
            {
                MessageBox.Show("Đã xóa xong!");
            }
            else
            {
                MessageBox.Show("Không thể xóa Phòng ban này !");
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
