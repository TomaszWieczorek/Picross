﻿

#pragma checksum "D:\STUDIA\Aplikacje multimedialne\App1\App1\SecondPlayer.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "25512FC20A2D2970CB6B85F165226DF9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App1
{
    partial class SecondPlayer : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 25 "..\..\SecondPlayer.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).KeyDown += this.txtNazwaO_KeyDown;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 26 "..\..\SecondPlayer.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.btnZatwierdzO_Click;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 27 "..\..\SecondPlayer.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.buttonExitO_Click;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 28 "..\..\SecondPlayer.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.btnUsunO_Click;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


