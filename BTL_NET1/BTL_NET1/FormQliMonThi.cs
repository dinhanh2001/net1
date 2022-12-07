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
    public partial class FormQliMonThi : Form
    {
        public int rowOld;
        public string nameSubject;
        public FormQliMonThi()
        {
            InitializeComponent();
            LoadData();
           // dataGridView1.Columns["Check"].DisplayIndex = 2;
            btnSearch.Image = Image.FromFile("D:\\DOWLOADS\\icons8-search-24.png");
            btnSearch.ImageAlign = ContentAlignment.MiddleRight;
            btnSearch.TextAlign = ContentAlignment.MiddleLeft;
        }
        public void LoadData()
        {
            QuanLiTuyenSinhEntities1 db = new QuanLiTuyenSinhEntities1();
            var res  = from c in db.DanhMucMonThis select c;
            dataGridView1.DataSource = res.ToList();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if(TextFieldName.Text == "")
            {
                MessageBox.Show("Chưa nhập tên môn thi cần thêm");
            }
            else
            {
                QuanLiTuyenSinhEntities1 db = new QuanLiTuyenSinhEntities1();
                var res = from c in db.DanhMucMonThis select c;
                rowOld = res.Count();
                if (res.Count() < 9)
                {
                    string maMon = "MaMon0" + (rowOld + 1).ToString();
                    var t = new DanhMucMonThi { MaMon = maMon, TenMon = TextFieldName.Text };

                    db.DanhMucMonThis.Add(t);
                    db.SaveChanges();
                }
                else
                {
                    string maMon = "MaMon" + (rowOld + 1).ToString();
                    var t = new DanhMucMonThi { MaMon = maMon, TenMon = TextFieldName.Text };

                    db.DanhMucMonThis.Add(t);
                    db.SaveChanges();
                }
                rowOld = res.Count();
                MessageBox.Show("Thêm thành công môn thi " + TextFieldName.Text);
                LoadData();
            }
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        { // sua ten mon thi
            QuanLiTuyenSinhEntities1 db = new QuanLiTuyenSinhEntities1();
            var result = db.DanhMucMonThis.SingleOrDefault(p => p.MaMon == nameSubject);
            if(result != null)
            {
                result.TenMon = TextFieldName.Text;
                db.SaveChanges();
                MessageBox.Show("Thay đổi tên môn thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Thay đổi tên môn không thành công");

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nameSubject = dataGridView1.Rows[e.RowIndex].Cells["MaMon"].Value.ToString();
            TextFieldName.Text = dataGridView1.Rows[e.RowIndex].Cells["TenMon"].Value.ToString();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {// xoa mon thi
            var result = MessageBox.Show("Bạn có chắc xóa môn thi này !!", "Xóa môn thi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                QuanLiTuyenSinhEntities1 db = new QuanLiTuyenSinhEntities1();
                var res = db.DanhMucMonThis.Where(p => p.MaMon == nameSubject).SingleOrDefault();
                db.DanhMucMonThis.Remove(res);
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
            var res = from c in db.DanhMucMonThis where c.MaMon.Contains(Search.Text) || c.TenMon.Contains(Search.Text) select c;
            if (res.FirstOrDefault() != null)
            {
                dataGridView1.DataSource = res.ToList();
            }
            else
            {
                MessageBox.Show("Không tìm thấy môn thi  " + Search.Text, "Tìm kiếm");
            }
        }
    }
}
