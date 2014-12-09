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
    <error statusCode="404" path="../Error?source=IIS&amp;statusCode=404" responseMode="Redirect"/>
    <error statusCode="500" path="../Error?source=IIS&amp;statusCode=500" responseMode="Redirect"/>
  </httpErrors>
</system.webServer>
```

License
-------
under [MIT License](http://opensource.org/licenses/MIT)
