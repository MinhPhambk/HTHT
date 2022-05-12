#pragma checksum "C:\Users\Admin\source\repos\HTHT\HTHT\Views\Home\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c283027a35e2afca26f4f56d4c2e33f47d9d9ba1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Admin\source\repos\HTHT\HTHT\Views\_ViewImports.cshtml"
using HTHT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\source\repos\HTHT\HTHT\Views\_ViewImports.cshtml"
using HTHT.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c283027a35e2afca26f4f56d4c2e33f47d9d9ba1", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f369fdfdc8c0d6f502418cb63a846dfdb3cb6755", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""container-fluid"">

    <!-- Content Row -->

    <div class=""row"">
        <!-- Area Chart -->
        <div class=""col-xl-8 col-lg-7"">
            <div class=""card shadow mb-4"">
                <!-- Card Header - Dropdown -->
                <div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
                    <h6 class=""m-0 font-weight-bold"" style=""color: rgb(202, 80, 16); font-size: 1.1rem !important;"">SỰ KIỆN SẮP TỚI VÀ ĐANG DIỄN RA</h6>
                </div>
                <!-- Card Body -->
                <div class=""card-body"">
                    <div id=""carouselExampleCaptions"" class=""carousel slide"" data-bs-ride=""carousel"">
                        <div class=""carousel-indicators"">
                            <button type=""button"" data-bs-target=""#carouselExampleCaptions"" data-bs-slide-to=""0"" class=""active"" aria-current=""true"" aria-label=""Slide 1""></button>
                            <button type=""button"" data-bs-target=""#carouselExampleCaptions");
            WriteLiteral(@""" data-bs-slide-to=""1"" aria-label=""Slide 2""></button>
                            <button type=""button"" data-bs-target=""#carouselExampleCaptions"" data-bs-slide-to=""2"" aria-label=""Slide 3""></button>
                        </div>
                        <div class=""carousel-inner"">
                            <div class=""carousel-item active"">
                                <img src=""/img/content.png"" class=""d-block w-100"" alt=""..."">
                                <div class=""carousel-caption d-none d-md-block"">
                                    <h5>First slide label</h5>
                                    <p>Some representative placeholder content for the first slide.</p>
                                </div>
                            </div>
                            <div class=""carousel-item"">
                                <img src=""/img/content.png"" class=""d-block w-100"" alt=""..."">
                                <div class=""carousel-caption d-none d-md-block"">
                                  ");
            WriteLiteral(@"  <h5>Second slide label</h5>
                                    <p>Some representative placeholder content for the second slide.</p>
                                </div>
                            </div>
                            <div class=""carousel-item"">
                                <img src=""/img/content.png"" class=""d-block w-100"" alt=""..."">
                                <div class=""carousel-caption d-none d-md-block"">
                                    <h5>Third slide label</h5>
                                    <p>Some representative placeholder content for the third slide.</p>
                                </div>
                            </div>
                        </div>
                        <button class=""carousel-control-prev"" type=""button"" data-bs-target=""#carouselExampleCaptions"" data-bs-slide=""prev"">
                            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                            <span class=""visually-hidden"">Previous</span>
   ");
            WriteLiteral(@"                     </button>
                        <button class=""carousel-control-next"" type=""button"" data-bs-target=""#carouselExampleCaptions"" data-bs-slide=""next"">
                            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                            <span class=""visually-hidden"">Next</span>
                        </button>
                    </div>
                </div>
            </div>
        </div>

        <!-- Calendar -->
        <div class=""col-xl-4 col-lg-5"">
            <div class=""card shadow mb-4"">
                <!-- Card Header - Dropdown -->
                <div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
                    <h6 class=""m-0 font-weight-bold"" style=""color: rgb(202, 80, 16); font-size: 1.1rem !important;"">LỊCH HỌC</h6>
                </div>
                <!-- Card Body -->
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col");
            WriteLiteral(@"-3"">
                            <img src=""/img/Lichhoc.png"" class=""d-block w-100"" style=""border-radius: 2px;"">
                        </div>
                        <div class=""col-9"">
                            <ul style=""list-style-type: none; padding-left: 0px !important;"">
                                <li style=""font-weight: bold; font-size: 0.8rem;"">Không có sự kiện sắp tới</li>
                                <li style=""font-weight: 200; font-size: 0.7rem"">Không có sự kiện sắp tới đã lên lịch. Hãy kiểm tra lại sau.</li>
                            </ul>
                        </div>
                    </div>

                    <div class=""row"">
                        <div class=""col-3"">
                            <img src=""/img/Lichhoc.png"" class=""d-block w-100"" style=""border-radius: 2px;"">
                        </div>
                        <div class=""col-9"">
                            <ul style=""list-style-type: none; padding-left: 0px !important;"">
                                <li");
            WriteLiteral(@" style=""font-weight: bold; font-size: 0.8rem;"">Không có sự kiện sắp tới</li>
                                <li style=""font-weight: 200; font-size: 0.7rem"">Không có sự kiện sắp tới đã lên lịch. Hãy kiểm tra lại sau.</li>
                            </ul>
                        </div>
                    </div>

                    <div class=""row"">
                        <div class=""col-3"">
                            <img src=""/img/Lichhoc.png"" class=""d-block w-100"" style=""border-radius: 2px;"">
                        </div>
                        <div class=""col-9"">
                            <ul style=""list-style-type: none; padding-left: 0px !important;"">
                                <li style=""font-weight: bold; font-size: 0.8rem;"">Không có sự kiện sắp tới</li>
                                <li style=""font-weight: 200; font-size: 0.7rem"">Không có sự kiện sắp tới đã lên lịch. Hãy kiểm tra lại sau.</li>
                            </ul>
                        </div>
                    </div>

 ");
            WriteLiteral(@"                   <div class=""row position-absolute bottom-0 start-50 translate-middle-x"">
                        <a class=""test"" style=""color:rgb(202, 80, 16) ; font-size: small; font-weight: bold;"" href=""#"">
                            <u>Xem tất cả</u>
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- Content Row -->

    <div class=""row"">
        <!-- Subject -->
        <div class=""col"">
            <div class=""card shadow mb-4"">
                <!-- Card Header - Dropdown -->
                <div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
                    <h6 class=""m-0 font-weight-bold"" style=""color: #d06228; font-size: 1.2rem !important;"">CÁC MÔN HỌC HỖ TRỢ</h6>
                </div>
                <!-- Card Body -->
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col-xl col-md-12 mt-2"">
                  ");
            WriteLiteral(@"          <button type=""button"" class=""card w-100 subject"" style=""padding: 18px;"">
                                <p class=""position-absolute top-50 start-50 translate-middle w-100"">Đại số</p>
                            </button>
                        </div>
                        <div class=""col-xl col-md-12 mt-2"">
                            <button type=""button"" class=""card w-100 subject"" style=""padding: 18px;"">
                                <p class=""position-absolute top-50 start-50 translate-middle w-100"">Xác suất thống kê</p>
                            </button>
                        </div>
                        <div class=""col-xl col-md-12 mt-2"">
                            <button type=""button"" class=""card w-100 subject"" style=""padding: 18px;"">
                                <p class=""position-absolute top-50 start-50 translate-middle w-100"">Giải tích 1</p>
                            </button>
                        </div>
                        <div class=""col-xl col-md-12 mt-2"">
   ");
            WriteLiteral(@"                         <button type=""button"" class=""card w-100 subject"" style=""padding: 18px;"">
                                <p class=""position-absolute top-50 start-50 translate-middle w-100"">Giải tích 2</p>
                            </button>
                        </div>
                        <div class=""col-xl col-md-12 mt-2"">
                            <button type=""button"" class=""card w-100 subject"" style=""padding: 18px;"">
                                <p class=""position-absolute top-50 start-50 translate-middle w-100"">Giải tích 3</p>
                            </button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class=""row"">
        <!-- Activities -->
        <div class=""col"">
            <div class=""card shadow mb-4"">
                <!-- Card Header - Dropdown -->
                <div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
                    <h6 cl");
            WriteLiteral(@"ass=""m-0 font-weight-bold"" style=""color: #d06228; font-size: 1.2rem !important;"">HOẠT ĐỘNG HỖ TRỢ HỌC TẬP</h6>
                </div>
                <!-- Card Body -->
                <div class=""card-body"">
                    <p style=""font-weight: bold;"">Hoạt động xuyên suốt của CLB Hỗ trợ Học tập</p>
                    <p>Tổ chức các lớp đại cương ngoài giờ, hỗ trợ các bạn sinh viên trên Group, Fanpage <a class=""link-text"" href=""https://www.facebook.com/clbhotrohoctap"">Hỗ trợ Học tập Bách khoa</a>, và một kênh <a class=""link-text"" href=""https://www.youtube.com/channel/UCQSryg4n5u4Gb0mmZqLMHmA"">YouTube</a> chia sẻ những kiến thức, kỹ năng vô cùng bổ ích cho các bạn sinh viên.</p>
                    <div class=""row"">
                        <div class=""col-xl-4 col-md-12 mt-2"">
                            <iframe src=""https://youtube.com/embed/dKwZm3wYQFo""></iframe>
                        </div>
                        <div class=""col-xl-4 col-md-12 mt-2"">
                            <iframe src=""https:");
            WriteLiteral(@"//youtube.com/embed/VAtXvW9oS0Q""></iframe>
                        </div>
                        <div class=""col-xl-4 col-md-12 mt-2"">
                            <iframe src=""https://youtube.com/embed/tA2TnEzQin0""></iframe>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<style>
    a.link-text {
        color: #d06228;
    }
    button.subject {
        color: white;
        font-weight: bold;
        background-color: #d06228 !important;
        border-radius: 4px;
        font-size: 14px;
    }

        .subject:hover {
            border: 2px solid #d06228;
            background-color: white !important;
            color: #d06228;
        }
</style>");
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
