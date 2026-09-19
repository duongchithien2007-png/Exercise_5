using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Module03.bai04
{
    public class Books
    {

        //instrance fields
        public string maSach { get; set; }
        public DateTime ngayNhap { get; set; }
        public double dongia { get; set; }
        public int soLuong { get; set; }
        public string nhaXuatBan { get; set; }
        //constructor
        public Books(string maSach, DateTime ngayNhap, double dongia, int soLuong, string nhaXuatBan)
        {
            this.maSach = maSach;
            this.ngayNhap = ngayNhap;
            this.dongia = dongia;
            this.soLuong = soLuong;
            this.nhaXuatBan = nhaXuatBan;
        }
        public override string ToString()
        {
            return $"Ma sach: {maSach}, Ngay nhap: {ngayNhap.ToShortDateString()}, Don gia: {dongia}, So luong: {soLuong}, Nha xuat ban: {nhaXuatBan}";
        }
    }
    public class Sachgiaokhoa : Books
    {
        //attributes
        public bool tinhTrang { get; set; }
        public Sachgiaokhoa(string maSach, DateTime ngayNhap, double dongia, int soLuong, string nhaXuatBan, bool tinhTrang) : base(maSach, ngayNhap, dongia, soLuong, nhaXuatBan)
        {
            this.tinhTrang = tinhTrang;
        }
        //create a methods to calculate total price of Sachgiaokhoa
        public double TotalPrice()
        {
            double TotalPrice = 0;
            if ( tinhTrang== true)
            {
                TotalPrice = dongia * soLuong;

            }
            else
            {
                TotalPrice = dongia * soLuong * 0.5;
            }
            return TotalPrice;
        }
        public override string ToString()
        {
            
            return base.ToString() + $", Tinh trang: {(tinhTrang ? "Moi" : "Cu")}";
        }
    }
    public class Sachthamkhao : Books
    {
        //attributes
        public double thue { get; set; }
        //constructor 
        public Sachthamkhao(string maSach, DateTime ngayNhap, double dongia, int soLuong, string nhaXuatBan, double thue) : base(maSach, ngayNhap, dongia, soLuong, nhaXuatBan)
        {
            this.thue = thue;
        }
        public override string ToString()
        {
            return base.ToString() + $", Thue: {thue}";
        }

        //create a methods to culcalate AVG of Sachthamkhao
        public double AVGTotalPriceSTK()
        {
            double AVGTotalPriceSTK = 0;
            AVGTotalPriceSTK = (dongia * soLuong + thue * soLuong) / soLuong;
            return AVGTotalPriceSTK;
        }
    }

}
