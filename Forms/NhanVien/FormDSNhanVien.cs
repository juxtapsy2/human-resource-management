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
using System.IO;



using Microsoft.Win32;
namespace QLNS_LinQ
{
    public partial class FormDSNhanVien : Form
    {
     
        bool Them;
        string err;
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
                dgvNHANVIEN.DataSource = dbNV.LayNhanVien();
                DataGridViewColumnCollection columns = dgvNHANVIEN.Columns;
                while (columns.Count > 8)
                {
                    columns.RemoveAt(columns.Count - 1);
                }
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
                MessageBox.Show("Không lấy được nội dung trong table THANHPHO. Lỗi rồi!!!");
            }
        }


        private void DanhSachNhanVien_Load(object sender, EventArgs e)
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
            if (dgvNHANVIEN.Rows[r].Cells[6].Value != null)
            {
                cmbMaNQL.Text = dgvNHANVIEN.Rows[r].Cells[6].Value.ToString() ;
            }
            else
            {
                cmbMaNQL.Text = "";
            }
            
            this.cmbPhong.Text =
            dgvNHANVIEN.Rows[r].Cells[7].Value.ToString();

            LinkImage = GetAttributeValue(txtMaNV.Text);
            if (!File.Exists(LinkImage) || LinkImage == "")
            {
                picChanDung.BackgroundImage = Properties.Resources.H0;
            }
            else
            {
                //  MessageBox.Show(LinkImage);
                picChanDung.BackgroundImage = Image.FromFile(LinkImage);
            }

        }
        public string GetAttributeValue(string maNV)
        {
            QLNSDataContext db = new QLNSDataContext();

            var query = from nv in db.NHANVIENs
                        where nv.MaNV == maNV
                        select nv.Hinh;

            string result = query.FirstOrDefault();
            return result;
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
            bL_Export.ExportToExcelNhanVien(saveFileDialog);
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
            if(MaNQL == "")
            {
                MaNQL = null;
            }
            string  Phong = cmbPhong.Text;
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            FormCanhBaoXoa canhBaoXoa = new FormCanhBaoXoa(this, txtMaNV.Text, cmbMaHD.Text);
            canhBaoXoa.ShowDialog();
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
