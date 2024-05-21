using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhanSu.Properties
{
    public class listCongBook
    {
        private static listCongBook instance;

        List<CongBook> listNumCNV;
        public List<CongBook> listCNV { get => listNumCNV; set => listNumCNV = value; }

        public static listCongBook Instance
        {
            get
            {
                if (instance == null)
                    instance = new listCongBook();
                return instance;
            }
            set => instance = value;
        }

        private listCongBook()
        {
            listNumCNV = new List<CongBook>();
            listNumCNV.Add(new CongBook("001201", "Nguyen Minh Hieu", "Đã chấm công", "8h00", "17h00"));
            listNumCNV.Add(new CongBook("001202", "Nguyen Duy Tuan", "Chưa chấm công", "", ""));
            listNumCNV.Add(new CongBook("001203", "Nguyen Minh Tien", "Đã chấm công", "8h30", "17h30"));
            listNumCNV.Add(new CongBook("001204", "Nguyen Tien Đat", "Chưa chấm công", "", ""));
            listNumCNV.Add(new CongBook("001205", "Nguyen Ngoc Tuan Anh", "Đã chấm công", "8h00", "17h30"));

        }
    }
}

