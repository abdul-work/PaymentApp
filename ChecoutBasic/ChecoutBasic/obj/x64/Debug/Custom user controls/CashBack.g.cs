﻿#pragma checksum "C:\Users\Abdul Rehman\source\PaymentApp\ChecoutBasic\ChecoutBasic\Custom user controls\CashBack.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "474FE9CE7751976AA20C3A527CC333A1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChecoutBasic.Custom_user_controls
{
    partial class CashBack : 
        global::Windows.UI.Xaml.Controls.ContentDialog, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.ContentDialog element1 = (global::Windows.UI.Xaml.Controls.ContentDialog)(target);
                    #line 12 "..\..\..\Custom user controls\CashBack.xaml"
                    ((global::Windows.UI.Xaml.Controls.ContentDialog)element1).PrimaryButtonClick += this.ContentDialog_PrimaryButtonClick;
                    #line 13 "..\..\..\Custom user controls\CashBack.xaml"
                    ((global::Windows.UI.Xaml.Controls.ContentDialog)element1).SecondaryButtonClick += this.ContentDialog_SecondaryButtonClick;
                    #line default
                }
                break;
            case 2:
                {
                    this.txt_CashBackAmount = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    #line 20 "..\..\..\Custom user controls\CashBack.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.txt_CashBackAmount).TextChanged += this.txt_CashBackAmount_TextChanged;
                    #line 20 "..\..\..\Custom user controls\CashBack.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.txt_CashBackAmount).GotFocus += this.txt_CashBackAmount_GotFocus;
                    #line default
                }
                break;
            case 3:
                {
                    this.alert = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

