﻿

#pragma checksum "E:\Visual Studio 2012\QRCode\QRCode\Component\WriteQR.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CCED49260EED8E9173F0C6978EE70E9F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QRCode.Component
{
    partial class WriteQR : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 12 "..\..\Component\WriteQR.xaml"
                ((global::Windows.UI.Xaml.Controls.TextBox)(target)).SelectionChanged += this.txtText_SelectionChanged;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 13 "..\..\Component\WriteQR.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.btnGetQR_Click;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


