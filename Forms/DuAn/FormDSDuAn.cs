﻿using QLNS_ADO.NET.BS_Layer;
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

namespace QLNS_ADO.NET
{
    public partial class FormDSDuAn : Form
    {
        System.Data.DataTable dtDuAn = null;
        BL_DuAn dbDA = new BL_DuAn();
        public FormDSDuAn()
        {
            InitializeComponent();
        }
        void LoadDataDA()
        {
            try
            {   BL_PhongBan phongBan = new BL_PhongBan();
                dtDuAn = new System.Data.DataTable();
                dtDuAn.Clear();
                DataSet ds = dbDA.LayDuAn();
                dtDuAn = ds.Tables[0];
                dgvDUAN.DataSource = dtDuAn;
                dgvDUAN.AutoResizeColumns();
                txtMaDA.Enabled = false;
                txtTenDA.Enabled = false;
                txtDiaDiemDA.Enabled = false;
                cmbPhongDA.Enabled = false;
                cmbPhongDA.DataSource = phongBan.GetAllMaPB();
                dgvDUAN_CellClick(null, null);
            }
            catch (SqlException)
            {

            }
        }
        private void FormDanhSachDuAn_Load(object sender, EventArgs e)
        {
            LoadDataDA();
        }
        private void dgvDUAN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = dgvDUAN.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            this.txtMaDA.Text =
            dgvDUAN.Rows[r].Cells[0].Value.ToString();
            this.txtTenDA.Text =
            dgvDUAN.Rows[r].Cells[1].Value.ToString();
            this.txtDiaDiemDA.Text =
            dgvDUAN.Rows[r].Cells[2].Value.ToString();
            this.cmbPhongDA.Text =
            dgvDUAN.Rows[r].Cells[3].Value.ToString();
        }
        private void btnXuatExcelDA_Click(object sender, EventArgs e)
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
            bL_Export.ExportToExcel("DUAN", saveFileDialog);
        }

        private void btnSuaDA_Click(object sender, EventArgs e)
        {
            txtMaDA.Enabled = true;
            txtTenDA.Enabled = true;
            txtDiaDiemDA.Enabled = true;
            cmbPhongDA.Enabled = true;
        }

        private void btnLuuDA_Click(object sender, EventArgs e)
        {
            BL_DuAn duAn = new BL_DuAn();
            string MaDA = txtMaDA.Text;
            string TenDA = txtTenDA.Text;
            string DiaDiemDA = txtDiaDiemDA.Text;
            string PhongDA = cmbPhongDA.Text;
            if (duAn.CapNhatDuAn(MaDA, TenDA, DiaDiemDA, PhongDA))
            {
                MessageBox.Show("Thêm dự án thành công!");
                LoadDataDA();
            }
            else
            {
                MessageBox.Show("Thêm dự án thất bại!");
            }
        }

        private void btnXoaDA_Click(object sender, EventArgs e)
        {
            BL_DuAn dbDA = new BL_DuAn();
            if (dbDA.XoaDuAn(txtMaDA.Text.ToString()))
            {
                MessageBox.Show("Đã xóa xong!" + txtMaDA.Text);
            }
            else
            {
                MessageBox.Show("Bị lỗi chưa sử lý được" + txtMaDA.Text);
            };
            LoadDataDA();
        }

        private void dgvDUAN_SelectionChanged(object sender, EventArgs e)
        {
            dgvDUAN.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (dgvDUAN.SelectedCells.Count > 0)
            {
                int rowIndex = dgvDUAN.SelectedCells[0].RowIndex;
                dgvDUAN.Rows[rowIndex].Selected = true;
            }
        }
    }
}
