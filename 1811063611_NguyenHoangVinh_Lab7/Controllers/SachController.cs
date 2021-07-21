using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using _1811063611_NguyenHoangVinh_Lab7.Models;

namespace _1811063611_NguyenHoangVinh_Lab7.Controllers
{
    public class SachController : ApiController
    {
        Sach[] sachs = new Sach[]
        {
            new Sach { Id = 1, Title = "Tôi thấy hoa vàng trên xanh cỏ", AuthorName = "Nguyễn Nhật Ánh", Price = 1, Content = "Truyện kể về tuổi thơ... " },
            new Sach { Id = 2, Title = "Pro ASP.Net MVC5", AuthorName = "Adam Freeman", Price = 3.75M, Content = "The ASP.NET MVC5 FrameWork is... " },

        };
        public IEnumerable<Sach> GetAll()
        {
            return sachs;
        }   
        public IHttpActionResult GetSach(int id)
        {
            var sach = sachs.FirstOrDefault(p => p.Id == id);
            if (sach == null)
            {
                return NotFound();
            }
            return Ok(sach);
        }
    }
}
