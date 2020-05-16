using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using buoi2.Models;
using Microsoft.AspNetCore.Mvc;

namespace buoi2.Controllers
{
    public class demoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DemoHinhHoc()
        {
            return View();
        }
        public IActionResult LayMot() 
        {
            //doc csdl/file
            var HH = new buoi2.Models.HangHoa
            {
                MaHangHoa = 1,
                TenHangHoa = "toshiba",
                DonGia = 17900
            };
            // do sang view hien thi
            return View(HH);
        }
        public IActionResult DanhSach()
        {
            List<HangHoa> danhsach = new
                List<HangHoa>();
            HangHoa tmp;
            var rd = new Random();
            // sinh so phan tu ngau nhien tu 3 den 10
            var soPhanTu = rd.Next(3,11);
            for ( int i = 0; i < soPhanTu; i ++) 
            {
                tmp = new HangHoa
                {
                    MaHangHoa = i + 100,
                    TenHangHoa = $"samsung {rd.Next()}",
                    DonGia = rd.NextDouble() * 10000000,
                    GiamGia = rd.NextDouble()
                };
                danhsach.Add(tmp); // them vao mang

            }
            return View(danhsach);
        }

    }
}