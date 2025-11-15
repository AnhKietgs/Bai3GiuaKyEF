using BusHangHoa;
using DTOHangHoa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3GiuaKy
{
    public partial class GUIHangHoa : Form
    {
        private HHBus bus = new HHBus();

        public GUIHangHoa()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            dataGridView_tt.DataSource = bus.layDanhSach();
        }
        private void LoadChatLieu()
        {
          var dsChatLieu = bus.LayDSChatLieu();
            comBoxMaCL.DataSource = dsChatLieu;
            comBoxMaCL.DisplayMember = "TenChatLieu";
            comBoxMaCL.ValueMember = "MaChatLieu";
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void GUIHangHoa_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadChatLieu();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_them_Click(object sender, EventArgs e)
        {
            try
            {
                bus.them(new HHDto
                {
                    MaHang = textBox_MHang.Text,
                    TenHang = textBox_TenHang.Text,
                    SoLuong = int.Parse(textBox_SLuong.Text),
                    DonGiaNhap = decimal.Parse(textBox_DGNhap.Text),
                    DonGiaBan = decimal.Parse(textBox_DGBan.Text),
                    Hinh = textBox_Anh.Text,
                    GhiChu=textBox_GhiChu.Text,
                    MaChatLieu=comBoxMaCL.SelectedValue.ToString()
                    
                });
                LoadData();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maHang = textBox_MHang.Text.Trim();
                if (string.IsNullOrEmpty(maHang))
                {
                    MessageBox.Show("Vui lòng nhập mã sản phẩm cần xóa!");
                    return;
                }
                else
                {
                    bus.xoa(maHang);
                    LoadData();
                    Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xoa " + ex.Message);
            }

        }

        private void dataGridView_tt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_tt.Rows[e.RowIndex];
                textBox_MHang.Text = row.Cells["MaHang"].Value.ToString();
                textBox_TenHang.Text = row.Cells["TenHang"].Value.ToString();
                textBox_SLuong.Text = row.Cells["SoLuong"].Value.ToString();
                textBox_DGNhap.Text = row.Cells["DonGiaNhap"].Value.ToString();
                textBox_DGBan.Text = row.Cells["DonGiaBan"].Value.ToString();
                //textBox_Anh.Text = row.Cells["Hinh"].Value.ToString();
                textBox_GhiChu.Text = row.Cells["GhiChu"].Value.ToString();
                string maCL = row.Cells["MaChatLieu"].Value.ToString();
                string fileName = row.Cells["Hinh"].Value?.ToString();//lay duong dan
                if (!string.IsNullOrEmpty(fileName))
                {
                    string imPath = Path.Combine(Application.StartupPath, "Images", Path.GetFileName(fileName));
                    //xac dinh thu muc chua anh
                    if (File.Exists(imPath))//kiem tra co ton tai ko
                    {
                        picBox.ImageLocation = imPath;//hien thi anh
                        textBox_Anh.Text = imPath;
                    }
                    else
                    {
                        picBox.Image = null;
                        textBox_Anh.Text = "";
                    }

                }
                else
                {
                    picBox.Image = null;
                    textBox_Anh.Text = "";
                }
                comBoxMaCL.SelectedValue=maCL;
                textBox_MHang.Enabled = false;
                textBox_DGNhap.Enabled = false;
                textBox_DGBan.Enabled = false;
            }
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                bus.capnhat(new HHDto
                {
                    MaHang = textBox_MHang.Text,
                    TenHang = textBox_TenHang.Text,
                    SoLuong = int.Parse(textBox_SLuong.Text),
                    DonGiaNhap = decimal.Parse(textBox_DGNhap.Text),
                    DonGiaBan = decimal.Parse(textBox_DGBan.Text),
                    Hinh = textBox_Anh.Text,
                    GhiChu = textBox_GhiChu.Text,
                    MaChatLieu = comBoxMaCL.SelectedValue.ToString()
                });

                LoadData();
                MessageBox.Show("Cập nhật thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button_TimKiem_Click(object sender, EventArgs e)
        {
            string maHang = textBox_MHang.Text.Trim();
            if(string.IsNullOrEmpty(maHang))
                {
                MessageBox.Show("vui long nhap ma hh can tim!!!");
                    return;
            }

            var kqua = bus.TimKiem(maHang);
            if (kqua.Count >0) {
                dataGridView_tt.DataSource = kqua;
            }
            else
            {
                MessageBox.Show("Khong tim thay!!!");
                dataGridView_tt.DataSource =null;
            }
        }

        private void button_MoAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Image files|*.jpg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = Path.Combine(Application.StartupPath, "Images");//lay duong dan
                if (!Directory.Exists(path)) Directory.CreateDirectory(path);//ktra neu chua co thu mục “Images” thì tự động tạo mới để chứa ảnh.

                string fileName = Path.GetFileName(ofd.FileName);//Lấy tên file gốc
                string dest = Path.Combine(path, fileName);//Tạo đường dẫn đích để sao chép ảnh vào thư mục Images của chương trình.
                File.Copy(ofd.FileName, dest, true);//Sao chép ảnh từ nơi người dùng chọn vào thư mục Images của chương trình.
                                                    //Tham số true nghĩa là nếu file đã tồn tại thì ghi đè.

                textBox_Anh.Text = dest;
                picBox.ImageLocation = dest;
            }
        }
        private void Clear()
        {
            textBox_MHang.Clear();
            textBox_TenHang.Clear();
            textBox_SLuong.Clear();
            textBox_DGNhap.Clear();
            textBox_DGBan.Clear();
            textBox_Anh.Clear();
            textBox_GhiChu.Clear();
            picBox.Image=null;
            comBoxMaCL.SelectedIndex = -1;

          
        }

        private void button_boqua_Click(object sender, EventArgs e)
        {

            Clear();
            textBox_MHang.Enabled = true;
            textBox_DGNhap.Enabled = true;
            textBox_DGBan.Enabled = true;
            textBox_MHang.Focus();
            LoadData();

        }
    }
}
