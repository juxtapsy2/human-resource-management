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

namespace QLNS_EntityFramework
{
    public partial class FormThanNhan : Form
    {
        bool Them = false;
        System.Data.DataTable dtThanNhan = null;
        BL_ThanNhan dbTN = new BL_ThanNhan();
        public FormThanNhan()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                dtThanNhan = dbTN.LayThanhNhan();
                dgvTHANNHAN.DataSource = dtThanNhan;
                dgvTHANNHAN.AutoResizeColumns();
                cmbMaNV.Enabled = false;
                txtHoTen.Enabled = false;
                txtVaiTro.Enabled = false;
                txtSDT.Enabled = false;
                BL_NhanVien nhanVien = new BL_NhanVien();
                cmbMaNV.DataSource = nhanVien.GetAllMaNV();
                dgvTHANNHAN_CellClick(null, null);

            }
            catch (SqlException)
            {

            }
        }
        private void FormThanhNhan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvTHANNHAN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTHANNHAN.CurrentCell != null)
            {
                int r = dgvTHANNHAN.CurrentCell.RowIndex;
                this.cmbMaNV.Text =
                dgvTHANNHAN.Rows[r].Cells[0].Value.ToString();
                this.txtHoTen.Text =
                dgvTHANNHAN.Rows[r].Cells[1].Value.ToString();
                this.txtVaiTro.Text =
                dgvTHANNHAN.Rows[r].Cells[2].Value.ToString();
                this.txtSDT.Text =
                dgvTHANNHAN.Rows[r].Cells[3].Value.ToString();
            }
        }

        private void dgvTHANNHAN_SelectionChanged(object sender, EventArgs e)
        {
            dgvTHANNHAN.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (dgvTHANNHAN.SelectedCells.Count > 0)
            {
                int rowIndex = dgvTHANNHAN.SelectedCells[0].RowIndex;
                dgvTHANNHAN.Rows[rowIndex].Selected = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            cmbMaNV.Enabled = true;
            txtHoTen.Enabled = true;
            txtVaiTro.Enabled = true;
            txtSDT.Enabled = true;
            cmbMaNV.SelectedItem = 0;
            txtHoTen.Clear();
            txtVaiTro.Clear();
            txtSDT.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            cmbMaNV.Enabled = false;
            txtHoTen.Enabled = true;
            txtVaiTro.Enabled = true;
            txtSDT.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                BL_ThanNhan thannhan = new BL_ThanNhan();
                bool result = thannhan.ThemThanNhan(cmbMaNV.Text, txtHoTen.Text, txtVaiTro.Text, txtSDT.Text);
                LoadData();
                if (result == false)
                {
                    MessageBox.Show("Thêm bị lỗi ");
                }
                Them = false;
            }
            else
            {
                BL_ThanNhan thannhan = new BL_ThanNhan();
                thannhan.CapNhatThanhNhan(cmbMaNV.Text, txtHoTen.Text, txtVaiTro.Text, txtSDT.Text);
                LoadData();
            }
        }
    }
}
