#pragma checksum "C:\Users\Casper\source\repos\AppointmentSystem\AppointmentSystem\Views\Profile\Admin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69c114c12bbcf898160c4c1e01abd4105b87d038"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_Admin), @"mvc.1.0.view", @"/Views/Profile/Admin.cshtml")]
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
#line 1 "C:\Users\Casper\source\repos\AppointmentSystem\AppointmentSystem\Views\_ViewImports.cshtml"
using AppointmentSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Casper\source\repos\AppointmentSystem\AppointmentSystem\Views\_ViewImports.cshtml"
using AppointmentSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69c114c12bbcf898160c4c1e01abd4105b87d038", @"/Views/Profile/Admin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3528416e81b73dcb48f3328a3f55faac05d68985", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_Admin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AdminViewModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Casper\source\repos\AppointmentSystem\AppointmentSystem\Views\Profile\Admin.cshtml"
  
    ViewData["Title"] = "Admin";

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    <link href=\"https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css\" rel=\"stylesheet\" integrity=\"sha384-wvfXpqpZZVQGK6TAh5PVlGOfQNHSoD2xbE+QkPxCAFlNEevoEH3Sl0sibVcOQVnN\" crossorigin=\"anonymous\">\r\n\r\n");
            }
            );
            WriteLiteral(@"
<div class=""modal fade"" id=""saveModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Randevu Güncelleme</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69c114c12bbcf898160c4c1e01abd4105b87d0384475", async() => {
                WriteLiteral(@"
                    <input hidden id=""apointmentId"" />
                    <div class=""row"">
                        <div class="" col-md-2"">
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""form-group col-md-6"">
                            <label class=""form-control-label"">Adınız : </label>
                            <input id=""inputName"" type=""text"" class=""form-control"" />
                        </div>
                        <div class=""form-group col-md-6"">
                            <label class=""form-control-label"">Soyadınız : </label>
                            <input id=""inputSurname"" type=""text"" class=""form-control"" />
                        </div>
                        <div class=""row"">
                            <div class=""form-group col-md-6"" style=""text-align:center"">
                                <label class=""form-control-label"">Randevu Tarihi : </label>
                              ");
                WriteLiteral(@"  <div class=""input-group date"" id=""datetimepicker1"" data-target-input=""nearest"">
                                    <input style=""text-align:center"" id=""inputStartDate"" type=""text"" class=""form-control datetimepicker-input"" data-target=""#datetimepicker1"" />
                                    <div class=""input-group-append"" data-target=""#datetimepicker1"" data-toggle=""datetimepicker"">
                                        <div class=""input-group-text""><i class=""fa fa-calendar""></i></div>
                                    </div>
                                </div>
                            </div>
                            <div class=""form-group col-md-6"">
                                <label class=""form-control-label"">Randevu Saati : </label>
                                <input id=""inputHour"" type=""text"" class=""form-control"" />
                            </div>

                        </div>
                        </div>
                        <div class=""row"">
              ");
                WriteLiteral(@"              <div class=""form-group col-md-6"">
                                <label class=""form-control-label"">Araba Modelini Giriniz : </label>
                                <input id=""inputCarName"" type=""text"" class=""form-control"" />
                            </div>
                            <div class=""form-group col-md-6"">
                                <label class=""form-control-label"">Model Yılı : </label>
                                <input id=""inputCarModel"" type=""text"" class=""form-control"" />
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""form-group col-md-6"">
                                <label class=""form-control-label"">Telefon Numaranız : </label>
                                <input id=""inputPhoneNumber"" type=""text"" class=""form-control"" />
                            </div>
                            <div class=""form-group col-md-6"">
                              ");
                WriteLiteral(@"  <label class=""form-control-label"">İl : </label>
                                <input id=""inputil"" type=""text"" class=""form-control"" />
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""form-group col-md-6"">
                                <label class=""form-control-label"">Plakanız : </label>
                                <input id=""inputPlaka"" type=""text"" class=""form-control"" />
                            </div>
                            <div class=""form-group col-md-6"">
                                <label class=""form-control-label"">Eklemek İstediğiniz Açıklamayı Buraya Giriniz. : </label>
                                <input id=""inputDescription"" type=""text"" class=""form-control"" />
                            </div>
                            <input type=""hidden"" id=""selectUserId"" />
                        </div>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <div class=""form-group col-md-6"">
                    <button data-id=""Id"" type=""button"" class=""btn btn-primary btnSave"">Güncelle ve Kaydet</button>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""row"">
    <div class=""col-md-3"">
        <div class=""card"">
            <div class=""card-body"">
                <h5 class=""card-title"">Araç Randevu Sistemi</h5>
                <h6 class=""card-subtitle mb-2 text-muted"">");
#nullable restore
#line 100 "C:\Users\Casper\source\repos\AppointmentSystem\AppointmentSystem\Views\Profile\Admin.cshtml"
                                                     Write(Model.User.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 100 "C:\Users\Casper\source\repos\AppointmentSystem\AppointmentSystem\Views\Profile\Admin.cshtml"
                                                                      Write(Model.User.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                <p class=\"card-text\">Araç randevu sistemine hoş geldiniz.</p>\r\n                <a href=\"/Account/Logout\" class=\"card-link\">Çıkış Yap</a>\r\n            </div>\r\n        </div>\r\n        <br />\r\n");
            WriteLiteral("    </div>\r\n\r\n    <div class=\"col-md-9\">\r\n       \r\n        <div class=\"card\">\r\n            <div>\r\n");
#nullable restore
#line 118 "C:\Users\Casper\source\repos\AppointmentSystem\AppointmentSystem\Views\Profile\Admin.cshtml"
                 using (Html.BeginForm("getTable", "Profile", FormMethod.Get))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <p style=""float:right; margin-top:10px; margin-right:19px"">      
                            Plaka Ara: <input name=""param"" type=""text"" /> 
                            <input id=""ara"" type=""submit"" value=""Ara"" style=""width:70px;"" />
                    </p>
");
#nullable restore
#line 124 "C:\Users\Casper\source\repos\AppointmentSystem\AppointmentSystem\Views\Profile\Admin.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>

            <div class=""card-body"">
                <div id=""getTable"">
                    <table style=""table-layout: fixed; ""  class=""table table-bordered table-striped m-1 p-1"">
                        <tr style=""text-align:center;"">
                            <th>Kullanıcı Adı</th>
                            <th>Soyadı</th>
                            <th>Telefon Numarası</th>
                            <th>Plaka</th>
                            <th>Başlangıç Tarihi</th>
                            <th>Açıklama</th>
                            <th></th>
                            <th></th>
                        </tr>
");
#nullable restore
#line 140 "C:\Users\Casper\source\repos\AppointmentSystem\AppointmentSystem\Views\Profile\Admin.cshtml"
                         foreach (var item in Model.Appointment)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr style=\"text-align:center\">\r\n                        <td hidden class=\"carName\">");
#nullable restore
#line 143 "C:\Users\Casper\source\repos\AppointmentSystem\AppointmentSystem\Views\Profile\Admin.cshtml"
                                              Write(item.CarName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td hidden class=\"carModel\">");
#nullable restore
#line 144 "C:\Users\Casper\source\repos\AppointmentSystem\AppointmentSystem\Views\Profile\Admin.cshtml"
                                               Write(item.CarModel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td style=\" white-space: nowrap;\" class=\"name\">");
#nullable restore
#line 145 "C:\Users\Casper\source\repos\AppointmentSystem\AppointmentSystem\Views\Profile\Admin.cshtml"
                                                                  Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        <td style=\" white-space: nowrap;\" class=\"surname\"> ");
#nullable restore
#line 146 "C:\Users\Casper\source\repos\AppointmentSystem\AppointmentSystem\Views\Profile\Admin.cshtml"
                                                                      Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td style=\" white-space: nowrap;\" class=\"phoneNumber\">");
#nullable restore
#line 147 "C:\Users\Casper\source\repos\AppointmentSystem\AppointmentSystem\Views\Profile\Admin.cshtml"
                                                                         Write(item.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td style=\" white-space: nowrap;\" class=\"plaka\">");
#nullable restore
#line 148 "C:\Users\Casper\source\repos\AppointmentSystem\AppointmentSystem\Views\Profile\Admin.cshtml"
                                                                   Write(item.Plaka);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td hidden class=\"il\">");
#nullable restore
#line 149 "C:\Users\Casper\source\repos\AppointmentSystem\AppointmentSystem\Views\Profile\Admin.cshtml"
                                         Write(item.il);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"startDate\">");
#nullable restore
#line 150 "C:\Users\Casper\source\repos\AppointmentSystem\AppointmentSystem\Views\Profile\Admin.cshtml"
                                         Write(item.StartDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td hidden class=\"ıd\">");
#nullable restore
#line 151 "C:\Users\Casper\source\repos\AppointmentSystem\AppointmentSystem\Views\Profile\Admin.cshtml"
                                         Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td hidden class=\"hour\">");
#nullable restore
#line 152 "C:\Users\Casper\source\repos\AppointmentSystem\AppointmentSystem\Views\Profile\Admin.cshtml"
                                           Write(item.Hour);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"description\">");
#nullable restore
#line 153 "C:\Users\Casper\source\repos\AppointmentSystem\AppointmentSystem\Views\Profile\Admin.cshtml"
                                           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            <a data-id=\"");
#nullable restore
#line 155 "C:\Users\Casper\source\repos\AppointmentSystem\AppointmentSystem\Views\Profile\Admin.cshtml"
                                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"btn btn-outline-danger btnDelete\">Sil</a>\r\n                        </td>\r\n                        <td><button data-id=\"");
#nullable restore
#line 157 "C:\Users\Casper\source\repos\AppointmentSystem\AppointmentSystem\Views\Profile\Admin.cshtml"
                                        Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" type=\"button\" class=\"btn btn-outline-primary btnUpdate\">Güncelle</button></td>\r\n                    </tr>\r\n");
#nullable restore
#line 159 "C:\Users\Casper\source\repos\AppointmentSystem\AppointmentSystem\Views\Profile\Admin.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </table>\r\n                </div>\r\n\r\n             \r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/moment.js/2.24.0/moment.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/moment-timezone/0.5.28/moment-timezone-with-data-10-year-range.js""></script>
    <script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/tempusdominus-bootstrap-4/5.0.1/js/tempusdominus-bootstrap-4.min.js""></script>
   
    <script>
       
        document.addEventListener('DOMContentLoaded', function () {
            var events = [];
            getAppointments();
            $('#datetimepicker1').datetimepicker({
                format: 'DD/MM/YYYY HH:mm'
            });
            function getAppointments() {
                $.ajax({
                    type: 'GET',
                    url: 'http://localhost:57877/api/Appointments',
                    success: function (response) {
                        events = [];
                        for (var i = 0; i < response.length; i++) {
                            ");
                WriteLiteral(@"events.push({
                                id: response[i].id,
                                carName: response[i].carName,
                                carModel: response[i].carModel,
                                start: response[i].startDate,
                                description: response[i].description,
                                hour: response[i].hour,
                                surname: response[i].surname,
                                il: response[i].il,
                                plaka: response[i].plaka,
                                phoneNumber: response[i].phoneNumber,
                                name: response[i].name
                            });
                        }
                    },
                    error: function () {
                        $('#saveModal').modal('hide');
                        alertify.error('Randevunuz eklenirken bir problem oluştu.');
                    }
                });
            }

      ");
                WriteLiteral(@"      function saveAppointment(data) {
                $.ajax({
                    type: 'POST',
                    url: '/appointment/AddOrUpdateAppointment',
                    data: data,
                    success: function (response) {
                            getAppointments();
                            $('#saveModal').modal('hide');
                            data.Id === ""0"" ? alertify.success('Randevunuz başarıyla eklendi.') : alertify.success('Randevunuz başarıyla güncellenmiştir.');
                    },
                    error: function () {
                        $('#saveModal').modal('hide');
                        alertify.error('Erişim sağlanamadı.');
                    }
                });
            }

            $('.btnSave').click(function () {

                var appointment = {
                    Id: $('#apointmentId').val(),
                    UserId: $('#selectUserId').val(),
                    StartDate: $('#inputStartDate').val(),
        ");
                WriteLiteral(@"            Hour: $('#inputHour').val(),
                    CarName: $('#inputCarName').val(),
                    CarModel: $('#inputCarModel').val(),
                    Description: $('#inputDescription').val(),
                    Name: $('#inputName').val(),
                    Surname: $('#inputSurname').val(),
                    PhoneNumber: $('#inputPhoneNumber').val(),
                    Plaka: $('#inputPlaka').val(),
                    il: $('#inputil').val()
                }
                console.log(appointment);
                saveAppointment(appointment);  
            });

            $('.btnUpdate').click(function () {
                $('#inputStartDate').val($(this).parents(""tr"").find("".startDate"").text());
                $('#apointmentId').val($(this).parents(""tr"").find("".ıd"").text())
                $('#inputDescription').val($(this).parents(""tr"").find("".description"").text());
                $('#inputCarName').val($(this).parents(""tr"").find("".carName"").text());
");
                WriteLiteral(@"                $('#inputCarModel').val($(this).parents(""tr"").find("".carModel"").text());
                $('#inputSurname').val($(this).parents(""tr"").find("".surname"").text());
                $('#inputPlaka').val($(this).parents(""tr"").find("".plaka"").text());
                $('#inputPhoneNumber').val($(this).parents(""tr"").find("".phoneNumber"").text());
                $('#inputName').val($(this).parents(""tr"").find("".name"").text());
                $('#inputil').val($(this).parents(""tr"").find("".il"").text());
                $('#inputHour').val($(this).parents(""tr"").find("".hour"").text());
                $('#saveModal').modal();
              
            });

           $('.btnDelete').click(function () {
            if (confirm('Randevuyu silmek istediğinize emin misiniz?')) {
                var id = $(this).data(""id"");
                var btn = $(this);
                $.ajax({
                    type: 'DELETE',
                    url: '/api/Appointments/' + id,
                    conten");
                WriteLiteral(@"tType: ""application/json; charset=utf-8"",
                    success: function (response) {
                        
                            btn.parent().parent().remove();
                            alertify.success('Randevunuz silinmiştir.');
                        
                    },
                    error: function () {

                        alertify.error('Randevunuz silinirken bir problem oluştu.');
                    }
                });
            }
        });

          

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdminViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
