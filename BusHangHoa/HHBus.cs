using DAOHangHoa;
using DTOHangHoa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusHangHoa
{
    public class HHBus
    {
        private HHDao dao = new HHDao();
        public List<HHDto> layDanhSach() => dao.GetAll();
        public List<ChatLietDto> LayDSChatLieu() => dao.GetChatLieu();
       
        public void them(HHDto sp)
        {
            if (string.IsNullOrWhiteSpace(sp.MaHang))
                throw new Exception("ma san pham ko dc trong!!");
            dao.Insert(sp);

        }
        public void capnhat(HHDto sp)
        {
            dao.Update(sp);
        }
        public void xoa(string maHang)
        {
            dao.Delete(maHang);
        }
        public List<HHDto> TimKiem(string maHang)
        {
           return dao.Search(maHang);
        }
    }
}