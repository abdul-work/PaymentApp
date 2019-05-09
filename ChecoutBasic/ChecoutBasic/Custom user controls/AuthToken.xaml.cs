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

namespace ChecoutBasic.Custom_user_controls
{
    public sealed partial class AuthToken : ContentDialog
    {
        public string authToken;
        public string shift4BaseURL;
        public AuthToken()
        {
            this.InitializeComponent();
            this.txt_URL.Text = "https://utgapi.shift4test.com/";
            shift4BaseURL = this.txt_URL.Text;
        }

        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
        }

        private void ContentDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
        }
        
        private void txt_AuthTokenClick(object sender, TextChangedEventArgs e)
        {
            authToken = txt_AuthToken.Text;
        }

        private void txt_URLClick(object sender, TextChangedEventArgs e)
        {
            shift4BaseURL = txt_URL.Text;
        }
    }
}
