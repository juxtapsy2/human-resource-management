using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace QLNS_LinQ
{
    public partial class FormTimKiem : Form
    {
        int SearchType = 1;
        public FormTimKiem()
        {
            InitializeComponent();
        }

        private void FormTimKiem_Load(object sender, EventArgs e)
        {
            checkBoxNV.Checked = true;
            SearchType = 1;
            comboBoxType.Items.Add("Mã");
            comboBoxType.Items.Add("Tên");
            comboBoxType.SelectedItem = "Mã";
            setNhanVien(true);
            setPhongBan(false);
            setDuAn(false);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            BL_TimKiem timKiem = new BL_TimKiem();
            if (checkBoxNV.Checked == true)
            {
                dgvData.DataSource = null;
                if ((string)comboBoxType.SelectedItem == "Mã")
                {
                    dgvData.DataSource = timKiem.TimKiemNhanVien(txtInput.Text, "Ma");
                }
                else
                {
                    dgvData.DataSource = timKiem.TimKiemNhanVien(txtInput.Text, "Ten");
                }
                dgvData.Columns[dgvData.ColumnCount-1].Visible = false;
                setNhanVien(true);
                setPhongBan(false);
                setDuAn(false);
                SearchType = 1;
                dgvData.AutoResizeColumns();
            }
            else if (checkBoxPB.Checked == true)
            {
                dgvData.DataSource = null;
                if ((string)comboBoxType.SelectedItem == "Mã")
                {
                    dgvData.DataSource = timKiem.TimKiemPhongBan(txtInput.Text, "Ma");
                }
                else
                {
                    dgvData.DataSource = timKiem.TimKiemPhongBan(txtInput.Text, "Ten");
                }
                SearchType = 2;
                setNhanVien(false);
                setPhongBan(true);
                setDuAn(false);
                dgvData.AutoResizeColumns();
            }
            else
            {
                dgvData.DataSource = null;
                if ((string)comboBoxType.SelectedItem == "Mã")
                {
                    dgvData.DataSource = timKiem.TimKiemDuAn(txtInput.Text, "Ma");
                }
                else
                {
                    dgvData.DataSource = timKiem.TimKiemDuAn(txtInput.Text, "Ten");
                }
                SearchType = 3;
                setNhanVien(false);
                setPhongBan(false);
                setDuAn(true);
                dgvData.AutoResizeColumns();
            }
        }
        private void setNhanVien(bool visible)
        {
            labelMaNV.Visible = visible;
            labelMaHDNV.Visible = visible;
            labelHoTenNV.Visible = visible;
            labelNgaySinh.Visible = visible;
            labelDiaChi.Visible = visible;
            labelPhongNV.Visible = visible;
            labelPhai.Visible = visible;
            labelMaNQL.Visible = visible;
            labelNHANVIEN.Visible = visible;
            picChanDung.Visible = visible;
            txtMaHD.Visible = visible;
            txtPhong.Visible = visible;
            txtDchi.Visible = visible;
            txtMaNQL.Visible = visible;
            txtPhai.Visible = visible;
            txtMaNV.Visible = visible;
            txtHotenNV.Visible = visible;
            dtpNgSinh.Visible = visible;
        }
        private void setPhongBan(bool visible)
        {
            labelMaPB.Visible = visible;
            labelTenPB.Visible = visible;
            labelTrP.Visible = visible;
            labelNgNhanChuc.Visible = visible;
            labelDiaDiem.Visible = visible;
            labelPHONGBAN.Visible = visible;
            txtMaPB.Visible = visible;
            txtTenPB.Visible = visible;
            txtDiaDiem.Visible = visible;
            txtTrP.Visible = visible;
            dtpNgayNhanChuc.Visible = visible;
        }
        private void setDuAn(bool visible)
        {
            labelDUAN.Visible = visible;
            labelMaDA.Visible = visible;
            labelTenDA.Visible = visible;
            labelDiaDiemDA.Visible = visible;
            labelPhongDA.Visible = visible;
            txtMaDA.Visible = visible;
            txtTenDA.Visible = visible;
            txtDiaDiemDA.Visible = visible;
            txtPhongDA.Visible = visible;

        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SearchType == 1)
            {

                int r = dgvData.CurrentCell.RowIndex;
                this.txtMaNV.Text =
                dgvData.Rows[r].Cells[0].Value.ToString();
                this.txtMaHD.Text =
                dgvData.Rows[r].Cells[1].Value.ToString();
                this.txtHotenNV.Text =
                dgvData.Rows[r].Cells[2].Value.ToString();
                dtpNgSinh.Value = DateTime.Parse(dgvData.Rows[r].Cells[3].Value.ToString());
                this.txtDchi.Text =
                dgvData.Rows[r].Cells[4].Value.ToString();
                this.txtPhai.Text =
                dgvData.Rows[r].Cells[5].Value.ToString();
                this.txtMaNQL.Text = dgvData.Rows[r].Cells[6].Value.ToString();
                this.txtPhong.Text = dgvData.Rows[r].Cells[7].Value.ToString();
                if (dgvData.Rows[r].Cells[8].Value == null)
                {

                    picChanDung.BackgroundImage = Properties.Resources.H0;
                }
                else
                {
                    if (File.Exists(dgvData.Rows[r].Cells[8].Value.ToString()))
                    {
                        picChanDung.BackgroundImage = Image.FromFile(dgvData.Rows[r].Cells[8].Value.ToString());
                    }
                    else
                    {
                        picChanDung.BackgroundImage = Properties.Resources.H0;
                    }
                
                }

            }
            else if (SearchType == 2)
            {
                int r = dgvData.CurrentCell.RowIndex;
                this.txtMaPB.Text =
                dgvData.Rows[r].Cells[0].Value.ToString();
                this.txtTenPB.Text =
                dgvData.Rows[r].Cells[1].Value.ToString();
                this.txtTrP.Text =
                dgvData.Rows[r].Cells[2].Value.ToString();
                dtpNgayNhanChuc.Value = DateTime.Parse(dgvData.Rows[r].Cells[3].Value.ToString());
                this.txtDiaDiem.Text =
                dgvData.Rows[r].Cells[4].Value.ToString();
            }
            else
            {
                int r = dgvData.CurrentCell.RowIndex;
                this.txtMaDA.Text =
                dgvData.Rows[r].Cells[0].Value.ToString();
                this.txtTenDA.Text =
                dgvData.Rows[r].Cells[1].Value.ToString();
                this.txtDiaDiemDA.Text =
                dgvData.Rows[r].Cells[2].Value.ToString();

                this.txtPhongDA.Text =
                dgvData.Rows[r].Cells[3].Value.ToString();
            }
        }

        private void checkBoxNV_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxNV.Checked)
            {
                checkBoxDA.Checked = false;
                checkBoxPB.Checked = false;

            }
        }

        private void checkBoxPB_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPB.Checked)
            {
                checkBoxDA.Checked = false;
                checkBoxNV.Checked = false;

            }
        }

        private void checkBoxDA_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxDA.Checked)
            {
                checkBoxPB.Checked = false;
                checkBoxNV.Checked = false;

            }
        }

        private void dgvData_SelectionChanged(object sender, EventArgs e)
        {
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (dgvData.SelectedCells.Count > 0)
            {
                int rowIndex = dgvData.SelectedCells[0].RowIndex;
                dgvData.Rows[rowIndex].Selected = true;
            }
        }
    }
}
