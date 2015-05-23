aspnet-CustomErrorsSample
=========================

ASP.NET の customErrors、IIS の httpErrors のサンプルです。

```xml
<!-- ASP.NET -->
<system.web>
  <customErrors mode="RemoteOnly">
    <error statusCode="404" redirect="~/Error?source=MVC&amp;statusCode=404"/>
    <error statusCode="500" redirect="~/Error?source=MVC&amp;statusCode=500"/>
  </customErrors>
</system.web>
```

```xml
<!-- IIS -->
<system.webServer>
  <httpErrors errorMode="Custom">
    <remove statusCode="404"/>
    <remove statusCode="500"/>
    <error statusCode="404" path="http://localhost:60786/Error?source=IIS&amp;statusCode=404" responseMode="Redirect"/>
    <error statusCode="500" path="http://localhost:60786/Error?source=IIS&amp;statusCode=500" responseMode="Redirect"/>
  </httpErrors>
</system.webServer>
```

動作を確認できるようにパラメーターを利用しています。通常は ASP.NET と IIS のエラーを区別する必要はないでしょう。

```csharp
public class ErrorController : Controller
{
    public ActionResult Index(string source, int statusCode)
    {
        ViewBag.Source = source;
        ViewBag.StatusCode = statusCode;

        return View();
    }
}
```

詳細はこちらへ
- [commit カスタムエラーを構成](https://github.com/KatsuYuzu/aspnet-CustomErrorsSample/commit/7ae6a2cd133d017c4bbdc13c1fd5d0b08a3d55e5)
- [ASP.NET の customErrors、IISの httpErrors #aspnetjp - KatsuYuzuのブログ](http://katsuyuzu.hatenablog.jp/entry/2014/12/10/080000)

License
-------
under [MIT License](http://opensource.org/licenses/MIT)
