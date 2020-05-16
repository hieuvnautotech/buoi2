using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace buoi2.Models
{
    public class HangHoa
    {
        public override string ToString() //ghi de cua tinh da hinh poly morphism
        {
            return $"{MaHangHoa} - {TenHangHoa} : {DonGia.ToString("#,###0")} d";
        }
        //automatic property
        public int MaHangHoa { get; set;}
        public string TenHangHoa { get; set;}
        public double DonGia { get; set;}
        public double GiamGia { get; set;}
        //public  GiaBan { get; set;}
        
        //public GiaBan => DonGia  
        public double GiaBan 
        {
            get 
            {
                return DonGia * (1 - GiamGia);
            }
        }




    }
}
