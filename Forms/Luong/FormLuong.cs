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
using QLNS_EntityFramework.BS_Layer;
using QLNS_EntityFramework.Forms.Report;

namespace QLNS_EntityFramework.Forms.Luong
{
    public partial class FormLuong : Form
    {
        BL_Luong dbLg = new BL_Luong();
        public FormLuong()
        {
            InitializeComponent();
        }
        public void LoadDataLuong()
        {
            try
            {
                dgvLuong.DataSource = dbLg.LayLuong();
                DataGridViewColumnCollection columns = dgvLuong.Columns;
                while (columns.Count > 4)
                {
                    columns.RemoveAt(columns.Count - 1);
                }
                dgvLuong.AutoResizeColumns();
                txtMaNVLg.Enabled = false;
                txtLuongCung.Enabled = false;
                txtNgayNghi.Enabled = false;
                txtPhuCap.Enabled = false;
                dgvLuong_CellClick(null, null);
            }
            catch (SqlException)
            {

            }
        }
        private void FormLuong_Load(object sender, EventArgs e)
        {
            LoadDataLuong();
        }

        private void dgvLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvLuong.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            this.txtMaNVLg.Text =
            dgvLuong.Rows[r].Cells[0].Value.ToString();
            this.txtLuongCung.Text =
            dgvLuong.Rows[r].Cells[1].Value.ToString();
            this.txtNgayNghi.Text =
            dgvLuong.Rows[r].Cells[2].Value.ToString();
            this.txtPhuCap.Text =
            dgvLuong.Rows[r].Cells[3].Value.ToString();
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            FormReportLuong formReportLuong = new FormReportLuong();
            formReportLuong.ShowDialog();
        }

        private void btnSuaLuong_Click(object sender, EventArgs e)
        {
            txtMaNVLg.Enabled = true;
            txtLuongCung.Enabled = true;
            txtPhuCap.Enabled = true;
            txtNgayNghi.Enabled = true;
        }

        private void btnLuuLuong_Click(object sender, EventArgs e)
        {
            string MaNVLg = txtMaNVLg.Text;
            int LuongCung = Convert.ToInt32(txtLuongCung.Text);
            int Phucap = Convert.ToInt32(txtPhuCap.Text);
            int NgayNghi = Convert.ToInt32(txtNgayNghi.Text);
            if (dbLg.CapNhatLuong(MaNVLg, LuongCung, NgayNghi, Phucap))
            {
                MessageBox.Show("Sửa thành công !");
                LoadDataLuong();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void dgvLuong_SelectionChanged(object sender, EventArgs e)
        {
            dgvLuong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (dgvLuong.SelectedCells.Count > 0)
            {
                int rowIndex = dgvLuong.SelectedCells[0].RowIndex;
                dgvLuong.Rows[rowIndex].Selected = true;
            }
        }
    }
}
