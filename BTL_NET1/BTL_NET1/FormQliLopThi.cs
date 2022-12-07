using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_NET1
{
    public partial class FormQliLopThi : Form
    {
        public int rowOld;
        public string idMalopThi;
        public FormQliLopThi()
        {
            InitializeComponent();
            LoadData();
            btnSearch.Image = Image.FromFile("D:\\DOWLOADS\\icons8-search-24.png");
            btnSearch.ImageAlign = ContentAlignment.MiddleRight;
            btnSearch.TextAlign = ContentAlignment.MiddleLeft;
        }
        public void LoadData()
        {
            QuanLiTuyenSinhEntities1 db = new QuanLiTuyenSinhEntities1();
            var res = from c in db.DanhMucLopThis select c;
            dataGridView1.DataSource = res.ToList();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (TextFieldName.Text == "")
            {
                MessageBox.Show("Chưa nhập tên lớp thi cần thêm");
            }
            else
            {
                QuanLiTuyenSinhEntities1 db = new QuanLiTuyenSinhEntities1();
                var res = from c in db.DanhMucLopThis select c;
                rowOld = res.Count();
                if (res.Count() < 9)
                {
                    string maMon = "P0" + (rowOld + 1).ToString();
                    var t = new DanhMucLopThi { MaLop = maMon, TenLop = TextFieldName.Text };

                    db.DanhMucLopThis.Add(t);
                    db.SaveChanges();
                }
                else
                {
                    string maMon = "P" + (rowOld + 1).ToString();
                    var t = new DanhMucLopThi { MaLop   = maMon, TenLop = TextFieldName.Text };

                    db.DanhMucLopThis.Add(t);
                    db.SaveChanges();
                }
                rowOld = res.Count();
                MessageBox.Show("Thêm thành công lớp thi " + TextFieldName.Text);
                LoadData();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idMalopThi = dataGridView1.Rows[e.RowIndex].Cells["MaLop"].Value.ToString();
            TextFieldName.Text = dataGridView1.Rows[e.RowIndex].Cells["TenLop"].Value.ToString();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            QuanLiTuyenSinhEntities1 db = new QuanLiTuyenSinhEntities1();
            var result = db.DanhMucLopThis.SingleOrDefault(p => p.MaLop == idMalopThi);
            if (result != null)
            {
                result.TenLop = TextFieldName.Text;
                db.SaveChanges();
                MessageBox.Show("Thay đổi tên lớp thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Thay đổi tên lớp không thành công");

            }
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc xóa lớp thi này !!", "Xóa lớp thi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                QuanLiTuyenSinhEntities1 db = new QuanLiTuyenSinhEntities1();
                var res = db.DanhMucLopThis.Where(p => p.MaLop == idMalopThi).SingleOrDefault();
                db.DanhMucLopThis.Remove(res);
                db.SaveChanges();
                MessageBox.Show("Xóa thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            QuanLiTuyenSinhEntities1 db = new QuanLiTuyenSinhEntities1();
            var res = from c in db.DanhMucLopThis where c.MaLop.Contains(TextFieldSearch.Text) || c.TenLop.Contains(TextFieldSearch.Text) select c;
            if (res.FirstOrDefault() != null)
            {
                dataGridView1.DataSource = res.ToList();
            }
            else
            {
                MessageBox.Show("Không tìm thấy phòng thi  " + TextFieldSearch.Text, "Tìm kiếm");
            }
        }
    }
}
