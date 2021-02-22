#pragma checksum "E:\project\c#\KH095\Views\Admin\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1d1ab335151e53ae19c69810d8cd54353f0d62e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Dashboard_Index), @"mvc.1.0.view", @"/Views/Admin/Dashboard/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\project\c#\KH095\Views\_ViewImports.cshtml"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\project\c#\KH095\Views\_ViewImports.cshtml"
using KH095;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\project\c#\KH095\Views\_ViewImports.cshtml"
using KH095.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\project\c#\KH095\Views\_ViewImports.cshtml"
using KH095.Extension;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\project\c#\KH095\Views\Admin\Dashboard\Index.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\project\c#\KH095\Views\Admin\Dashboard\Index.cshtml"
using KH095.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1d1ab335151e53ae19c69810d8cd54353f0d62e", @"/Views/Admin/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3777134f5590a2b8b0658cd514a81aa8a3c922e", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\project\c#\KH095\Views\Admin\Dashboard\Index.cshtml"
  
    Layout = "_LayoutAdmin";
    ViewBag.Title = "Dashboard";
    ViewBag.PageName = "TỔNG QUAN";
    ViewBag.Link = "/admin/dashboard";
    var user = ViewData["User"] as User;
    var dataChart  = JsonSerializer.Serialize(ViewBag.Chart_PerMonth);
 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-xl-3 col-md-6"">
        <div class=""text-white mb-4"" style=""background: #3498db"">
            <div class=""card-body"">SẢN PHẨM ĐÃ ĐƯỢC MUA</div>
            <div class=""card-footer d-flex align-items-center justify-content-between"">
                <span class=""small text-white stretched-link"" style=""font-size: 20px;"" >");
#nullable restore
#line 17 "E:\project\c#\KH095\Views\Admin\Dashboard\Index.cshtml"
                                                                                   Write(ViewBag.TotalProduct_Muon);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
            </div>
        </div>
    </div>
    <div class=""col-xl-3 col-md-6"">
        <div class=""card text-white mb-4"" style=""background: #f39c12"">
            <div class=""card-body"">ĐƠN HÀNG CHƯA XỬ LÝ</div>
            <div class=""card-footer d-flex align-items-center justify-content-between"">
                 <span class=""small text-white stretched-link"" style=""font-size: 20px;"">");
#nullable restore
#line 25 "E:\project\c#\KH095\Views\Admin\Dashboard\Index.cshtml"
                                                                                   Write(ViewBag.TotalProduct_Phai_Tra);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
            </div>
        </div>
    </div>
      <div class=""col-xl-3 col-md-6"">
        <div class=""card text-white mb-4"" style=""background-color: #e74c3c;"">
            <div class=""card-body"">ĐƠN HÀNG HỦY</div>
            <div class=""card-footer d-flex align-items-center justify-content-between"">
               <span class=""small text-white stretched-link"" style=""font-size: 20px;"">");
#nullable restore
#line 33 "E:\project\c#\KH095\Views\Admin\Dashboard\Index.cshtml"
                                                                                 Write(ViewBag.TotalProduct_Qua_Han);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
            </div>
        </div>
    </div>
    <div class=""col-xl-3 col-md-6"">
        <div class=""card text-white mb-4"" style=""background-color: #1abc9c;"">
            <div class=""card-body"">KHÁCH HÀNG MỚI</div>
            <div class=""card-footer d-flex align-items-center justify-content-between"">
                <span class=""small text-white stretched-link"" style=""font-size: 20px;"">");
#nullable restore
#line 41 "E:\project\c#\KH095\Views\Admin\Dashboard\Index.cshtml"
                                                                                  Write(ViewBag.TotalNewCustomer);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
            </div>
        </div>
    </div>
</div>
<div class=""row mt-4"">
    <div class=""col-6"">
        <h5 class=""text-center mb-5"" style=""font-weight:400;font-size:19px; color: #414141"">Biểu đồ thống kê lượng sản phẩm và khách hàng trong tuần qua</h5>
        <figure class=""highcharts-figure"">
            <div id=""container""></div>
        </figure>
    </div>
    <div class=""col-6"">
        <h5 class=""text-center mb-5"" style=""font-weight:400; font-size:19px; color: #414141"">Danh sản phẩm sản phẩm được mua nhiều nhất trong tháng</h5>
        <table class=""table"" style=""margin-top: 3.5rem"">
            <thead>
                <tr style='font-size:15px'>
                    <th>#</th>
                    <th>Sản phẩm</th>
                    <th>Lượt mua</th>
                    <th>Số lượng tồn</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 65 "E:\project\c#\KH095\Views\Admin\Dashboard\Index.cshtml"
                  
                     int index = 1;
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "E:\project\c#\KH095\Views\Admin\Dashboard\Index.cshtml"
                 foreach (var item in ViewBag.ListProductOrders)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 71 "E:\project\c#\KH095\Views\Admin\Dashboard\Index.cshtml"
                       Write(index);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 72 "E:\project\c#\KH095\Views\Admin\Dashboard\Index.cshtml"
                       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 73 "E:\project\c#\KH095\Views\Admin\Dashboard\Index.cshtml"
                       Write(item.CountDiscount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 74 "E:\project\c#\KH095\Views\Admin\Dashboard\Index.cshtml"
                       Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 76 "E:\project\c#\KH095\Views\Admin\Dashboard\Index.cshtml"
                    
                    index ++;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n            <tfoot>\r\n\r\n            </tfoot>\r\n        </table>\r\n    </div>\r\n\r\n</div>\r\n\r\n");
            DefineSection("Script", async() => {
                WriteLiteral(@"
    <script src=""https://code.highcharts.com/highcharts.js""></script>
    <script src=""https://code.highcharts.com/modules/export-data.js""></script>
    <script src=""https://code.highcharts.com/modules/accessibility.js""></script>
    <script src=""/assets/helper.js""></script>
    <script>

 

            
        var dataChart = '");
#nullable restore
#line 98 "E:\project\c#\KH095\Views\Admin\Dashboard\Index.cshtml"
                    Write(dataChart);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';
        dataChart = rhtmlspecialchars(dataChart);
        dataChart = JSON.parse(dataChart);

        console.log(dataChart);
        function generateListDay(firstDay,countDay){
            let listDays = [firstDay];
            let i = 1;

            while(i < countDay) {

                firstDay = firstDay.addDays(1);
                listDays.push(firstDay);
                i ++;   
            }

            return  listDays;
        } 


        let categories = generateListDay(FIRST_DAY_OF_WEEK, 7).map(day => formatDate(day));

        function mapDateChart(data,categories) {
                return categories.map(c => {
                    let found = data.filter(d =>  d.Key.substring(0,d.Key.indexOf('T')) == c) ?? [];
                    if(found[0])
                    {
                        return found[0].Count ?? 0;
                    }
                    return 0;
                });
        } 

    

        Highcharts.chart('container', {
           ");
                WriteLiteral(@" chart: {
                type: 'line'
            },
            title: {
                text: ''
            },
            subtitle: {
                text: ''
            },
            xAxis: {
                categories: categories.map(d => formatDateVN(d)),
                tickmarkPlacement: 'on',
                title: {
                    enabled: true
                }
            },
            yAxis: {
                title: {
                    text: 'Số lượng'
                },
                labels: {
                    formatter: function () {
                        return this.value / 1000;
                    }
                }
            },
            tooltip: {
                split: true
            },
            plotOptions: {
                area: {
                    stacking: 'normal',
                    lineColor: '#666666',
                    lineWidth: 1,
                    marker: {
                        lineWidth: 1,
          ");
                WriteLiteral(@"              lineColor: '#666666'
                    }
                }
            },
            series: [{
                name: 'Sản phẩm mua',
                data:  mapDateChart(dataChart.TotalProduct_MuonPerWeek, categories)

            }, {
                name: 'Đơn hàng chưa xử lý',
                data:  mapDateChart(dataChart.TotalProduct_Phai_Tra_PerMonth, categories)

            }, {
                name: 'Đơn hàng hủy',
                data:  mapDateChart(dataChart.TotalProduct_Qua_Han_PerMoth, categories)
            }, {
                name: 'KH mới',
                data:  mapDateChart(dataChart.TotalNewCustomerPerWeek, categories)
            }]
        });
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
