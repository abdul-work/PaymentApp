﻿#pragma checksum "C:\Users\Abdul Rehman\source\PaymentApp\ChecoutBasic\ChecoutBasic\Custom user controls\Tip.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5158166C489DA3C15CCBD0D5BAD3EA42"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Checkout.Custom_user_controls
{
    partial class Tip : 
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
                    #line 12 "..\..\..\Custom user controls\Tip.xaml"
                    ((global::Windows.UI.Xaml.Controls.ContentDialog)element1).PrimaryButtonClick += this.ContentDialog_PrimaryButtonClick;
                    #line 13 "..\..\..\Custom user controls\Tip.xaml"
                    ((global::Windows.UI.Xaml.Controls.ContentDialog)element1).SecondaryButtonClick += this.ContentDialog_SecondaryButtonClick;
                    #line default
                }
                break;
            case 2:
                {
                    this.tip_textBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    #line 16 "..\..\..\Custom user controls\Tip.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.tip_textBox).TextChanged += this.tip_Click;
                    #line default
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

