## MVC Razor Syntax Style

## [tag helper](https://docs.microsoft.com/zh-tw/aspnet/core/mvc/views/tag-helpers/intro)

用意：部份取代了原本 [html helper](https://docs.microsoft.com/zh-tw/aspnet/mvc/overview/older-versions-1/views/asp-net-mvc-views-overview-cs#using-html-helpers-to-generate-view-content)

## 範例

1. 瀏覽 /Person
2. 查看 label asp-for="Id" 的語法，與實際產生的 label 語法
3. 其他常用 html tag 可以看看[這裡](https://docs.microsoft.com/zh-tw/aspnet/core/mvc/views/tag-helpers/intro?#built-in-aspnet-core-tag-helpers)
4. 驗證部份，可以看看 tag helper 與 jquery validate unobtrusive 的互動
   - 前端驗證 - jquery validate unobtrusive 負責
   - 與後端驗證 - ModelState 負責

## 補充資料

[Html Helper Properties](https://docs.microsoft.com/en-us/dotnet/api/system.web.mvc.htmlhelper)
