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

namespace QLNS_LinQ.Forms.ThoiViec
{
    public partial class FormThoiViec : Form
    {
        BL_ThoiViec dbTV = new BL_ThoiViec();
        public FormThoiViec()
        {
            InitializeComponent();
        }
        void LoadDataTV()
        {
            try
            {
                dgvTHOIVIEC.DataSource = dbTV.LayThoiViec();
                DataGridViewColumnCollection columns = dgvTHOIVIEC.Columns;
                while (columns.Count > 4)
                {
                    columns.RemoveAt(columns.Count - 1);
                }
                dgvTHOIVIEC.AutoResizeColumns();
                txtMaNV.Enabled = false;
                txtMaHD.Enabled = false;
                dtpNgayThoiViec.Enabled = false;
                richtxtThoiViec.Enabled = false;

                dgvTHOIVIEC_CellClick(null, null);
            }
            catch (SqlException)
            {

            }
        }
        private void FormThoiViec_Load(object sender, EventArgs e)
        {
            LoadDataTV();
        }

        private void dgvTHOIVIEC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTHOIVIEC.CurrentCell != null)
            {
                int r = dgvTHOIVIEC.CurrentCell.RowIndex;
                this.txtMaNV.Text = dgvTHOIVIEC.Rows[r].Cells[0].Value.ToString();
                this.txtMaHD.Text = dgvTHOIVIEC.Rows[r].Cells[1].Value.ToString();
                this.dtpNgayThoiViec.Value = DateTime.Parse(dgvTHOIVIEC.Rows[r].Cells[2].Value.ToString());
                this.richtxtThoiViec.Text = dgvTHOIVIEC.Rows[r].Cells[3].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dbTV.XoaThoiViec(txtMaNV.Text))
            {
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Bị lỗi chưa xử lý được");
            };
            LoadDataTV();
        }

        private void dgvTHOIVIEC_SelectionChanged(object sender, EventArgs e)
        {
            dgvTHOIVIEC.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (dgvTHOIVIEC.SelectedCells.Count > 0)
            {
                int rowIndex = dgvTHOIVIEC.SelectedCells[0].RowIndex;
                dgvTHOIVIEC.Rows[rowIndex].Selected = true;
            }
        }
    }
}
