﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    
    #line 6 "..\..\Areas\School\Views\Student\_List_Data.cshtml"
    using System.Web.Mvc;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Areas\School\Views\Student\_List_Data.cshtml"
    using System.Web.Mvc.Ajax;
    
    #line default
    #line hidden
    
    #line 8 "..\..\Areas\School\Views\Student\_List_Data.cshtml"
    using System.Web.Mvc.Html;
    
    #line default
    #line hidden
    
    #line 9 "..\..\Areas\School\Views\Student\_List_Data.cshtml"
    using System.Web.Routing;
    
    #line default
    #line hidden
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using CubeDemo;
    
    #line 2 "..\..\Areas\School\Views\Student\_List_Data.cshtml"
    using NewLife;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    
    #line 3 "..\..\Areas\School\Views\Student\_List_Data.cshtml"
    using NewLife.Web;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Areas\School\Views\Student\_List_Data.cshtml"
    using XCode;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Areas\School\Views\Student\_List_Data.cshtml"
    using XCode.Configuration;
    
    #line default
    #line hidden
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/School/Views/Student/_List_Data.cshtml")]
    public partial class _Areas_School_Views_Student__List_Data_cshtml : System.Web.Mvc.WebViewPage<IList<NewLife.School.Entity.Student>>
    {
        public _Areas_School_Views_Student__List_Data_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 10 "..\..\Areas\School\Views\Student\_List_Data.cshtml"
  
    var fact = ViewBag.Factory as IEntityOperate;
    var page = ViewBag.Page as Pager;
    var fields = ViewBag.Fields as IList<FieldItem>;
    var enableSelect = this.EnableSelect();
    var provider = ManageProvider.Provider;

            
            #line default
            #line hidden
WriteLiteral("\r\n<table");

WriteLiteral(" class=\"table table-bordered table-hover table-striped table-condensed\"");

WriteLiteral(">\r\n    <thead>\r\n        <tr>\r\n");

            
            #line 20 "..\..\Areas\School\Views\Student\_List_Data.cshtml"
            
            
            #line default
            #line hidden
            
            #line 20 "..\..\Areas\School\Views\Student\_List_Data.cshtml"
             if (enableSelect)
            {

            
            #line default
            #line hidden
WriteLiteral("                <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" style=\"width:10px;\"");

WriteLiteral("><input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" id=\"chkAll\"");

WriteLiteral(" title=\"全选\"");

WriteLiteral(" /></th>\r\n");

            
            #line 23 "..\..\Areas\School\Views\Student\_List_Data.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            <th");

WriteLiteral(" class=\"text-center hidden-md hidden-sm hidden-xs\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 830), Tuple.Create("\"", 869)
            
            #line 24 "..\..\Areas\School\Views\Student\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 837), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("ID"))
            
            #line default
            #line hidden
, 837), false)
);

WriteLiteral(">编号</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 922), Tuple.Create("\"", 966)
            
            #line 25 "..\..\Areas\School\Views\Student\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 929), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("ClassID"))
            
            #line default
            #line hidden
, 929), false)
);

WriteLiteral(">班级</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1019), Tuple.Create("\"", 1060)
            
            #line 26 "..\..\Areas\School\Views\Student\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1026), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Name"))
            
            #line default
            #line hidden
, 1026), false)
);

WriteLiteral(">名称</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1113), Tuple.Create("\"", 1153)
            
            #line 27 "..\..\Areas\School\Views\Student\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1120), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Sex"))
            
            #line default
            #line hidden
, 1120), false)
);

WriteLiteral(">性别</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1206), Tuple.Create("\"", 1246)
            
            #line 28 "..\..\Areas\School\Views\Student\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1213), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Age"))
            
            #line default
            #line hidden
, 1213), false)
);

WriteLiteral(">年龄</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1299), Tuple.Create("\"", 1342)
            
            #line 29 "..\..\Areas\School\Views\Student\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1306), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Mobile"))
            
            #line default
            #line hidden
, 1306), false)
);

WriteLiteral(">手机</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1395), Tuple.Create("\"", 1439)
            
            #line 30 "..\..\Areas\School\Views\Student\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1402), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Address"))
            
            #line default
            #line hidden
, 1402), false)
);

WriteLiteral(">地址</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1492), Tuple.Create("\"", 1541)
            
            #line 31 "..\..\Areas\School\Views\Student\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1499), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("UpdateUserID"))
            
            #line default
            #line hidden
, 1499), false)
);

WriteLiteral(">更新者</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" style=\"min-width:134px;\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1620), Tuple.Create("\"", 1667)
            
            #line 32 "..\..\Areas\School\Views\Student\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1627), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("UpdateTime"))
            
            #line default
            #line hidden
, 1627), false)
);

WriteLiteral(">更新时间</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1722), Tuple.Create("\"", 1767)
            
            #line 33 "..\..\Areas\School\Views\Student\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1729), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("UpdateIP"))
            
            #line default
            #line hidden
, 1729), false)
);

WriteLiteral(">更新地址</a></th>\r\n");

            
            #line 34 "..\..\Areas\School\Views\Student\_List_Data.cshtml"
            
            
            #line default
            #line hidden
            
            #line 34 "..\..\Areas\School\Views\Student\_List_Data.cshtml"
             if (this.Has(PermissionFlags.Detail, PermissionFlags.Update, PermissionFlags.Delete))
            {

            
            #line default
            #line hidden
WriteLiteral("                <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" style=\"min-width:100px;\"");

WriteLiteral(">操作</th>\r\n");

            
            #line 37 "..\..\Areas\School\Views\Student\_List_Data.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n");

            
            #line 41 "..\..\Areas\School\Views\Student\_List_Data.cshtml"
        
            
            #line default
            #line hidden
            
            #line 41 "..\..\Areas\School\Views\Student\_List_Data.cshtml"
         foreach (var entity in Model)
        {

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n");

            
            #line 44 "..\..\Areas\School\Views\Student\_List_Data.cshtml"
                
            
            #line default
            #line hidden
            
            #line 44 "..\..\Areas\School\Views\Student\_List_Data.cshtml"
                 if (enableSelect)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" name=\"keys\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2232), Tuple.Create("\"", 2250)
            
            #line 46 "..\..\Areas\School\Views\Student\_List_Data.cshtml"
      , Tuple.Create(Tuple.Create("", 2240), Tuple.Create<System.Object, System.Int32>(entity.ID
            
            #line default
            #line hidden
, 2240), false)
);

WriteLiteral(" /></td>\r\n");

            
            #line 47 "..\..\Areas\School\Views\Student\_List_Data.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                <td");

WriteLiteral(" class=\"text-center hidden-md hidden-sm hidden-xs\"");

WriteLiteral(">");

            
            #line 48 "..\..\Areas\School\Views\Student\_List_Data.cshtml"
                                                                 Write(entity.ID);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td><a");

WriteAttribute("href", Tuple.Create(" href=\"", 2389), Tuple.Create("\"", 2420)
, Tuple.Create(Tuple.Create("", 2396), Tuple.Create("Class?ID=", 2396), true)
            
            #line 49 "..\..\Areas\School\Views\Student\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 2405), Tuple.Create<System.Object, System.Int32>(entity.ClassID
            
            #line default
            #line hidden
, 2405), false)
);

WriteLiteral(">");

            
            #line 49 "..\..\Areas\School\Views\Student\_List_Data.cshtml"
                                                  Write(entity.ClassName);

            
            #line default
            #line hidden
WriteLiteral("</a></td>\r\n                <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">");

            
            #line 50 "..\..\Areas\School\Views\Student\_List_Data.cshtml"
                                   Write(entity.Name);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">");

            
            #line 51 "..\..\Areas\School\Views\Student\_List_Data.cshtml"
                                   Write(entity.Sex);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 52 "..\..\Areas\School\Views\Student\_List_Data.cshtml"
                                  Write(entity.Age.ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 53 "..\..\Areas\School\Views\Student\_List_Data.cshtml"
               Write(entity.Mobile);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 54 "..\..\Areas\School\Views\Student\_List_Data.cshtml"
               Write(entity.Address);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 55 "..\..\Areas\School\Views\Student\_List_Data.cshtml"
                                  Write(provider.FindByID(entity.UpdateUserID));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 56 "..\..\Areas\School\Views\Student\_List_Data.cshtml"
               Write(entity.UpdateTime.ToFullString(""));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteAttribute("title", Tuple.Create(" title=\"", 2888), Tuple.Create("\"", 2926)
            
            #line 57 "..\..\Areas\School\Views\Student\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 2896), Tuple.Create<System.Object, System.Int32>(entity.UpdateIP.IPToAddress()
            
            #line default
            #line hidden
, 2896), false)
);

WriteLiteral(">");

            
            #line 57 "..\..\Areas\School\Views\Student\_List_Data.cshtml"
                                                      Write(entity.UpdateIP);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 58 "..\..\Areas\School\Views\Student\_List_Data.cshtml"
                
            
            #line default
            #line hidden
            
            #line 58 "..\..\Areas\School\Views\Student\_List_Data.cshtml"
                 if (this.Has(PermissionFlags.Detail, PermissionFlags.Update, PermissionFlags.Delete))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 61 "..\..\Areas\School\Views\Student\_List_Data.cshtml"
                   Write(Html.Partial("_List_Data_Action", (Object)entity));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n");

            
            #line 63 "..\..\Areas\School\Views\Student\_List_Data.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </tr>\r\n");

            
            #line 65 "..\..\Areas\School\Views\Student\_List_Data.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </tbody>\r\n</table>");

        }
    }
}
#pragma warning restore 1591