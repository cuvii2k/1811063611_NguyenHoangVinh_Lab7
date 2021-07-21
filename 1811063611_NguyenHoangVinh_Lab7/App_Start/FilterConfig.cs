using System.Web;
using System.Web.Mvc;

namespace _1811063611_NguyenHoangVinh_Lab7
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
