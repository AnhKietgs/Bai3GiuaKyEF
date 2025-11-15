using DTOHangHoa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOHangHoa
{
    public class HHDao
    {
        private QuanLyHangHoaEntities db = new QuanLyHangHoaEntities();
        public List<HHDto> GetAll()
        {
            return db.DMHangs.Select(sp => new HHDto
            {
                MaHang = sp.MaHang,
                TenHang = sp.TenHang,
                SoLuong = sp.SoLuong ?? 0,
                DonGiaNhap = sp.DonGiaNhap ?? 0,
                DonGiaBan = sp.DonGiaBan ?? 0,
                Hinh = sp.Hinh,
                GhiChu = sp.GhiChu,
                MaChatLieu = sp.MaCLieu      
            }).ToList();

        }

        public void Insert(HHDto sp)
        {
            DMHang entity = new DMHang
            {
                MaHang = sp.MaHang,
                TenHang = sp.TenHang,
                SoLuong = sp.SoLuong ,
                DonGiaNhap = sp.DonGiaNhap,
                DonGiaBan = sp.DonGiaBan,
                Hinh = sp.Hinh,
                GhiChu = sp.GhiChu,
                MaCLieu = sp.MaChatLieu
            };
            db.DMHangs.Add(entity);
            db.SaveChanges();
        }
        public void Update(HHDto sp)
        {
            var entity = db.DMHangs.SingleOrDefault(x => x.MaHang == sp.MaHang);
            if (entity != null)
            {
                entity.TenHang = sp.TenHang;
                entity.SoLuong = sp.SoLuong;
                entity.DonGiaNhap = sp.DonGiaNhap;
                entity.DonGiaBan = sp.DonGiaBan;
                entity.Hinh = sp.Hinh;
                entity.GhiChu = sp.GhiChu;
                entity.MaCLieu = sp.MaChatLieu;
                db.SaveChanges();
            }
        }
        public void Delete(String maHang)
        {
            var entity = db.DMHangs.SingleOrDefault(x => x.MaHang == maHang);
            if (entity != null)
            {
                db.DMHangs.Remove(entity);
                db.SaveChanges();
            }
        }

        public List<HHDto> Search(String maHang)
        {
            return db.DMHangs
                .Where(x => x.MaHang.Contains(maHang))
                .Select(h => new HHDto
                {
                    MaHang = h.MaHang,
                    TenHang = h.TenHang,
                    SoLuong = h.SoLuong ?? 0,
                    DonGiaNhap = h.DonGiaNhap ?? 0,
                    DonGiaBan = h.DonGiaBan ?? 0,
                    Hinh = h.Hinh,
                    GhiChu = h.GhiChu,
                    MaChatLieu = h.MaCLieu,
                }).ToList();
        }
        public List<ChatLietDto> GetChatLieu()
        {
            return db.DMChatLieux.Select(c => new ChatLietDto
            {
                MaChatLieu = c.MaCLieu,
                TenChatLieu = c.TenCLieu
            }).ToList();
        }
    }
}
