#pragma checksum "C:\Users\ASUS\OneDrive\Рабочий стол\be_28-10-2021_backendproject-HuseynRM\ProjectEndVersion\ProjectFinal\ProjectFinal\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9197e9e3b7580d3af58d902a2f7296d72d7d3208"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\ASUS\OneDrive\Рабочий стол\be_28-10-2021_backendproject-HuseynRM\ProjectEndVersion\ProjectFinal\ProjectFinal\Views\_ViewImports.cshtml"
using ProjectFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\OneDrive\Рабочий стол\be_28-10-2021_backendproject-HuseynRM\ProjectEndVersion\ProjectFinal\ProjectFinal\Views\_ViewImports.cshtml"
using ProjectFinal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\OneDrive\Рабочий стол\be_28-10-2021_backendproject-HuseynRM\ProjectEndVersion\ProjectFinal\ProjectFinal\Views\_ViewImports.cshtml"
using ProjectFinal.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9197e9e3b7580d3af58d902a2f7296d72d7d3208", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1172ae40a517d0fe8d560ded16bd415746e2d2a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("slider"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/icon/section.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("section-title"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("about"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100%;height:500px !important"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("testimonial"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\ASUS\OneDrive\Рабочий стол\be_28-10-2021_backendproject-HuseynRM\ProjectEndVersion\ProjectFinal\ProjectFinal\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n<!-- Background Area Start -->\r\n<section id=\"slider-container\" class=\"slider-area three\">\r\n    <div class=\"slider-owl owl-theme owl-carousel\">\r\n");
#nullable restore
#line 16 "C:\Users\ASUS\OneDrive\Рабочий стол\be_28-10-2021_backendproject-HuseynRM\ProjectEndVersion\ProjectFinal\ProjectFinal\Views\Home\Index.cshtml"
         foreach (var item in Model.Sliders)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"single-slide item\"");
            BeginWriteAttribute("style", " style=\"", 374, "\"", 457, 4);
            WriteAttributeValue("", 382, "background-image:", 382, 17, true);
            WriteAttributeValue(" ", 399, "url(", 400, 5, true);
#nullable restore
#line 18 "C:\Users\ASUS\OneDrive\Рабочий стол\be_28-10-2021_backendproject-HuseynRM\ProjectEndVersion\ProjectFinal\ProjectFinal\Views\Home\Index.cshtml"
WriteAttributeValue("", 404, Html.Raw("/uploads/slider/"+@item.BackgroundImage), 404, 51, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 455, ")", 456, 2, true);
            EndWriteAttribute();
            WriteLiteral(@">
                <!-- Start Slider Content -->
                <div class=""slider-content-area"">
                    <div class=""container"">
                        <div class=""row"">
                            <div class=""col-md-7"">
                                <div class=""slide-content-wrapper"">
                                    <div class=""slide-content"">
                                        <h2>");
#nullable restore
#line 26 "C:\Users\ASUS\OneDrive\Рабочий стол\be_28-10-2021_backendproject-HuseynRM\ProjectEndVersion\ProjectFinal\ProjectFinal\Views\Home\Index.cshtml"
                                       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2>\r\n                                        <p>");
#nullable restore
#line 27 "C:\Users\ASUS\OneDrive\Рабочий стол\be_28-10-2021_backendproject-HuseynRM\ProjectEndVersion\ProjectFinal\ProjectFinal\Views\Home\Index.cshtml"
                                      Write(item.Context);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
                                        <a class=""default-btn"" href=""about.html"">Learn more</a>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-md-5"">
                                <div class=""slider-img"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9197e9e3b7580d3af58d902a2f7296d72d7d32088684", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1332, "~/uploads/slider/", 1332, 17, true);
#nullable restore
#line 34 "C:\Users\ASUS\OneDrive\Рабочий стол\be_28-10-2021_backendproject-HuseynRM\ProjectEndVersion\ProjectFinal\ProjectFinal\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1349, item.OverImage, 1349, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 41 "C:\Users\ASUS\OneDrive\Рабочий стол\be_28-10-2021_backendproject-HuseynRM\ProjectEndVersion\ProjectFinal\ProjectFinal\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
</section>
<!-- Background Area End -->
<!-- Courses Area Start -->
<div class=""courses-area pt-150 text-center"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <div class=""section-title"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9197e9e3b7580d3af58d902a2f7296d72d7d320811078", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <h2>COURSES WE OFFER</h2>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            ");
#nullable restore
#line 57 "C:\Users\ASUS\OneDrive\Рабочий стол\be_28-10-2021_backendproject-HuseynRM\ProjectEndVersion\ProjectFinal\ProjectFinal\Views\Home\Index.cshtml"
       Write(await Html.PartialAsync("CoursesWeOfferPartial", Model.Courses));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </div>
</div>
<!-- Courses Area End -->
<!-- Notice Start -->
<section class=""notice-area two three pt-140 pb-100"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6 col-sm-6 col-xs-12"">
                <div class=""notice-right-wrapper mb-25 pb-25"">
                    <h3>TAKE A VIDEO TOUR</h3>
                    <div class=""notice-video"">
                        <div class=""video-icon video-hover"">
                            <a class=""video-popup""");
            BeginWriteAttribute("href", " href=\"", 2652, "\"", 2686, 1);
#nullable restore
#line 71 "C:\Users\ASUS\OneDrive\Рабочий стол\be_28-10-2021_backendproject-HuseynRM\ProjectEndVersion\ProjectFinal\ProjectFinal\Views\Home\Index.cshtml"
WriteAttributeValue("", 2659, Model.Settings[0].VideoUrl, 2659, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                <i class=""zmdi zmdi-play""></i>
                            </a>
                            class: videorl context datetime
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-6 col-sm-6 col-xs-12"">
                <div class=""notice-left-wrapper"">
                    <h3>notice board</h3>
                    <div class=""notice-left"">
");
#nullable restore
#line 83 "C:\Users\ASUS\OneDrive\Рабочий стол\be_28-10-2021_backendproject-HuseynRM\ProjectEndVersion\ProjectFinal\ProjectFinal\Views\Home\Index.cshtml"
                          int count = 0; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "C:\Users\ASUS\OneDrive\Рабочий стол\be_28-10-2021_backendproject-HuseynRM\ProjectEndVersion\ProjectFinal\ProjectFinal\Views\Home\Index.cshtml"
                         foreach (var item in Model.NoticeBoardItems)
                        {
                            count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"single-notice-left mb-23 pb-20\">\r\n                                <h4>");
#nullable restore
#line 88 "C:\Users\ASUS\OneDrive\Рабочий стол\be_28-10-2021_backendproject-HuseynRM\ProjectEndVersion\ProjectFinal\ProjectFinal\Views\Home\Index.cshtml"
                               Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 88 "C:\Users\ASUS\OneDrive\Рабочий стол\be_28-10-2021_backendproject-HuseynRM\ProjectEndVersion\ProjectFinal\ProjectFinal\Views\Home\Index.cshtml"
                                       Write(item.CreatedAt.ToString("MMMM  yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                <p>");
#nullable restore
#line 89 "C:\Users\ASUS\OneDrive\Рабочий стол\be_28-10-2021_backendproject-HuseynRM\ProjectEndVersion\ProjectFinal\ProjectFinal\Views\Home\Index.cshtml"
                              Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n");
#nullable restore
#line 91 "C:\Users\ASUS\OneDrive\Рабочий стол\be_28-10-2021_backendproject-HuseynRM\ProjectEndVersion\ProjectFinal\ProjectFinal\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Notice End -->
<!-- About Start -->
<div class=""about-area pb-135 pt-130 bg-light"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6 col-sm-6"">
                <div class=""about-content"">
");
#nullable restore
#line 107 "C:\Users\ASUS\OneDrive\Рабочий стол\be_28-10-2021_backendproject-HuseynRM\ProjectEndVersion\ProjectFinal\ProjectFinal\Views\Home\Index.cshtml"
                      
                        int a = Model.AboutEduHomeForHomePage.Title.IndexOf(" ");
                        int b = Model.AboutEduHomeForHomePage.Title.Length - a;
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h2><span>");
#nullable restore
#line 111 "C:\Users\ASUS\OneDrive\Рабочий стол\be_28-10-2021_backendproject-HuseynRM\ProjectEndVersion\ProjectFinal\ProjectFinal\Views\Home\Index.cshtml"
                         Write(Model.AboutEduHomeForHomePage.Title.Substring(0, a + 1));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> ");
#nullable restore
#line 111 "C:\Users\ASUS\OneDrive\Рабочий стол\be_28-10-2021_backendproject-HuseynRM\ProjectEndVersion\ProjectFinal\ProjectFinal\Views\Home\Index.cshtml"
                                                                                         Write(Model.AboutEduHomeForHomePage.Title.Substring(a + 1, b - 1));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <p>");
#nullable restore
#line 112 "C:\Users\ASUS\OneDrive\Рабочий стол\be_28-10-2021_backendproject-HuseynRM\ProjectEndVersion\ProjectFinal\ProjectFinal\Views\Home\Index.cshtml"
                  Write(Model.AboutEduHomeForHomePage.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    <a class=""default-btn"" href=""about.html"">buy now</a>
                </div>
            </div>
            <style>
                .about-img:after {
                    height: 500px;
                }
            </style>
            <div class=""col-md-6 col-sm-6"">
                <div class=""about-img"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9197e9e3b7580d3af58d902a2f7296d72d7d320818573", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4764, "~/uploads/aboutEduHome/", 4764, 23, true);
#nullable restore
#line 123 "C:\Users\ASUS\OneDrive\Рабочий стол\be_28-10-2021_backendproject-HuseynRM\ProjectEndVersion\ProjectFinal\ProjectFinal\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 4787, Model.AboutEduHomeForHomePage.Image, 4787, 36, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
</div>
<!-- About End -->
<!-- Event Area Start -->
<div class=""event-area three text-center pt-100 pb-115"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <div class=""section-title"">
                    <img src=""img/icon/section.png"" alt=""section-title"">
                    <h2>UPCOMMING EVENTS</h2>
                </div>
            </div>
        </div>
        <div class=""row"">
            ");
#nullable restore
#line 142 "C:\Users\ASUS\OneDrive\Рабочий стол\be_28-10-2021_backendproject-HuseynRM\ProjectEndVersion\ProjectFinal\ProjectFinal\Views\Home\Index.cshtml"
       Write(await Html.PartialAsync("UpComingPartial", Model.Events));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </div>s
</div>
<!-- Event Area End -->
<!-- Testimonial Area Start -->
<div class=""testimonial-area three pt-110 pb-105 text-center"">
    <div class=""container"">
        <div class=""row"">
            <div class=""testimonial-owl owl-theme owl-carousel"">
");
#nullable restore
#line 152 "C:\Users\ASUS\OneDrive\Рабочий стол\be_28-10-2021_backendproject-HuseynRM\ProjectEndVersion\ProjectFinal\ProjectFinal\Views\Home\Index.cshtml"
                 foreach (var item in Model.Testimonials)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-md-8 col-md-offset-2 col-sm-12"">
                        <div class=""single-testimonial"">
                            <div class=""testimonial-info"">
                                <div class=""testimonial-img"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9197e9e3b7580d3af58d902a2f7296d72d7d320822130", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6140, "~/uploads/testimonial/", 6140, 22, true);
#nullable restore
#line 158 "C:\Users\ASUS\OneDrive\Рабочий стол\be_28-10-2021_backendproject-HuseynRM\ProjectEndVersion\ProjectFinal\ProjectFinal\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 6162, item.Image, 6162, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"testimonial-content\">\r\n                                    <p>");
#nullable restore
#line 161 "C:\Users\ASUS\OneDrive\Рабочий стол\be_28-10-2021_backendproject-HuseynRM\ProjectEndVersion\ProjectFinal\ProjectFinal\Views\Home\Index.cshtml"
                                  Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <h4>");
#nullable restore
#line 162 "C:\Users\ASUS\OneDrive\Рабочий стол\be_28-10-2021_backendproject-HuseynRM\ProjectEndVersion\ProjectFinal\ProjectFinal\Views\Home\Index.cshtml"
                                   Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                    <h5>");
#nullable restore
#line 163 "C:\Users\ASUS\OneDrive\Рабочий стол\be_28-10-2021_backendproject-HuseynRM\ProjectEndVersion\ProjectFinal\ProjectFinal\Views\Home\Index.cshtml"
                                   Write(item.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 168 "C:\Users\ASUS\OneDrive\Рабочий стол\be_28-10-2021_backendproject-HuseynRM\ProjectEndVersion\ProjectFinal\ProjectFinal\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

            </div>
        </div>
    </div>
</div>
<!-- Testimonial Area End -->
<!-- Blog Area Start -->
<div class=""blog-area pt-150 pb-150"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <div class=""section-title text-center"">
                    <img src=""img/icon/section.png"" alt=""section-title"">
                    <h2>LATEST FROM BLOG</h2>
                </div>
            </div>
        </div>
        <div class=""row"">
            ");
#nullable restore
#line 188 "C:\Users\ASUS\OneDrive\Рабочий стол\be_28-10-2021_backendproject-HuseynRM\ProjectEndVersion\ProjectFinal\ProjectFinal\Views\Home\Index.cshtml"
       Write(await Html.PartialAsync("LatestFromBlogPartial", Model.Events));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Blog Area End -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
