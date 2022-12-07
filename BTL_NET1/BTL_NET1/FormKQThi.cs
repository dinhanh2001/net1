using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTL_NET1
{
    public partial class FormKQThi : Form
    {
        public FormKQThi()
        {
            InitializeComponent();
            QuanLiTuyenSinhDB db = new QuanLiTuyenSinhDB();

            var res = from c in db.HoSoThiSinhs select c.SBD;
            var query = from c in db.DanhMucMonThis select c.TenMon;
            comboBoxSBD.DataSource = res.ToList();
           comboBoxsubJect.DataSource = query.ToList();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if(TextFieldPoint.Text == "")
            {
                MessageBox.Show(" Chưa nhập điểm cho thí sinh");
            }
            else
            {
                QuanLiTuyenSinhDB db = new QuanLiTuyenSinhDB();
             var query = db.DanhMucMonThis.SingleOrDefault(p => p.TenMon == comboBoxsubJect.SelectedItem.ToString()).MaMon;
                 KetQuaThi add = new KetQuaThi ();
                // { SBD = comboBoxSBD.SelectedValue.ToString(), MaMon = query, Diem = Int32.Parse(TextFieldPoint.Text) } 
                add.SBD = comboBoxSBD.SelectedValue.ToString();
                add.MaMon = query;
                add.Diem =   Int32.Parse(TextFieldPoint.Text);
               // MessageBox.Show("SBD:" + comboBoxSBD.SelectedValue.ToString() + "Ma Mon" + query + " diem" + Int32.Parse(TextFieldPoint.Text));
             db.KetQuaThis.Add(add);
             db.SaveChanges();
            MessageBox.Show("Thêm điểm danh công môn "+ comboBoxsubJect.SelectedItem.ToString() + "với số điểm là :" + Int32.Parse(TextFieldPoint.Text));
            }
            //var addPoint = new KetQuaThi { SBD = comboBoxSBD.SelectedValue.ToString(), MaMon = "ok", Diem = Int32.Parse(TextFieldPoint.Text) };
          //  MessageBox.Show(comboBoxSBD.SelectedValue.ToString());
        }

        private void comboBoxSBD_SelectionChangeCommitted(object sender, EventArgs e)
        {
           string SBD = comboBoxSBD.GetItemText(comboBoxSBD.SelectedItem);
           
        }
    }
}
