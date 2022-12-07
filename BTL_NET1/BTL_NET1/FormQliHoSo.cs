using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_NET1
{
    public partial class FormQliHoSo : Form
    {
        public string hoTenThiSinh;
        public string diaChi;
        public DateTime ngaySinh;
        public string gioiTinh;
        public string phongThi;
        public int rowOld;
        public string sbdSelect;
        public FormQliHoSo()
        {
            InitializeComponent();
            button2.Image = Image.FromFile("D:\\DOWLOADS\\icons8-u-turn-to-left-24.png");
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.TextAlign = ContentAlignment.MiddleLeft;
            LoadData();
            comboBox1.DisplayMember = "Select";
            comboBox1.Items.Add("Nam");
            comboBox1.Items.Add("Nữ");
            comboBox1.Items.Add("Khác");
        }
        public void LoadData()
        {
            QuanLiTuyenSinhDB db = new QuanLiTuyenSinhDB();
            var res = from c in db.HoSoThiSinhs select c;
            var query = from c in db.DanhMucLopThis select c.MaLop;
            dataGridView1.DataSource = res.ToList();
            comboBox2.DataSource = query.ToList();
        }
    

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            // them thi sinh
           
                hoTenThiSinh = textFieldName.Text;
                diaChi = textFieldAddress.Text;
            QuanLiTuyenSinhDB db = new QuanLiTuyenSinhDB();
                var res = from c in db.HoSoThiSinhs select c;
                rowOld = res.Count();
                
                
                if(res.Count() < 9)
                {
                    string sbdNew = "SBD0" + (rowOld + 1).ToString();
                    var t = new HoSoThiSinh { SBD = sbdNew, HoTenThiSinh = hoTenThiSinh, MaLop = phongThi, NgaySinh = ngaySinh, GioiTinh = gioiTinh, DiaChi = diaChi };

                    db.HoSoThiSinhs.Add(t);
                    db.SaveChanges();
                }
                else
                {
                    string sbdNew = "SBD" + (rowOld + 1).ToString();
                    var t = new HoSoThiSinh { SBD = sbdNew, HoTenThiSinh = hoTenThiSinh, MaLop = phongThi, NgaySinh = ngaySinh, GioiTinh = gioiTinh, DiaChi = diaChi };

                    db.HoSoThiSinhs.Add(t);
                    db.SaveChanges();
                }
                    rowOld = res.Count();
                    MessageBox.Show("Thêm thành công thí sinh " + hoTenThiSinh);
                    LoadData();
                
              
            
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // set gioi tinh
            gioiTinh = comboBox1.GetItemText(comboBox1.SelectedItem);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            // set ngay sinh 
            ngaySinh = DateTime.Parse(dateTimePicker2.Text);
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //set phong thi
            phongThi = comboBox2.GetItemText(comboBox2.SelectedItem);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // set sbd to variable sbd
            sbdSelect = dataGridView1.Rows[e.RowIndex].Cells["SBD"].Value.ToString();
            textFieldName.Text = dataGridView1.Rows[e.RowIndex].Cells["HoTenThiSinh"].Value.ToString();
            textFieldAddress.Text = dataGridView1.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
            dateTimePicker2.Value = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells["NgaySinh"].Value.ToString());
            
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            // delete thi sinh
            var result = MessageBox.Show("Bạn có chắc xóa thí sinh này !!", "Xóa thí sinh dự thi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                QuanLiTuyenSinhDB db = new QuanLiTuyenSinhDB();
            var res = db.HoSoThiSinhs.Where(p => p.SBD == sbdSelect).SingleOrDefault();
            db.HoSoThiSinhs.Remove(res);
            db.SaveChanges();
            MessageBox.Show("Xóa thành công");
             LoadData();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // an form quan li ho so
            FormMain fmain = new FormMain();
            fmain.Show();
            this.Hide();
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            // TextFieldSearch.Text tim kiem theo ten va sbd 
            QuanLiTuyenSinhDB db = new QuanLiTuyenSinhDB();
            var res = from c in  db.HoSoThiSinhs where c.SBD.Contains(TextFieldSearch.Text) || c.HoTenThiSinh.Contains(TextFieldSearch.Text) select c;
            if (res.FirstOrDefault() != null)
            {
                dataGridView1.DataSource = res.ToList();
            }
            else
            {
                MessageBox.Show("Không tìm thấy thí sinh  "+ TextFieldSearch.Text,"Tìm kiếm" );
            }
        }
    }
}
