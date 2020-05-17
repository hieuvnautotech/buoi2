using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace buoi2.Models
{
    public class HinhHoc
    {
        public static string RandomKey() 
        {
            return $"NN-{new Random().Next()}";
        }
        public double DienTich { get; set; }

        public double ChuVi { get; set; }

        public virtual void TinhDienTichChuVi() //virtual cho phep overide
        {
            
        }

        public override string ToString()
        {
            return $"S = {DienTich}, P = {ChuVi}";
        }
    }//end class hinh hoc

    public class HinhChuNhat : HinhHoc
    {
        public double Dai { get; set; }
        public double Rong { get; set; }

        public override void TinhDienTichChuVi()
        {
            DienTich = Dai * Rong;
            ChuVi = (Dai + Rong) *2;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }//end class hinhchunhat

    public class HinhTron : HinhHoc
    {
        public double BanKinh { get; set; }

        public override void TinhDienTichChuVi()
        {
            DienTich = Math.Pow(BanKinh, 2) * Math.PI;
            ChuVi = 2 * BanKinh * Math.PI;
        }
        public override string ToString()
        {
            return $"R = {BanKinh}, {base.ToString()}";
        }
    }//end class hinhtron
    
}
