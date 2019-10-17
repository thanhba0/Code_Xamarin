using System;
using System.Collections.Generic;
using System.Text;

namespace demo1
{
    class LoaiHoa:List<hoa>
    {
        public string TenLoai { get; set; }
        public LoaiHoa(string tenloai)
        {
            TenLoai = tenloai;
        }
        public IList<LoaiHoa> Loaihoas { get; set; }
        public LoaiHoa()
        {
            new LoaiHoa("Hoa cúc")
            {
                new hoa{ TenHoa = "Đón Xuân",Hinh="cuc.jpg", Gia = 50000, MoTa = "Hoa cúc các màu:trắng,vàng cam" },
                new hoa{ TenHoa = "Hồn Nhiên",Hinh="cuc.jpg", Gia = 60000, MoTa = "Hoa cúc các màu:trắng" },
                new hoa{ TenHoa = "Tím Thủy Chung",Hinh="cuc.jpg", Gia = 70000, MoTa = "Hoa cúc tím" }
            };
            new LoaiHoa("Hoa cưới")
            {
                new hoa{ TenHoa = "Dây tơ hồng",Hinh="cuc.jpg", Gia = 80000, MoTa = "Hoa hồng màu hồng đậm, hoa hồng xanh, các loại lá mảng" },
                new hoa{ TenHoa = "Cầu thủy tinh",Hinh="cuc.jpg", Gia = 90000, MoTa = "Hoa hồng và hoa thủy tiên trắng" },
                new hoa{ TenHoa = "Duyên thần",Hinh="cuc.jpg",Gia = 1000000, MoTa = "Hoa cúc trắng,baby, lá mảng" }
            };

        }
    }
}
