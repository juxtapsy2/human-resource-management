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

namespace QLNS_ADO.NET.Forms.ThoiViec
{
    public partial class FormThoiViec : Form
    {
        System.Data.DataTable dtThoiViec = null;
        BL_DuAn dbTV = new BL_DuAn();
        public FormThoiViec()
        {
            InitializeComponent();
        }
        void LoadDataDA()
        {
            try
            {
                BL_ThoiViec thoiViec = new BL_ThoiViec();
                dtThoiViec = new System.Data.DataTable();
                dtThoiViec.Clear();
                DataSet ds = thoiViec.LayThoiViec();
                if(ds!=null)
                {
                    dtThoiViec = ds.Tables[0];
                    dgvTHOIVIEC.DataSource = dtThoiViec;
                    dgvTHOIVIEC.AutoResizeColumns();
                }
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
            LoadDataDA();
        }

        private void dgvTHOIVIEC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*     int r = dgvTHOIVIEC.CurrentCell?.RowIndex??;
                 if (r > 0)
                 {
                     this.txtMaNV.Text =
                     dgvTHOIVIEC.Rows[r].Cells[0].Value.ToString();
                     this.txtMaHD.Text =
                     dgvTHOIVIEC.Rows[r].Cells[1].Value.ToString();
                     this.dtpNgayThoiViec.Value = DateTime.Parse(dgvTHOIVIEC.Rows[r].Cells[2].Value.ToString());
                     this.richtxtThoiViec.Text =
                     dgvTHOIVIEC.Rows[r].Cells[3].Value.ToString();
                 }*/
            DataGridViewCell currentCell = dgvTHOIVIEC.CurrentCell;
            if (currentCell != null)
            {
                int r = currentCell.RowIndex;
                this.txtMaNV.Text = dgvTHOIVIEC.Rows[r].Cells[0].Value.ToString();
                this.txtMaHD.Text = dgvTHOIVIEC.Rows[r].Cells[1].Value.ToString();
                this.dtpNgayThoiViec.Value = DateTime.Parse(dgvTHOIVIEC.Rows[r].Cells[2].Value.ToString());
                this.richtxtThoiViec.Text = dgvTHOIVIEC.Rows[r].Cells[3].Value.ToString();
            }

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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BL_ThoiViec thoiViec = new BL_ThoiViec();
            if (thoiViec.XoaThoiViec(txtMaNV.Text))
            {
                LoadDataDA();
                MessageBox.Show("Đã xóa thành công !");
            }
            else
            {
                MessageBox.Show("Không xóa được !");
            }
            
        }
    }
}
