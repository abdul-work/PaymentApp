﻿#pragma checksum "C:\Users\Abdul Rehman\source\PaymentApp\ChecoutBasic\ChecoutBasic\Custom user controls\QuickChip.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3CE8BF59B6F7374575B634C4ADA410F1"
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
    partial class QuickChip : 
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
                    #line 12 "..\..\..\Custom user controls\QuickChip.xaml"
                    ((global::Windows.UI.Xaml.Controls.ContentDialog)element1).PrimaryButtonClick += this.ContentDialog_PrimaryButtonClick;
                    #line 13 "..\..\..\Custom user controls\QuickChip.xaml"
                    ((global::Windows.UI.Xaml.Controls.ContentDialog)element1).SecondaryButtonClick += this.ContentDialog_SecondaryButtonClick;
                    #line default
                }
                break;
            case 2:
                {
                    this.RadioButton_YES = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 20 "..\..\..\Custom user controls\QuickChip.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.RadioButton_YES).Checked += this.RadioButton_Checked;
                    #line default
                }
                break;
            case 3:
                {
                    this.RadioButton_NO = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 21 "..\..\..\Custom user controls\QuickChip.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.RadioButton_NO).Checked += this.RadioButton_Checked_1;
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

