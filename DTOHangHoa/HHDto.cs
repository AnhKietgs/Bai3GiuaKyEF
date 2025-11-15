using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOHangHoa
{
    public class HHDto
    {

        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGiaNhap { get; set; }
        public decimal DonGiaBan { get; set; }
        public string Hinh { get; set; }
        public string GhiChu { get; set; }
        public string MaChatLieu { get; set; }
        public HHDto(string maHang, string tenHang, int soLuong, decimal donGiaNhap, decimal donGiaBan, string hinh, string ghiChu, string maChatLieu)
        {
            MaHang = maHang;
            TenHang = tenHang; 
            SoLuong = soLuong;
            DonGiaNhap = donGiaNhap;
            DonGiaBan = donGiaBan;
            Hinh = hinh;
            GhiChu = ghiChu;
            MaChatLieu = maChatLieu;
        }
        public HHDto()
        {

        }


    }
    
}
