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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Office.Interop.Excel;
using System.IO;
using QLNS_ADO.NET.DB_Layer;

namespace QLNS_ADO.NET
{
    public partial class FormDSNhanVien : Form
    {
        System.Data.DataTable dtNhanVien = null;
        string LinkImage = "";
        BL_NhanVien dbNV = new BL_NhanVien();
        public FormDSNhanVien()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            try
            {
                dtNhanVien = new System.Data.DataTable();
                dtNhanVien.Clear();
                DataSet ds = dbNV.LayNhanVien();
                dtNhanVien = ds.Tables[0];
                dgvNHANVIEN.DataSource = dtNhanVien;
                dgvNHANVIEN.AutoResizeColumns();
                btnChonAnh.Visible = false;
                txtMaNV.Enabled = false;
                cmbMaHD.Enabled = false;
                txtDchi.Enabled = false;
                txtHotenNV.Enabled = false;
                cmbMaNQL.Enabled = false;
                cmbPhai.Enabled = false;
                cmbPhong.Enabled = false;
                dtpNgSinh.Enabled = false;
                BL_HopDong hopdong = new BL_HopDong();
                BL_PhongBan phongBan = new BL_PhongBan();
                cmbMaNQL.DataSource = dbNV.GetAllMaNV();
                cmbMaHD.DataSource = hopdong.GetAllMaHD();
                cmbPhong.DataSource = phongBan.GetAllMaPB();
                dtpNgSinh.Format = DateTimePickerFormat.Custom;
                dtpNgSinh.CustomFormat = "dd/MM/yyyy";
                cmbPhai.Items.Add("Nam");
                cmbPhai.Items.Add("Nữ");
                cmbPhai.SelectedIndex = 0;
                dgvNHANVIEN_CellClick(null, null);
            }
            catch (SqlException)
            {

            }
        }
        private void FormDSNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvNHANVIEN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = dgvNHANVIEN.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            this.txtMaNV.Text =
            dgvNHANVIEN.Rows[r].Cells[0].Value.ToString();
            this.cmbMaHD.Text =
            dgvNHANVIEN.Rows[r].Cells[1].Value.ToString();
            this.txtHotenNV.Text =
            dgvNHANVIEN.Rows[r].Cells[2].Value.ToString();
            dtpNgSinh.Value = DateTime.Parse(dgvNHANVIEN.Rows[r].Cells[3].Value.ToString());
            this.txtDchi.Text =
            dgvNHANVIEN.Rows[r].Cells[4].Value.ToString();
            this.cmbPhai.Text =
            dgvNHANVIEN.Rows[r].Cells[5].Value.ToString();
            this.cmbMaNQL.Text =
            dgvNHANVIEN.Rows[r].Cells[6].Value.ToString();
            this.cmbPhong.Text =
            dgvNHANVIEN.Rows[r].Cells[7].Value.ToString();

            LinkImage = GetAttributeValue(txtMaNV.Text);
            if (!File.Exists(LinkImage) || LinkImage=="")
            {
                picChanDung.BackgroundImage = Properties.Resources.H0;
            }
            else {
              //  MessageBox.Show(LinkImage);
                picChanDung.BackgroundImage = Image.FromFile(LinkImage);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            cmbMaHD.Enabled = true;
            txtDchi.Enabled = true;
            txtHotenNV.Enabled = true;
            cmbMaNQL.Enabled = true;
            cmbPhai.Enabled = true;
            cmbPhong.Enabled = true;
            dtpNgSinh.Enabled = true;
            btnChonAnh.Visible = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            BL_NhanVien nhanVien = new BL_NhanVien();
            string MaNV = txtMaNV.Text;
            string MaHD = cmbMaHD.Text;
            string HotenNV = txtHotenNV.Text;
            DateTime NgSinh = dtpNgSinh.Value;
            string Dchi = txtDchi.Text;
            string Phai = cmbPhai.Text;
            string MaNQL = cmbMaNQL.Text;
            string Phong = cmbPhong.Text;
            if (nhanVien.CapNhatNhanVien(MaNV, MaHD, HotenNV, NgSinh, Dchi, Phai,  MaNQL, Phong, LinkImage))
            {
                MessageBox.Show("Thêm thành công !");
                LoadData();
            }
            else
            {
                MessageBox.Show("tHÊM THẤT BẠI");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            FormCanhBaoXoa canhBaoXoa = new FormCanhBaoXoa(txtMaNV.Text, cmbMaHD.Text);
            canhBaoXoa.ShowDialog();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
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
            bL_Export.ExportToExcel("NHANVIEN", saveFileDialog);

        }
        public string GetAttributeValue(string maNV)
        {

            string sql = "SELECT Hinh FROM NHANVIEN WHERE MaNV = @MaNV";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaNV", maNV)
            };
            DBMain db = new DBMain();
            DataSet dataSet = db.ExecuteQueryDataSet(sql, CommandType.Text, parameters);
            if (dataSet.Tables[0].Rows.Count > 0)
            {
                return dataSet.Tables[0].Rows[0]["Hinh"].ToString();
            }
            else
            {
                return null;
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            string strAvt = "";
            OpenFileDialog openFile = new OpenFileDialog()
            {
                Filter = "Image (*.png)|*.png|Image (*.jpeg, *.jpg)|*.jpeg, *.jpg|All files (*.*)|*.*",
                Title = "Chọn ảnh chân dung"
            };
            DialogResult result = openFile.ShowDialog();
            if (result == DialogResult.OK)
            {

                strAvt = openFile.FileName;
                LinkImage = strAvt;
                picChanDung.BackgroundImage = Image.FromStream(openFile.OpenFile());
            }
        }

        private void dgvNHANVIEN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvNHANVIEN_SelectionChanged(object sender, EventArgs e)
        {
            dgvNHANVIEN.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (dgvNHANVIEN.SelectedCells.Count > 0)
            {
                int rowIndex = dgvNHANVIEN.SelectedCells[0].RowIndex;
                dgvNHANVIEN.Rows[rowIndex].Selected = true;
            }
        }
    }
}
