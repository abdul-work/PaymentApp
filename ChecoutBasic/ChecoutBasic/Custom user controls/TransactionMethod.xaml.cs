using ChecoutBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Content Dialog item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Checkout.Custom_user_controls
{
    public sealed partial class TransactionMethod : ContentDialog
    {
        public int option;
        public TransactionMethod()
        {
            this.InitializeComponent();
            if(Settings.saveState_MSR == true)
            {
                Radio_MSR_Only.IsChecked = true;
                Radio_MSR_EMV.IsChecked = false;
                Radio_MSR_EMV_CL.IsChecked = false;
            }
            else if(Settings.saveState_MSR_EMV == true)
            {
                Radio_MSR_Only.IsChecked = false;
                Radio_MSR_EMV.IsChecked = true;
                Radio_MSR_EMV_CL.IsChecked = false;
            }
            else if (Settings.saveState_MSR_EMV_CL == true)
            {
                Radio_MSR_EMV.IsChecked = false;
                Radio_MSR_Only.IsChecked = false;
                Radio_MSR_EMV_CL.IsChecked = true;
            }

        }

        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
        }

        private void ContentDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            option = 1;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            option = 2;
        }
        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            option = 3;
        }
    }
}
