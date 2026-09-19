using System;
using System.Collections.Generic;
using System.Text;

namespace Module03.bai01
{
    public class Quanlichuyenxe
    {
        // instance fields
        public string Masochuyen;
        public string Hotentaixe;
        public string Soxe;
        public double Doanhthu;

        //Constructor
        public Quanlichuyenxe(string masochuyen,string hotentaixe , string soxe , double doanhthu)
        {
            Masochuyen = masochuyen;
            Hotentaixe = hotentaixe;
            Soxe = soxe;
            Doanhthu = doanhthu;
        }
    }
    public class Chuyenxenoithanh : Quanlichuyenxe
    {
        //instance fields
        public string Sotuyen;
        public double Sokmdiduoc;
        //Constructor
        public Chuyenxenoithanh(string masochuyen, string hotentaixe, string soxe, double doanhthu, string sotuyen, double sokmdiduoc) : base(masochuyen, hotentaixe, soxe, doanhthu)
        {
            Sotuyen = sotuyen;
            Sokmdiduoc = sokmdiduoc;
        }
    }
    public class Chuyenxengoaithanh : Quanlichuyenxe
    {
        //state (instance) fields - attributes/properties
        public string Noiden;
        public int Songaydiduoc;
        //Constructor
        public Chuyenxengoaithanh (string masochuyen, string hotentaixe, string soxe, double doanhthu, string noiden, int songaydiduoc) : base(masochuyen, hotentaixe, soxe, doanhthu)
        {
            Noiden = noiden;
            Songaydiduoc = songaydiduoc;
        }
    }
}
