using QLNS_ADO.NET.BS_Layer;
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

namespace QLNS_ADO.NET.Forms.HopDong
{
    public partial class FormHopDong : Form
    {
        System.Data.DataTable dtHopDong = null;
        BL_HopDong dbHD = new BL_HopDong();
        public FormHopDong()
        {
            InitializeComponent();
        }
        void LoadDataHD()
        {
            try
            {
                dtHopDong = new System.Data.DataTable();
                dtHopDong.Clear();
                DataSet ds = dbHD.LayHopDong();
                dtHopDong = ds.Tables[0];
                dgvHOPDONG.DataSource = dtHopDong;
                dgvHOPDONG.AutoResizeColumns();
                txtMaHD.Enabled = false;
                txtThoiHan.Enabled = false;
                cmbViTri.Enabled = false;
                cmbViTri.DataSource = dbHD.GetAllViTri();
                richtxtMoTa.Enabled = false;
                dgvHOPDONG_CellClick(null, null);
            }
            catch (SqlException)
            {

            }
        }

        private void dgvHOPDONG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = dgvHOPDONG.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            this.txtMaHD.Text =
            dgvHOPDONG.Rows[r].Cells[0].Value.ToString();
            this.txtThoiHan.Text =
            dgvHOPDONG.Rows[r].Cells[1].Value.ToString();
            this.cmbViTri.Text =
            dgvHOPDONG.Rows[r].Cells[2].Value.ToString();
            this.richtxtMoTa.Text =
            dgvHOPDONG.Rows[r].Cells[3].Value.ToString();
        }

        private void FormHopDong_Load(object sender, EventArgs e)
        {
            LoadDataHD();
        }

        private void btnXuatExcelHD_Click(object sender, EventArgs e)
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
            bL_Export.ExportToExcel("HOPDONG", saveFileDialog);
        }

        private void btnSuaHD_Click(object sender, EventArgs e)
        {
            txtMaHD.Enabled = true;
            txtThoiHan.Enabled = true;
            cmbViTri.Enabled = true;
            richtxtMoTa.Enabled = true;
        }

        private void btnLuuHD_Click(object sender, EventArgs e)
        {
            BL_HopDong hopDong = new BL_HopDong();
            string MaHD = txtMaHD.Text;
            int ThoiHan = Convert.ToInt32(txtThoiHan.Text);
            string ViTri = cmbViTri.Text;
            string MoTa = richtxtMoTa.Text;
            if (hopDong.CapNhatHopDong(MaHD, ThoiHan, ViTri, MoTa))
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadDataHD();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }

        private void dgvHOPDONG_SelectionChanged(object sender, EventArgs e)
        {
            dgvHOPDONG.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (dgvHOPDONG.SelectedCells.Count > 0)
            {
                int rowIndex = dgvHOPDONG.SelectedCells[0].RowIndex;
                dgvHOPDONG.Rows[rowIndex].Selected = true;
            }
        }
    }
}
