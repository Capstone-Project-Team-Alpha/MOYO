#pragma checksum "C:\Users\ojewu\Source\Repos\Capstone-Project-Team-Alpha\MOYO\Pages\WelcomePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "244f8393e2cd568b50f1c722d652be96bb966bf9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MOYO_Website.Pages.Pages_WelcomePage), @"mvc.1.0.razor-page", @"/Pages/WelcomePage.cshtml")]
namespace MOYO_Website.Pages
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
#line 1 "C:\Users\ojewu\Source\Repos\Capstone-Project-Team-Alpha\MOYO\Pages\_ViewImports.cshtml"
using MOYO_Website;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"244f8393e2cd568b50f1c722d652be96bb966bf9", @"/Pages/WelcomePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e190389a652ec56b1ae73a0f8c93fc461be42a46", @"/Pages/_ViewImports.cshtml")]
    public class Pages_WelcomePage : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/home.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "244f8393e2cd568b50f1c722d652be96bb966bf94319", async() => {
                WriteLiteral(@"
    <title>MOYO Welcome Page</title>
    <meta name=""description"" content=""MOYO Yoga"" />
    <meta property=""og:title"" content=""MOYO Welcome Page"" />
    <meta property=""og:description"" content=""MOYO Yoga"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <meta charset=""utf-8"" />
    <meta property=""twitter:card"" content=""summary_large_image"" />

    <style data-tag=""reset-style-sheet"">
        html {
            line-height: 1.15;
        }

        body {
            margin: 0;
        }

        * {
            box-sizing: border-box;
            border-width: 0;
            border-style: solid;
        }

        p, li, ul, pre, div, h1, h2, h3, h4, h5, h6, figure, blockquote, figcaption {
            margin: 0;
            padding: 0;
        }

        button {
            background-color: transparent;
        }

        button, input, optgroup, select, textarea {
            font-family: inherit;
            font-size: 100%;
      ");
                WriteLiteral(@"      line-height: 1.15;
            margin: 0;
        }

        button, select {
            text-transform: none;
        }

        button, [type=""button""], [type=""reset""], [type=""submit""] {
            -webkit-appearance: button;
        }

            button::-moz-focus-inner, [type=""button""]::-moz-focus-inner, [type=""reset""]::-moz-focus-inner, [type=""submit""]::-moz-focus-inner {
                border-style: none;
                padding: 0;
            }

            button:-moz-focus, [type=""button""]:-moz-focus, [type=""reset""]:-moz-focus, [type=""submit""]:-moz-focus {
                outline: 1px dotted ButtonText;
            }

        a {
            color: inherit;
            text-decoration: inherit;
        }

        input {
            padding: 2px 4px;
        }

        img {
            display: block;
        }

        html {
            scroll-behavior: smooth
        }
    </style>
    <style data-tag=""default-style-sheet"">
        html {
      ");
                WriteLiteral(@"      font-family: Open Sans;
            font-size: 18px;
        }

        body {
            font-weight: 400;
            font-style: normal;
            text-decoration: none;
            text-transform: none;
            letter-spacing: normal;
            line-height: 1.55;
            color: var(--dl-color-gray-black);
            background-color: var(--dl-color-gray-white);
        }
    </style>
    <link rel=""stylesheet""
          href=""https://fonts.googleapis.com/css2?family=Open+Sans:ital,wght@0,300;0,400;0,600;0,700;0,800;1,300;1,400;1,600;1,700;1,800&amp;display=swap""
          data-tag=""font"" />
    <link rel=""stylesheet""
          href=""https://fonts.googleapis.com/css2?family=Cedarville+Cursive&display=swap""
          data-tag=""font"" />
    <style>
        html {
            scroll-behavior: smooth;
        }
    </style>
    <style data-section-id=""dropdown"">
        [data-thq=""thq-dropdown""]:hover > [data-thq=""thq-dropdown-list""] {
            display: flex;");
                WriteLiteral("\n        }\r\n\r\n        [data-thq=\"thq-dropdown\"]:hover > div [data-thq=\"thq-dropdown-arrow\"] {\r\n            transform: rotate(90deg);\r\n        }\r\n    </style>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "244f8393e2cd568b50f1c722d652be96bb966bf97995", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "244f8393e2cd568b50f1c722d652be96bb966bf99877", async() => {
                WriteLiteral("\r\n    <div>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "244f8393e2cd568b50f1c722d652be96bb966bf910156", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

        <div class=""home-container"">
            <div data-role=""Header"" class=""home-navbar-container"">
                <div class=""home-navbar"">
                    <div class=""home-logo"">
                        <img alt=""image""
                             src=""images/Safiya-Yoga Pose-3-small.PNG""
                             class=""home-image"" />
                    </div>
                    <div data-thq=""thq-dropdown"" class=""home-thq-dropdown list-item"">
                        <div data-thq=""thq-dropdown-toggle"" class=""home-dropdown-toggle"">
                            <span class=""home-text"">Appointments</span>
                            <div data-thq=""thq-dropdown-arrow"" class=""home-dropdown-arrow"">
                                <svg viewBox=""0 0 1024 1024"" class=""home-icon"">
                                    <path d=""M426 726v-428l214 214z""></path>
                                </svg>
                            </div>
                        </div>
                     ");
                WriteLiteral("   <ul data-thq=\"thq-dropdown-list\" class=\"home-dropdown-list\">\r\n");
                WriteLiteral(@"                            <li data-thq=""thq-dropdown"" class=""home-dropdown list-item"">
                                <div data-thq=""thq-dropdown-toggle""
                                     class=""home-dropdown-toggle1"">
                                    <a href=""BookAppointment"" class=""home-link"">Book Appointment</a>
                                </div>
                            </li>
");
                WriteLiteral(@"                            <li data-thq=""thq-dropdown"" class=""home-dropdown1 list-item"">
                                <div data-thq=""thq-dropdown-toggle""
                                     class=""home-dropdown-toggle2"">
                                    <a href=""CreateSchedule"" class=""home-link"">View Appointments</a>
                                </div>
                            </li>
");
                WriteLiteral(@"                            <li data-thq=""thq-dropdown"" class=""home-dropdown2 list-item"">
                                <div data-thq=""thq-dropdown-toggle""
                                     class=""home-dropdown-toggle3"">
                                    <a href=""UpdateAppointment"" class=""home-link"">Update Appointment</a>
                                </div>
                            </li>
                        </ul>
                        </ul>
                    </div>
                    <a href=""WelcomePage"" class=""home-link"">Home</a>
                    <a href=""AboutMe"" class=""home-link"">About Me</a>
                    <a href=""Contact"" class=""home-link1"">Contact Me</a>
                    <a href=""Login"" class=""home-link1"">Login</a>
                    
                    <div class=""home-cta-container"">
");
                WriteLiteral(@"                        <button id=""signup""
                                name=""signup""
                                type=""button""
                                onclick=""window.location.href = 'MembershipRegistration';""
                                class=""home-cta-btn button Anchor"">
                            Sign Up
                        </button>
                        <div data-role=""BurgerMenu"" class=""home-burger-menu"">
                            <svg viewBox=""0 0 1024 1024"" class=""home-icon02"">
                                <path d=""M128 256h768v86h-768v-86zM128 554v-84h768v84h-768zM128 768v-86h768v86h-768z""></path>
                            </svg>
                        </div>
                    </div>
                    <div data-role=""MobileMenu"" class=""home-mobile-menu"">
                        <div class=""home-top"">
                            <img alt=""image""
                                 src=""public/playground_assets/default-img.svg""
                     ");
                WriteLiteral(@"            class=""home-image1"" />
                            <div data-role=""CloseMobileMenu"" class=""home-container3"">
                                <svg viewBox=""0 0 1024 1024"" class=""home-icon04"">
                                    <path d=""M810 274l-238 238 238 238-60 60-238-238-238 238-60-60 238-238-238-238 60-60 238 238 238-238z""></path>
                                </svg>
                            </div>
                        </div>

                        <div class=""home-bot"">
                            <div class=""home-social-links-container"">
                                <svg viewBox=""0 0 950.8571428571428 1024"" class=""home-icon06"">
                                    <path d=""M925.714 233.143c-25.143 36.571-56.571 69.143-92.571 95.429 0.571 8 0.571 16 0.571 24 0 244-185.714 525.143-525.143 525.143-104.571 0-201.714-30.286-283.429-82.857 14.857 1.714 29.143 2.286 44.571 2.286 86.286 0 165.714-29.143 229.143-78.857-81.143-1.714-149.143-54.857-172.571-128 11.429 1.714 22.85");
                WriteLiteral(@"7 2.857 34.857 2.857 16.571 0 33.143-2.286 48.571-6.286-84.571-17.143-148-91.429-148-181.143v-2.286c24.571 13.714 53.143 22.286 83.429 23.429-49.714-33.143-82.286-89.714-82.286-153.714 0-34.286 9.143-65.714 25.143-93.143 90.857 112 227.429 185.143 380.571 193.143-2.857-13.714-4.571-28-4.571-42.286 0-101.714 82.286-184.571 184.571-184.571 53.143 0 101.143 22.286 134.857 58.286 41.714-8 81.714-23.429 117.143-44.571-13.714 42.857-42.857 78.857-81.143 101.714 37.143-4 73.143-14.286 106.286-28.571z""></path>
                                </svg><svg viewBox=""0 0 877.7142857142857 1024""
                                           class=""home-icon08"">
                                    <path d=""M713.143 73.143c90.857 0 164.571 73.714 164.571 164.571v548.571c0 90.857-73.714 164.571-164.571 164.571h-107.429v-340h113.714l17.143-132.571h-130.857v-84.571c0-38.286 10.286-64 65.714-64l69.714-0.571v-118.286c-12-1.714-53.714-5.143-101.714-5.143-101.143 0-170.857 61.714-170.857 174.857v97.714h-114.286v132.571h114.286v340h-");
                WriteLiteral(@"304c-90.857 0-164.571-73.714-164.571-164.571v-548.571c0-90.857 73.714-164.571 164.571-164.571h548.571z""></path>
                                </svg><svg viewBox=""0 0 877.7142857142857 1024""
                                           class=""home-icon10"">
                                    <path d=""M585.143 512c0-80.571-65.714-146.286-146.286-146.286s-146.286 65.714-146.286 146.286 65.714 146.286 146.286 146.286 146.286-65.714 146.286-146.286zM664 512c0 124.571-100.571 225.143-225.143 225.143s-225.143-100.571-225.143-225.143 100.571-225.143 225.143-225.143 225.143 100.571 225.143 225.143zM725.714 277.714c0 29.143-23.429 52.571-52.571 52.571s-52.571-23.429-52.571-52.571 23.429-52.571 52.571-52.571 52.571 23.429 52.571 52.571zM438.857 152c-64 0-201.143-5.143-258.857 17.714-20 8-34.857 17.714-50.286 33.143s-25.143 30.286-33.143 50.286c-22.857 57.714-17.714 194.857-17.714 258.857s-5.143 201.143 17.714 258.857c8 20 17.714 34.857 33.143 50.286s30.286 25.143 50.286 33.143c57.714 22.857 194.857 17.714 258.857 17.");
                WriteLiteral(@"714s201.143 5.143 258.857-17.714c20-8 34.857-17.714 50.286-33.143s25.143-30.286 33.143-50.286c22.857-57.714 17.714-194.857 17.714-258.857s5.143-201.143-17.714-258.857c-8-20-17.714-34.857-33.143-50.286s-30.286-25.143-50.286-33.143c-57.714-22.857-194.857-17.714-258.857-17.714zM877.714 512c0 60.571 0.571 120.571-2.857 181.143-3.429 70.286-19.429 132.571-70.857 184s-113.714 67.429-184 70.857c-60.571 3.429-120.571 2.857-181.143 2.857s-120.571 0.571-181.143-2.857c-70.286-3.429-132.571-19.429-184-70.857s-67.429-113.714-70.857-184c-3.429-60.571-2.857-120.571-2.857-181.143s-0.571-120.571 2.857-181.143c3.429-70.286 19.429-132.571 70.857-184s113.714-67.429 184-70.857c60.571-3.429 120.571-2.857 181.143-2.857s120.571-0.571 181.143 2.857c70.286 3.429 132.571 19.429 184 70.857s67.429 113.714 70.857 184c3.429 60.571 2.857 120.571 2.857 181.143z""></path>
                                </svg>
                            </div>
                        </div>
                    </div>
                </div>
            <");
                WriteLiteral(@"/div>
            <div class=""home-hero"">
                <div class=""home-hero-text-container"">
                    <h1 class=""home-heading"">Welcome to MOYO</h1>
                    <span class=""home-text04"">
                        <span>
                            MOYO (Moving On Your Own) is a program that has been created
                            knowing that YOU are your guide to your own body. As your guide
                            through practice, Safiya (that’s me!) will provide you with the
                            support you request with extreme attention to what your body is
                            asking for. I have called this practice MOYO for the fact that
                            moyo in Swahili means heart, that the term yoga. I want people
                            to truly connect with themselves through the practices that I
                            guide.
                        </span>
                        <br class=""Section-Text"" />
           ");
                WriteLiteral(@"             <br class=""Section-Text"" />
                        <span>
                            Please complete the intake form to be completed prior to
                            starting the MOYO program.
                        </span>
                    </span>
");
                WriteLiteral(@"                    <button type =""button"" onclick=""window.location.href = 'BookAppointment';""   
                            class=""home-cta-btn2 button Anchor"">
                        Book Appointment
                    </button>
                </div>
                <img alt=""image""
                     src=""images/Safiya-Yoga Pose-1.PNG""
                     class=""home-image2"" />
            </div>
            <div class=""home-section-separator""></div>
            <div id=""features"" class=""home-features"">
                <div class=""home-heading-container"">
                    <h2 class=""home-text09 Section-Heading"">Why MOYO?</h2>
                    <span class=""home-text10 Section-Text"">
                        It's for health, relaxation or fun. I can help you with your
                        journey.&nbsp;
                    </span>
                </div>
                <div class=""home-cards-container"">
                    <div class=""home-feature-card"">
                   ");
                WriteLiteral(@"     <img alt=""image""
                             src=""images/Yoga Drawing 3.jpg""
                             class=""home-image3"" />
                        <span class=""home-heading1 Card-Heading"">Why</span>
                        <span class=""home-text11"">
                            I offer 1 on 1 sessions or group sessions with a personalized
                            touch
                        </span>
                    </div>
                    <div class=""home-feature-card1"">
                        <img alt=""image""
                             src=""images/Yoga Image 7.jpg""
                             class=""home-image4"" />
                        <span class=""home-heading2 Card-Heading"">What</span>
                        <span class=""home-text12 Card-Text"">
                            I offer a variety of Yoga sessions, Guided Meditation to breath
                            exercises.
                        </span>
                    </div>
                    <div cl");
                WriteLiteral(@"ass=""home-feature-card2"">
                        <img alt=""image""
                             src=""images/Yoga Drawing 2.jpg""
                             class=""home-image5"" />
                        <span class=""home-heading3 Card-Heading"">How</span>
                        <span class=""home-text13"">
                            You can either register and become a member or book an
                            appointment.
                        </span>
                    </div>
                </div>
            </div>
            <div id=""contact"" class=""home-contact"">
                <div class=""home-content-container"">
                    <h2 class=""home-text14 Section-Heading"">
                        This is where to find us
                    </h2>
                    <div class=""home-locations-container"">
                        <div class=""home-location-1"">
                            <span class=""home-heading4"">Calgary Office</span>
                            <div class=""");
                WriteLiteral(@"home-adress"">
                                <svg viewBox=""0 0 1024 1024"" class=""home-icon12"">
                                    <path d=""M512 0c-176.732 0-320 143.268-320 320 0 320 320 704 320 704s320-384 320-704c0-176.732-143.27-320-320-320zM512 512c-106.040 0-192-85.96-192-192s85.96-192 192-192 192 85.96 192 192-85.96 192-192 192z""></path>
                                </svg>
                                <span class=""Section-Text"">?????????</span>
                            </div>
                            <div class=""home-email"">
                                <svg viewBox=""0 0 1024 1024"" class=""home-icon14"">
                                    <path d=""M854 342v-86l-342 214-342-214v86l342 212zM854 170q34 0 59 26t25 60v512q0 34-25 60t-59 26h-684q-34 0-59-26t-25-60v-512q0-34 25-60t59-26h684z""></path>
                                </svg>
                                <span>safiya.nanji@ahs.ca</span>
                            </div>
                            <div class=""home-p");
                WriteLiteral(@"hone"">
                                <svg viewBox=""0 0 804.5714285714286 1024"" class=""home-icon16"">
                                    <path d=""M804.571 708.571c0 20.571-9.143 60.571-17.714 79.429-12 28-44 46.286-69.714 60.571-33.714 18.286-68 29.143-106.286 29.143-53.143 0-101.143-21.714-149.714-39.429-34.857-12.571-68.571-28-100-47.429-97.143-60-214.286-177.143-274.286-274.286-19.429-31.429-34.857-65.143-47.429-100-17.714-48.571-39.429-96.571-39.429-149.714 0-38.286 10.857-72.571 29.143-106.286 14.286-25.714 32.571-57.714 60.571-69.714 18.857-8.571 58.857-17.714 79.429-17.714 4 0 8 0 12 1.714 12 4 24.571 32 30.286 43.429 18.286 32.571 36 65.714 54.857 97.714 9.143 14.857 26.286 33.143 26.286 50.857 0 34.857-103.429 85.714-103.429 116.571 0 15.429 14.286 35.429 22.286 49.143 57.714 104 129.714 176 233.714 233.714 13.714 8 33.714 22.286 49.143 22.286 30.857 0 81.714-103.429 116.571-103.429 17.714 0 36 17.143 50.857 26.286 32 18.857 65.143 36.571 97.714 54.857 11.429 5.714 39.429 18.286 43.429 30.286 1.71");
                WriteLiteral(@"4 4 1.714 8 1.714 12z""></path>
                                </svg>
                                <span>1-403-615-7551</span>
                            </div>
                        </div>
                    </div>
                    <div class=""home-social-links-container1"">
                        <svg viewBox=""0 0 950.8571428571428 1024"" class=""home-icon18"">
                            <path d=""M925.714 233.143c-25.143 36.571-56.571 69.143-92.571 95.429 0.571 8 0.571 16 0.571 24 0 244-185.714 525.143-525.143 525.143-104.571 0-201.714-30.286-283.429-82.857 14.857 1.714 29.143 2.286 44.571 2.286 86.286 0 165.714-29.143 229.143-78.857-81.143-1.714-149.143-54.857-172.571-128 11.429 1.714 22.857 2.857 34.857 2.857 16.571 0 33.143-2.286 48.571-6.286-84.571-17.143-148-91.429-148-181.143v-2.286c24.571 13.714 53.143 22.286 83.429 23.429-49.714-33.143-82.286-89.714-82.286-153.714 0-34.286 9.143-65.714 25.143-93.143 90.857 112 227.429 185.143 380.571 193.143-2.857-13.714-4.571-28-4.571-42.286 0-101.7");
                WriteLiteral(@"14 82.286-184.571 184.571-184.571 53.143 0 101.143 22.286 134.857 58.286 41.714-8 81.714-23.429 117.143-44.571-13.714 42.857-42.857 78.857-81.143 101.714 37.143-4 73.143-14.286 106.286-28.571z""></path>
                        </svg><svg viewBox=""0 0 877.7142857142857 1024"" class=""home-icon20"">
                            <path d=""M713.143 73.143c90.857 0 164.571 73.714 164.571 164.571v548.571c0 90.857-73.714 164.571-164.571 164.571h-107.429v-340h113.714l17.143-132.571h-130.857v-84.571c0-38.286 10.286-64 65.714-64l69.714-0.571v-118.286c-12-1.714-53.714-5.143-101.714-5.143-101.143 0-170.857 61.714-170.857 174.857v97.714h-114.286v132.571h114.286v340h-304c-90.857 0-164.571-73.714-164.571-164.571v-548.571c0-90.857 73.714-164.571 164.571-164.571h548.571z""></path>
                        </svg><svg viewBox=""0 0 877.7142857142857 1024"" class=""home-icon22"">
                            <path d=""M585.143 512c0-80.571-65.714-146.286-146.286-146.286s-146.286 65.714-146.286 146.286 65.714 146.286 146.286 146.286 146.28");
                WriteLiteral(@"6-65.714 146.286-146.286zM664 512c0 124.571-100.571 225.143-225.143 225.143s-225.143-100.571-225.143-225.143 100.571-225.143 225.143-225.143 225.143 100.571 225.143 225.143zM725.714 277.714c0 29.143-23.429 52.571-52.571 52.571s-52.571-23.429-52.571-52.571 23.429-52.571 52.571-52.571 52.571 23.429 52.571 52.571zM438.857 152c-64 0-201.143-5.143-258.857 17.714-20 8-34.857 17.714-50.286 33.143s-25.143 30.286-33.143 50.286c-22.857 57.714-17.714 194.857-17.714 258.857s-5.143 201.143 17.714 258.857c8 20 17.714 34.857 33.143 50.286s30.286 25.143 50.286 33.143c57.714 22.857 194.857 17.714 258.857 17.714s201.143 5.143 258.857-17.714c20-8 34.857-17.714 50.286-33.143s25.143-30.286 33.143-50.286c22.857-57.714 17.714-194.857 17.714-258.857s5.143-201.143-17.714-258.857c-8-20-17.714-34.857-33.143-50.286s-30.286-25.143-50.286-33.143c-57.714-22.857-194.857-17.714-258.857-17.714zM877.714 512c0 60.571 0.571 120.571-2.857 181.143-3.429 70.286-19.429 132.571-70.857 184s-113.714 67.429-184 70.857c-60.571 3.429-120.571 2.857-181.143");
                WriteLiteral(@" 2.857s-120.571 0.571-181.143-2.857c-70.286-3.429-132.571-19.429-184-70.857s-67.429-113.714-70.857-184c-3.429-60.571-2.857-120.571-2.857-181.143s-0.571-120.571 2.857-181.143c3.429-70.286 19.429-132.571 70.857-184s113.714-67.429 184-70.857c60.571-3.429 120.571-2.857 181.143-2.857s120.571-0.571 181.143 2.857c70.286 3.429 132.571 19.429 184 70.857s67.429 113.714 70.857 184c3.429 60.571 2.857 120.571 2.857 181.143z""></path>
                        </svg>
                    </div>
                </div>
                <img src=""images/Yoga Drawing 4.jpg""
                     alt=""image""
                     class=""home-image6"" />
            </div>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MOYO_Website.Pages.WelcomePageModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MOYO_Website.Pages.WelcomePageModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MOYO_Website.Pages.WelcomePageModel>)PageContext?.ViewData;
        public MOYO_Website.Pages.WelcomePageModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
