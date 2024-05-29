using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS_ADO.NET.Forms.About
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {;
            labelname.Text = "21110603\t Nguyễn Đại Phúc\n21110728\t Nguyễn Dương Thế Vĩ\n21110449\t Võ Trọng Hiếu";
        }
    }
}
