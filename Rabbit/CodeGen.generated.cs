﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.431
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rabbit
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using System.Web.WebPages.Html;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.1.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/CodeGen.cshtml")]
    public class CodeGen : System.Web.WebPages.WebPage
    {
        
        #line 10 "E:\Users\Public\My Projects\Rabbit\Src\Rabbit\CodeGen.cshtml"

    string code_type = "Web Form", code = "", file_name = "", msg = "";
    
    void Page_Load()
    {
        code = Rabbit.CodeGenTool.GetTemplate(code_type, file_name, null);
        if (!IsPost)
        {
            file_name = Rabbit.CodeGenTool.GetDefaultFileName(code_type);
        }
    }
    
    void code_type_click()
    {
        file_name = Rabbit.CodeGenTool.GetDefaultFileName(code_type); 
    }
    
    
    void save_click()
    {
        if (file_name.IsEmpty())
        {
            msg = "File name is required.";
        }
        else {

            try
            {
                var fileName = Server.MapPath(file_name);
                var ncode = Request.Unvalidated("ncode");  
                code = ncode;
                Rabbit.CodeGenTool.SaveCode(code_type, Server.MapPath("~/"), fileName, ncode, null);
                msg = "File saved.";
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
        }
    }

        #line default
        #line hidden

                // Resolve package relative syntax
                // Also, if it comes from a static embedded resource, change the path accordingly
                public override string Href(string virtualPath, params object[] pathParts) {
                    virtualPath = ApplicationPart.ProcessVirtualPath(GetType().Assembly, VirtualPath, virtualPath);
                    return base.Href(virtualPath, pathParts);
                }
        public CodeGen()
        {
        }
        public override void Execute()
        {


WriteLiteral("\r\n");


            
            #line 2 "E:\Users\Public\My Projects\Rabbit\Src\Rabbit\CodeGen.cshtml"
  
    
    ((IList<Tuple<string, string>>)PageData["BreadCrumbs"]).Add(Tuple.Create<string, string>("Rabbit Admin", "/_Admin/Rabbit"));
    ((IList<Tuple<string, string>>)PageData["BreadCrumbs"]).Add(Tuple.Create<string, string>("Generate Code", "/_Admin/Rabbit/CodeGen"));  


            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 8 "E:\Users\Public\My Projects\Rabbit\Src\Rabbit\CodeGen.cshtml"
Write(Rabbit.WebForm.Run(this));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");


WriteLiteral("\r\n");


DefineSection("Head", () => {

WriteLiteral("\r\n    <script src=\"http://ajax.aspnetcdn.com/ajax/jquery/jquery-1.4.4.min.js\" typ" +
"e=\"text/javascript\"></script>\r\n    <style type=\"text/css\">\r\n        h1 { margin-" +
"bottom: 20px;}\r\n        input[type=\'text\']{width: 250px;}\r\n    </style>\r\n");


});

WriteLiteral(@"
<form method=""post"" action="""">

<h1>Rabbit Code Generator</h1>

<div style=""float:left;margin-bottom:10px;"">
    Select a code type: 
    <select id=""code_type"" name=""code_type"" data-runat=""server-auto"">
    <option>Web Form</option>
    <option>Unit Test</option>
    </select>
</div>
 
<div style=""float:left;margin-left:10px;"">
    File Name: <input type=""text"" name=""file_name"" value=""");


            
            #line 71 "E:\Users\Public\My Projects\Rabbit\Src\Rabbit\CodeGen.cshtml"
                                                     Write(file_name);

            
            #line default
            #line hidden
WriteLiteral("\" />\r\n</div>\r\n\r\n<div style=\"float:left;margin-left:10px;margin-bottom:10px;\">\r\n  " +
" <input id=\"save\" type=\"submit\" value=\"Save\" data-runat=\"server\"/>\r\n  <div id=\"m" +
"sg\">");


            
            #line 76 "E:\Users\Public\My Projects\Rabbit\Src\Rabbit\CodeGen.cshtml"
           Write(msg);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n</div>\r\n<textarea name=\"ncode\" style=\"width:100%; border:1px solid #999; " +
"height:350px;\">");


            
            #line 78 "E:\Users\Public\My Projects\Rabbit\Src\Rabbit\CodeGen.cshtml"
                                                                           Write(code);

            
            #line default
            #line hidden
WriteLiteral("</textarea>\r\n\r\n</form>\r\n\r\n<script type=\"text/javascript\">\r\n    $(function () {\r\n " +
"       $(\"#code_type\").val(\'");


            
            #line 84 "E:\Users\Public\My Projects\Rabbit\Src\Rabbit\CodeGen.cshtml"
                        Write(code_type);

            
            #line default
            #line hidden
WriteLiteral("\');\r\n    });\r\n</script>\r\n");


        }
    }
}
#pragma warning restore 1591