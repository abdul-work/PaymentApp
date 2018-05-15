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
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

using PaymentSDK;
using Windows.UI.Core;
using Checkout.Custom_user_controls;
using Windows.UI.ViewManagement;

namespace Checkout
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page, PaymentResponseListener
    {
        int i = 0;
        string lastTransactionID;
        public MainPage()
        {
            this.InitializeComponent();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           if (result.Text.Length < 33)
            {
                if (result.Text[0] == '0' && result.Text.Length == 1)   //Handle point here
                {

                    result.Text = "1";
                }
                else
                    result.Text += "1";
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (result.Text.Length < 33)
            {
                if (result.Text[0] == '0' && result.Text.Length == 1)
                {
                    result.Text = "2";
                }
                else
                    result.Text += "2";
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
           if (result.Text.Length < 33)
            {
                if (result.Text[0] == '0' && result.Text.Length == 1)
                {
                    result.Text = "3";
                }
                else
                    result.Text += "3";
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (result.Text.Length < 33)
            {
                if (result.Text[0] == '0' && result.Text.Length == 1)
                {
                    result.Text = "4";
                }
                else
                    result.Text += "4";
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
             if (result.Text.Length < 33)
            {
                if (result.Text[0] == '0' && result.Text.Length == 1)
                {
                    result.Text = "5";
                }
                else
                    result.Text += "5";
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (result.Text.Length < 33)
            {
                if (result.Text[0] == '0' && result.Text.Length == 1)
                {
                    result.Text = "6";
                }
                else
                    result.Text += "6";
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (result.Text.Length < 33)
            {
                if (result.Text[0] == '0' && result.Text.Length == 1)
                {
                    result.Text = "7";
                }
                else
                    result.Text += "7";
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
           if (result.Text.Length < 33)
            {
                if (result.Text[0] == '0' && result.Text.Length == 1)
                {
                    result.Text = "8";
                }
                else
                    result.Text += "8";
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
          if (result.Text.Length < 33)
            {
                if (result.Text[0] == '0' && result.Text.Length == 1)
                {
                    result.Text = "9";
                }
                else
                    result.Text += "9";
            }
        }

        private void Button_Click_point(object sender, RoutedEventArgs e)
        {
           if (result.Text.Length < 33)
            {
                if (!result.Text.Contains("."))
                    result.Text += ".";
            }
        }

        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
          if (result.Text.Length < 33)
            {
                if (result.Text[0] != '0')
                {
                    result.Text += "0";
                }
                else if (result.Text.Length>1)
                {
                    if(result.Text[1] == '.')
                    result.Text += "0";
                }
            }
        }

        private void Button_Click_C(object sender, RoutedEventArgs e)
        {
            if (result.Text.Length > 0)
            {
                if (result.Text.Length == 1)
                {
                    result.Text = "0";
                }
                else
                    result.Text = result.Text.Remove(result.Text.Length - 1, 1);
            }
        }
        private void result_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
        private void pay_Click(object sender, RoutedEventArgs e)
        {
            if (result.Text.Length > 7)
            {
                txtResponse.Text = "Invalid Amount.";
            }
            else
            {
                txtResponse.Text = "Processing ...";
                PaymentManager mgr = PaymentManager.Instance;
                mgr.setPaymentResponseListener(this);
                mgr.Pay(result.Text, Settings.amountOther, Settings.transaction_type, Settings.transaction_method, Settings.isQuickChip);
                Settings.transaction_type = PaymentSDK.ServiceReference1.TRANSACTION_OPTION.Purchase;  //It will convert Transaction option to purchase if cashBack has changed it cashBack
            }
        }
        public async void Response(PaymentResponseResult res)
        {
            // text box here
            await this.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                txtResponse.Text = PaymentResponseCodes.to_String(res.Status);

                lastTransactionID = res.transactionId;

                if (res.lastfourdigit != null && res.lastfourdigit.Length > 0)
                {
                    txtResponse.Text = txtResponse.Text + "\n" + res.lastfourdigit;
                }

                if (res.cardholdername != null && res.cardholdername.Length > 0)
                {
                    txtResponse.Text = txtResponse.Text + "\n" + res.cardholdername;
                }

                if (res.phonenumber != null && res.phonenumber.Length > 0)
                {
                    txtResponse.Text = txtResponse.Text + "\n" + res.phonenumber;
                }

                if (res.loyaltytrack1 != null && res.loyaltytrack1.Length > 0)
                {
                    txtResponse.Text = txtResponse.Text + "\n" + res.loyaltytrack1;
                }

                if (res.loyaltytrack2 != null && res.loyaltytrack2.Length > 0)
                {
                    txtResponse.Text = txtResponse.Text + "\n" + res.loyaltytrack2;

                }

                if (res.loyaltytrack3 != null && res.loyaltytrack3.Length > 0)
                {
                    txtResponse.Text = txtResponse.Text + "\n" + res.loyaltytrack3;
                }

            });
        }

        private void btnRefund_Click(object sender, RoutedEventArgs e)
        {
            txtResponse.Text = "Processing ...";
            PaymentManager mgr = PaymentManager.Instance;
            mgr.setPaymentResponseListener(this);
            mgr.refundStandAlone(result.Text, PaymentSDK.ServiceReference1.TRANSACTION_OPTION.Refund,
                Settings.transaction_method,Settings.isQuickChip);
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            PaymentManager mgr = PaymentManager.Instance;
            mgr.setPaymentResponseListener(this);
            mgr.cancelTransaction();
        }

        private void btnAuth_Click(object sender, RoutedEventArgs e)
        {
            txtResponse.Text = "Processing ...";

            PaymentManager mgr = PaymentManager.Instance;
            mgr.setPaymentResponseListener(this);
            mgr.Auth(result.Text, Settings.amountOther, Settings.transaction_type, Settings.transaction_method,Settings.isQuickChip);
            Settings.transaction_type = PaymentSDK.ServiceReference1.TRANSACTION_OPTION.Purchase;  //It will convert Transaction option to purchase if cashBack has changed it cashBack
        }

        private void btnRefundid_Click(object sender, RoutedEventArgs e)
        {
            txtResponse.Text = "Processing ...";
            PaymentManager mgr = PaymentManager.Instance;
            mgr.setPaymentResponseListener(this);
            mgr.Refund(result.Text, lastTransactionID, true);
        }

        private void btnVoid_Click(object sender, RoutedEventArgs e)
        {
            txtResponse.Text = "Processing ...";
            PaymentManager mgr = PaymentManager.Instance;
            mgr.setPaymentResponseListener(this);
            mgr.voidTransaction(lastTransactionID);
        }

        private async void btnVoice_Click(object sender, RoutedEventArgs e)
        {
            VoiceTransaction ObjectVoice = new VoiceTransaction();
            var content = await ObjectVoice.ShowAsync();
            if (content == ContentDialogResult.Primary && !string.IsNullOrWhiteSpace(ObjectVoice.AuthCode))
            {
                txtResponse.Text = "Processing ...";

                Settings.authCode = ObjectVoice.AuthCode;

                PaymentManager mgr = PaymentManager.Instance;
                mgr.setPaymentResponseListener(this);
                VoiceReferralResult r = new VoiceReferralResult();
                int x=await mgr.voiceTransaction(result.Text, Settings.authCode, lastTransactionID, Settings.voice_result);
            }
        }

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            txtResponse.Text = "Processing ...";

            PaymentManager mgr = PaymentManager.Instance;
            mgr.setPaymentResponseListener(this);

            mgr.confirmLastTransaction(result.Text, lastTransactionID);
        }

        private void result_SelectionChanged_1(object sender, RoutedEventArgs e)
        {

        }
        public void btn_Menu_Click(object sender, RoutedEventArgs e)
        {
            this.splv_Register.IsPaneOpen = !this.splv_Register.IsPaneOpen;
        }
        private void mn_SettingsClick(object sender, RoutedEventArgs e)
        {

        }
        private void mn_LayaltyTransactionClick(object sender, RoutedEventArgs e)
        {
            txtResponse.Text = "Processing ...";

            PaymentManager mgr = PaymentManager.Instance;
            mgr.setPaymentResponseListener(this);

            mgr.loyaltyTransaction(result.Text);
        }
        private void mn_PowerOnClick(object sender, RoutedEventArgs e)
        {

        }
        private void mn_PowerOffClick(object sender, RoutedEventArgs e)
        {

        }
        private async void mn_TransactionMethodClick(object sender, RoutedEventArgs e)
        {
            TransactionMethod ObjectTransactionMethod = new TransactionMethod();
            var content = await ObjectTransactionMethod.ShowAsync();
            if (content == ContentDialogResult.Primary)
            {
                if (ObjectTransactionMethod.option == 1)
                    Settings.transaction_method = PaymentSDK.ServiceReference1.TransactionMethod.MSR;
                else if (ObjectTransactionMethod.option == 2)
                    Settings.transaction_method = PaymentSDK.ServiceReference1.TransactionMethod.MSR_EMV;
                else if (ObjectTransactionMethod.option == 3)
                    Settings.transaction_method = PaymentSDK.ServiceReference1.TransactionMethod.MSR_EMV_CL;
                this.splv_Register.IsPaneOpen = !this.splv_Register.IsPaneOpen;
            }
        }
        private void mn_PhoneNumberClick(object sender, RoutedEventArgs e)
        {
            txtResponse.Text = "Processing ...";

            PaymentManager mgr = PaymentManager.Instance;
            mgr.setPaymentResponseListener(this);

            mgr.phoneNumber();
        }
        private async void mn_CashBackClick(object sender, RoutedEventArgs e)
        {
            CashBack ObjectCashBack = new CashBack();
            var content = await ObjectCashBack.ShowAsync();
            if(ObjectCashBack.CashbackAmount!=-1 && content!= ContentDialogResult.Secondary)  //Here if ObjectCashBack.CashbackAmount have value=-1, it means that cashback amount was not entered on the propmt
            {
                Settings.transaction_type = PaymentSDK.ServiceReference1.TRANSACTION_OPTION.Cashback;
                result.Text = ObjectCashBack.CashbackAmount.ToString();
                this.splv_Register.IsPaneOpen = !this.splv_Register.IsPaneOpen;
            }
        }
        private async void mn_QuickChipClick(object sender, RoutedEventArgs e)
        {
            QuickChip ObjectQuickChip = new QuickChip();
            var content = await ObjectQuickChip.ShowAsync();
            if (content == ContentDialogResult.Primary)
            {
                if (ObjectQuickChip.IsQuickChip)
                    Settings.isQuickChip = true;
                else
                    Settings.isQuickChip = false;
                this.splv_Register.IsPaneOpen = !this.splv_Register.IsPaneOpen;
            }
        }
        private async void mn_AboutClick(object sender, RoutedEventArgs e)
        {
            About ObjectAbout = new About();
            var content = await ObjectAbout.ShowAsync();
            this.splv_Register.IsPaneOpen = !this.splv_Register.IsPaneOpen;
        }

        private void mn_PowerOffTerminal_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Page_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            
            if (((Frame)Window.Current.Content).ActualHeight > ((Frame)Window.Current.Content).ActualWidth)
            {
                //Portrait Orientation
            }
            else
            {
                //Landscape Orientation
            }
        }
    }
}
