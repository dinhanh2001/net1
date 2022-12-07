using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BTL_NET1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
           FormQliHoSo fQliHoSo = new FormQliHoSo();
            fQliHoSo.Show();
            this.Hide();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            FormQliMonThi fqlimonthi = new FormQliMonThi();
            fqlimonthi.Show();
            this.Hide();
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            FormQliLopThi frmQliLopThi = new FormQliLopThi();
            frmQliLopThi.Show();
            this.Hide();
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            FormKQThi fKQthi = new FormKQThi();
            fKQthi.Show();
            this.Hide();
        }
    }
}
