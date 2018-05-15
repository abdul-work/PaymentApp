using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Text.RegularExpressions;

// The Content Dialog item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Checkout.Custom_user_controls
{
    public sealed partial class CashBack : ContentDialog
    {
        public Double CashbackAmount=-1;
        public CashBack()
        {
            this.InitializeComponent();
        }

        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            
        }

        private void ContentDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            
        }

        private void txt_CashBackAmount_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(Regex.IsMatch(txt_CashBackAmount.Text, @"^\d+$"))
            CashbackAmount =  Convert.ToDouble(txt_CashBackAmount.Text);
        }

        private void txt_CashBackAmount_GotFocus(object sender, RoutedEventArgs e)
        {
        }
    }
}
