using System.Web.Mvc;

namespace WebApplication
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            // エラーをカスタムするので標準のハンドルは使用しない
            //filters.Add(new HandleErrorAttribute());
        }
    }
}
