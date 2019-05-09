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

    public sealed partial class VoiceMsg : ContentDialog
    {
        public String VoiceMsgStatus;
        public String AuthCode;

        public VoiceMsg()
        {
            this.InitializeComponent();
        }

        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
        }

        private void ContentDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
        }

        private void txt_AuthCode_TextChanged(object sender, TextChangedEventArgs e)
        {
            AuthCode = txt_AuthCode.Text.ToString();
        }
        private void txt_AuthCode_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void radioButton_Checked(object sender, RoutedEventArgs e)
        {
           
            VoiceMsgStatus = "ManualSale";
        }

        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {
            VoiceMsgStatus = "ManualAuth";
        }

        private void textBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
