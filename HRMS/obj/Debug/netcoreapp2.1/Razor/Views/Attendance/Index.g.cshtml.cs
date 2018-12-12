#pragma checksum "D:\HRManage\HRMS\Views\Attendance\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51754ce05c2ad508f150e85df1ad7e124ddf838e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Attendance_Index), @"mvc.1.0.view", @"/Views/Attendance/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Attendance/Index.cshtml", typeof(AspNetCore.Views_Attendance_Index))]
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
#line 1 "D:\HRManage\HRMS\Views\_ViewImports.cshtml"
using HRMS.Middleware.PermissionMiddleware;

#line default
#line hidden
#line 2 "D:\HRManage\HRMS\Views\_ViewImports.cshtml"
using HRMS.App_Start;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51754ce05c2ad508f150e85df1ad7e124ddf838e", @"/Views/Attendance/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"308e485a9cf43d1ee77f9280bbe22e6601398bd4", @"/Views/_ViewImports.cshtml")]
    public class Views_Attendance_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\HRManage\HRMS\Views\Attendance\Index.cshtml"
  
    ViewBag.Title = "考勤打卡";
    Layout = ViewBag.Layout;

#line default
#line hidden
            BeginContext(68, 1404, true);
            WriteLiteral(@"<div class=""page-content-body"">
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""booking-search"">
                <div class=""row form-group"">
                    <div class=""fiter col-md-6 col-xs-6"" data-column=""0"">
                        <label class=""control-label"">工号:</label>
                        <div class=""input-icon"">
                            <input class=""form-control"" type=""text"" id=""col0_filter"">
                        </div>
                    </div>
                    <div class=""fiter col-md-6 col-xs-6"" data-column=""1"">
                        <label class=""control-label"">姓名:</label>
                        <div class=""input-icon"">
                            <input class=""form-control"" type=""text"" id=""col1_filter"">
                        </div>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-md-2"">
                        <button class=""btn green btn-block  margin-b");
            WriteLiteral(@"ottom-20"" id=""Search"">查询<i class=""m-icon-swapright m-icon-white""></i></button>
                    </div>
                </div>

            </div>
        </div>
    </div>

    <br />
    <div class=""row"">
        <div class=""col-md-12"">
            <table id=""myTable"" class=""table table-striped table-bordered nowrap""></table>
        </div>
    </div>
</div>
");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1489, 478, true);
                WriteLiteral(@"

    <script>
        function filterColumn(i) {
            $('#myTable').DataTable().column(i).search(
                $('#col' + i + '_filter').val(),
                false,
                false
            ).draw();
        }
        var editor;
        $(document).ready(function () {
            App.addResizeHandler(Resize);
            editor = new $.fn.dataTable.Editor({
                idSrc: ""Id"",
                ajax: {
                    url: """);
                EndContext();
                BeginContext(1968, 47, false);
#line 57 "D:\HRManage\HRMS\Views\Attendance\Index.cshtml"
                     Write(Url.Action("AttendanceIndexData", "Attendance"));

#line default
#line hidden
                EndContext();
                BeginContext(2015, 1253, true);
                WriteLiteral(@""",
                    type: ""post""
                },
                table: ""#myTable"",
                fields: [
                    { label: ""工号:"", name: ""EmployeeId"" },
                    { label: ""姓名:"", name: ""EmployeeName"" },
                    {
                        type: ""datetime"",
                        label: ""打卡时间:"",
                        name: ""CheckTime""
                    },
                    {
                        type: ""select"",
                        label: ""打卡方式:"",
                        name: ""CheckClass"",
                        options: [
                            { label: ""补卡"", value: ""3"" }
                        ]
                    },
                    {
                        type: ""select"",
                        label: ""打卡类型:"",
                        name: ""CheckType"",
                        options: [
                            { label: ""进仓"", value: ""1"" },
                            { label: ""出仓"", value: ""2"" }
               ");
                WriteLiteral("         ]\r\n                    },\r\n                    { label: \"备注:\", name: \"Remarks\" }\r\n                ]\r\n            });\r\n            var table = $(\'#myTable\').DataTable({\r\n                ajax: {\r\n                    url: \"");
                EndContext();
                BeginContext(3269, 47, false);
#line 91 "D:\HRManage\HRMS\Views\Attendance\Index.cshtml"
                     Write(Url.Action("AttendanceIndexData", "Attendance"));

#line default
#line hidden
                EndContext();
                BeginContext(3316, 5628, true);
                WriteLiteral(@""",
                    type: ""post""
                },
                order: [[0, 'asc']],//一定要添加
                columns: [
                    { data: ""EmployeeId"", title: ""工号"", searchable: true, orderable: true, width: ""50px"", responsivePriority: 1 },
                    { data: ""EmployeeName"", title: ""姓名"", searchable: true, orderable: true, width: ""100px"", responsivePriority: 1 },
                    { data: ""Department"", title: ""所属仓库/部门"", searchable: true, orderable: true, width: ""100px"", responsivePriority: 5 },
                    { data: ""Position"", title: ""所属岗位"", searchable: true, orderable: true, width: ""100px"", responsivePriority: 5 },
                    {
                        data: ""EmployeeType"", title: ""员工类型"", searchable: true, orderable: true, width: ""100px"",
                        render: function (val, type, row) {
                            if (val === ""1"") {
                                return ""正式工"";
                            } else if (val === ""2"") {
            ");
                WriteLiteral(@"                    return ""实习生"";
                            } else if (val === ""3"") {
                                return ""长期劳务"";
                            } else if (val === ""4"") {
                                return ""临时劳务"";
                            } else {
                                return ""未知"";
                            }
                        }
                    },
                    { data: ""EquipmentCode"", title: ""打卡设备编码"", searchable: true, orderable: true, width: ""100px"", responsivePriority: 5 },
                    {
                        data: ""CheckTime"", title: ""打卡时间"", searchable: true, orderable: true, width: ""150px"",
                        render: function (val, type, row) {
                            if (val !== null && val.match(/\/Date\((\d+)\)\//gi)) {
                                val = moment(eval(val.replace(/\/Date\((\d+)\)\//gi, ""new Date($1)""))).format('YYYY-MM-DD HH:mm:ss');
                                row.createtime = val;
         ");
                WriteLiteral(@"                   }
                            return val;
                        }
                    },
                    {
                        data: ""CheckClass"", title: ""打卡方式"", searchable: true, orderable: true, width: ""100px"",
                        render: function (val, type, row) {
                            if (val === ""1"") {
                                return ""人脸识别"";
                            } else if (val === ""2"") {
                                return ""刷卡"";
                            } else if (val === ""3"") {
                                return ""补卡"";
                            } else {
                                return ""未知"";
                            }
                        }
                    },
                    {
                        data: ""CheckType"", title: ""打卡类型"", searchable: true, orderable: true, width: ""100px"",
                        render: function (val, type, row) {
                            if (val === ""1"") {
         ");
                WriteLiteral(@"                       return ""进仓"";
                            } else if (val === ""2"") {
                                return ""出仓"";
                            } else {
                                return ""未知"";
                            }
                        }
                    },

                    { data: ""Remarks"", title: ""备注"", searchable: true, orderable: true, width: ""50px"", responsivePriority: 5 }
                ],
                buttons: [
                    { extend: ""create"", text: ""创建"", editor: editor },
                    {
                        extend: 'collection',
                        text: '导出',
                        buttons: [
                            { extend: ""copyHtml5"", text: ""复制"" },
                            { extend: ""excelHtml5"", text: ""导出EXCEL"" },
                            { extend: ""csvHtml5"", text: ""导出CSV"" }
                            //{ extend: ""pdfHtml5"", text: ""导出PDF"" }
                        ]
                    }
     ");
                WriteLiteral(@"           ]
            });

            //editor.on('initCreate', function () {
            //    editor.show(); //Shows all fields
            //});

            //editor.on('initEdit', function () {
            //    editor.show(); //Shows all fields
            //    editor.hide('password');
            //});

            editor.on('preSubmit', function (e, o, action) {
                if (action !== 'remove') {
                    ;
                }
            });

            $('#Search').click(function () {
                var items = $(this).parents('.booking-search').find('.fiter');
                $.each(items, function (index, obj) {
                    var i = $(obj).attr('data-column');
                    var val = $('#col' + i + '_filter').val();
                    if (val === null)
                        val = '';
                    var selectot = '.search-' + i;
                    if ($(selectot).length === 0) {
                        $('#myTable').DataTable");
                WriteLiteral(@"().column(i).search(val, false, false);
                    }
                    else {
                        $('#myTable').DataTable().column($(selectot)).search(val, false, false);
                    }
                });

                $('#myTable').DataTable().columns().search().draw();
            });
        });

        function Resize() {

            $('#myTable').DataTable()
                .columns.adjust()
                .responsive.recalc();
        }
    </script>
");
                EndContext();
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
