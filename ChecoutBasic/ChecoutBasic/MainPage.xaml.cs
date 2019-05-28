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
using PaymentSDK.ChecoutServiceReference;
using PaymentSDK;
using Windows.UI.Core;
using Checkout.Custom_user_controls;
using Windows.UI.ViewManagement;
using Windows.UI.Popups;
using GpioSdk;
using ChecoutBasic.Custom_user_controls;
using System.Collections.ObjectModel;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ChecoutBasic
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page, PaymentResponseListener
    {
        int i = 0;
        string lastTransactionID;
        string lastTokenValueID;
        double approvedAmount;
        string cardEntryMode;
        string cardExpirationDate;
        //public List<string> transactionReceipt;

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
                else if (result.Text.Length > 1)
                {
                    if (result.Text[1] == '.')
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

                AuthParameters parameters = new AuthParameters();
                parameters.amount = result.Text.Trim();
                parameters.amountOther = "0";
                parameters.isQuickChip = false;
                parameters.transactionOption = TRANSACTION_OPTION.Purchase;
                parameters.transactionMethod = PaymentSDK.ChecoutServiceReference.TransactionMethod.MSR_EMV_CL;
#if (SHIFT4)
                Shift4AuthParameters gwparams = new Shift4AuthParameters();
                gwparams.customerReference = "";
                gwparams.destinationPostalCode = "";
                gwparams.invoice = "";
                //gwparams.surcharge = "";
                gwparams.tax = Settings.tax;
                gwparams.tip = Settings.tip;

                ObservableCollection<string> ob = new ObservableCollection<string>();

                ob.Add("salmon");
                ob.Add("tuna");
                gwparams.productDescriptors = ob;
                parameters.gateWayParameters = gwparams;
#endif

#if (CREDITCALL)
                //Nothing required from cc prespective

#endif

                mgr.Pay(parameters);
                
                Settings.tax = null;
                Settings.tip = null;
            }
        }

        public async void Response(PaymentResponse res)
        {
            // text box here
            await this.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                txtResponse.Text = PaymentResponseCodes.to_String(res.Status) + "\n" + res.lastfourdigit + "\n" + res.cardholdername;
#if (SHIFT4)
                lastTransactionID = res.invoice;
#endif
#if (CREDITCALL)
                lastTransactionID = res.transactionId;
#endif
                lastTokenValueID = res.cardToken;
                approvedAmount = res.approvedAmount;
                cardEntryMode = res.cardEntryMode;
                cardExpirationDate = res.cardExpirationDate;


                if (res.lastfourdigit != null && res.lastfourdigit.Length > 0)
                {
                    txtResponse.Text = txtResponse.Text + "\n" + res.lastfourdigit;
                }

                if (res.cardholdername != null && res.cardholdername.Length > 0)
                {
                    txtResponse.Text = txtResponse.Text + "\n" + res.cardholdername;
                }

                if (res.PhoneNumber != null && res.PhoneNumber.Length > 0)
                {
                    txtResponse.Text = txtResponse.Text + "\n" + res.PhoneNumber;
                }

                if (res.loyaltyTrack1 != null && res.loyaltyTrack1.Length > 0)
                {
                    txtResponse.Text = txtResponse.Text + "\n" + res.loyaltyTrack1;
                }

                if (res.loyaltyTrack2 != null && res.loyaltyTrack2.Length > 0)
                {
                    txtResponse.Text = txtResponse.Text + "\n" + res.loyaltyTrack2;

                }

                if (res.loyaltyTrack3 != null && res.loyaltyTrack3.Length > 0)
                {
                    txtResponse.Text = txtResponse.Text + "\n" + res.loyaltyTrack3;
                }
            });
        }

        private void btnRefund_Click(object sender, RoutedEventArgs e)
        {
            txtResponse.Text = "Processing ...";
            PaymentManager mgr = PaymentManager.Instance;
            mgr.setPaymentResponseListener(this);

            RefundSAParameters refundSAParameters = new RefundSAParameters();

            refundSAParameters.amount = result.Text.Trim();
            refundSAParameters.transactionOption = TRANSACTION_OPTION.Refund;
            refundSAParameters.transactionMethod = Settings.transaction_method;
            refundSAParameters.isQuickChip = Settings.isQuickChip;

#if (SHIFT4)
            Shift4RefundSAParameters gwrefundSAParameters = new Shift4RefundSAParameters();

            gwrefundSAParameters.customerReference = Settings.customerReference;
            gwrefundSAParameters.destinationPostalCode = Settings.destinationPostalCode;
            gwrefundSAParameters.invoice = "";
            gwrefundSAParameters.surcharge = "";
            ObservableCollection<string> ob = new ObservableCollection<string>();
            ob.Add("salmon");
            ob.Add("tuna");
            gwrefundSAParameters.productDescriptors = ob;

            gwrefundSAParameters.tax = Settings.tax;
            gwrefundSAParameters.tip = Settings.tip;
            refundSAParameters.gatewayRefundParams = gwrefundSAParameters;
#endif


#if (CREDITCALL)
            // nothing required from CC prespective
#endif

            mgr.refundStandAlone(refundSAParameters);

            // should not repeat in the next transaciton. 
            Settings.tax = null;
            Settings.tip = null;
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
            AuthParameters authParameters = new AuthParameters();
            authParameters.amount = result.Text.Trim();
            authParameters.amountOther = "0";
            authParameters.transactionOption = TRANSACTION_OPTION.Purchase;
            authParameters.transactionMethod = PaymentSDK.ChecoutServiceReference.TransactionMethod.MSR_EMV_CL;

#if (SHIFT4)
            Shift4AuthParameters parameters = new Shift4AuthParameters();

            parameters.customerReference = "";
            parameters.destinationPostalCode = "";
            parameters.surcharge = "";
            parameters.tax = Settings.tax;
            parameters.tip = Settings.tip;

            ObservableCollection<string> ob = new ObservableCollection<string>();
            ob.Add("salmon");
            ob.Add("tuna");
            parameters.productDescriptors = ob;
            authParameters.gateWayParameters = parameters;
#endif

#if (CREDITCALL)
            // No special parameter required for CreditCall in this case             
#endif


            mgr.Auth(authParameters);
        }

        private void btnRefundid_Click(object sender, RoutedEventArgs e)
        {
            txtResponse.Text = "Processing ...";

            PaymentManager mgr = PaymentManager.Instance;
            mgr.setPaymentResponseListener(this);

            RefundRefParameters refundRefParameters = new RefundRefParameters();

            refundRefParameters.amount = result.Text.Trim();

#if (SHIFT4)
            Shift4RefundRefParams gwrefundrefparameters = new Shift4RefundRefParams();
            gwrefundrefparameters.cardToken = lastTokenValueID;

#endif


#if (CREDITCALL)
            CCRefundRefParams gwrefundrefparameters = new CCRefundRefParams();
            gwrefundrefparameters.cardEaseRefernce = lastTransactionID;
            
#endif

            refundRefParameters.gatewayRefundRefParameters = gwrefundrefparameters;

            mgr.Refund(refundRefParameters);
        }

        private void btnVoid_Click(object sender, RoutedEventArgs e)
        {
            txtResponse.Text = "Processing ...";
            PaymentManager mgr = PaymentManager.Instance;
            mgr.setPaymentResponseListener(this);

            VoidParameters voidParameters = new VoidParameters();

#if (SHIFT4)
            Shift4VoidParams gwvoidparam = new Shift4VoidParams();
            gwvoidparam.invoice = lastTransactionID;
#endif


#if (CREDITCALL)
             CCVoidParams gwvoidparam = new CCVoidParams();
            gwvoidparam.cardEaseReference = lastTransactionID;
#endif

            voidParameters.gatewayVoidparam = gwvoidparam;
            mgr.voidTransaction(voidParameters);

        }

        private async void btnVoice_Click(object sender, RoutedEventArgs e)
        {
            VoiceMsg ObjectVoiceMsg = new VoiceMsg();
            var content = await ObjectVoiceMsg.ShowAsync();

            if (content == ContentDialogResult.Primary)
            {
                if (ObjectVoiceMsg.AuthCode == null)
                {
                    var dialog = new MessageDialog("Please Enter AuthCode!", "Alert");
                    await dialog.ShowAsync();

                }
                else if (ObjectVoiceMsg.VoiceMsgStatus == null)
                {
                    var dialog = new MessageDialog("Please Select Voice Result Options", "Alert");
                    await dialog.ShowAsync();
                }
                else
                {
                    txtResponse.Text = "Processing ...";

                    PaymentManager mgr = PaymentManager.Instance;
                    mgr.setPaymentResponseListener(this);

                    VoiceParameters voiceParameters = new VoiceParameters();

                    voiceParameters.amount = result.Text.Trim();
                    voiceParameters.authcode = ObjectVoiceMsg.AuthCode;

#if (SHIFT4)
                    Shift4VoiceParameters gwvoiceParams = new Shift4VoiceParameters();
                    gwvoiceParams.cardtoken = lastTokenValueID;
                    gwvoiceParams.customerReference = Settings.customerReference;
                    gwvoiceParams.destinationPostalCode = Settings.destinationPostalCode;
                    gwvoiceParams.invoice = lastTransactionID;
                    gwvoiceParams.requestCategory = ObjectVoiceMsg.VoiceMsgStatus;
                    gwvoiceParams.tax = Settings.tax;
                    gwvoiceParams.tip = Settings.tip;

                    ObservableCollection<string> ob = new ObservableCollection<string>();

                    ob.Add("salmon");
                    ob.Add("tuna");

                    gwvoiceParams.productDescriptors = ob;

#endif
#if (CREDITCALL)
                     CCVoiceParams gwvoiceParams = new CCVoiceParams();
                    gwvoiceParams.CardEaseReference = lastTransactionID;
                    gwvoiceParams.voiceResult = "APPROVED";

#endif

                    voiceParameters.gatewayVoiceParams = gwvoiceParams;

                    await mgr.voiceTransaction(voiceParameters);

                    // should not repeat in the next transaciton. 
                    Settings.tax = null;
                    Settings.tip = null;
                }
            }
        }

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            txtResponse.Text = "Processing ...";

            PaymentManager mgr = PaymentManager.Instance;
            mgr.setPaymentResponseListener(this);

            ConfirmParameters confirmParam = new ConfirmParameters();
            confirmParam.amount = result.Text.Trim();

#if (SHIFT4)

            Shift4ConfirmParams gwconfirmParams = new Shift4ConfirmParams();
            gwconfirmParams.invoice = lastTransactionID;
            gwconfirmParams.cardToken = lastTokenValueID;
            gwconfirmParams.surcharge = Settings.surcharge;
            gwconfirmParams.tax = Settings.tax;
            gwconfirmParams.tip = Settings.tip;


#endif

#if (CREDITCALL)
            CCConfirmParams gwconfirmParams = new CCConfirmParams();
            gwconfirmParams.CardEaseRefernce = lastTransactionID;
            
#endif


            confirmParam.gatewayConfirmParameters = gwconfirmParams;
            mgr.confirmLastTransaction(confirmParam);
           
            Settings.tax = null;
            Settings.tip = null;

        }



        private void mn_IncrementalAuthClick(object sender, RoutedEventArgs e)
        {
            txtResponse.Text = "Processing ...";

            PaymentManager mgr = PaymentManager.Instance;
            mgr.setPaymentResponseListener(this);

            IncrementalAuthParameters incrementalAuthParameters = new IncrementalAuthParameters();
            incrementalAuthParameters.amount = result.Text.Trim();

#if (SHIFT4)

            Shift4IncrementalAuthParams shift4IncrementalAuthParams = new Shift4IncrementalAuthParams();
            shift4IncrementalAuthParams.invoice = lastTransactionID;
            shift4IncrementalAuthParams.cardToken = lastTokenValueID;
            incrementalAuthParameters.gatewayIncrementalAuthParams = shift4IncrementalAuthParams;
            

#endif

#if (CREDITCALL)
            
#endif

            mgr.incrementalAuth(incrementalAuthParameters);
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
            GpioManager manager = GpioManager.Instance;
            manager.PaymentOn();

        }
        private void mn_PowerOffClick(object sender, RoutedEventArgs e)
        {
            GpioManager manager = GpioManager.Instance;
            manager.PaymentOff();
        }
        private async void mn_TransactionMethodClick(object sender, RoutedEventArgs e)
        {
            Checkout.Custom_user_controls.TransactionMethod ObjectTransactionMethod = new Checkout.Custom_user_controls.TransactionMethod();
            var content = await ObjectTransactionMethod.ShowAsync();
            if (content == ContentDialogResult.Primary)
            {
                if (ObjectTransactionMethod.option == 1)
                {
                    Settings.saveState_MSR = true;
                    Settings.saveState_MSR_EMV = false;
                    Settings.saveState_MSR_EMV_CL = false;
                    Settings.transaction_method = PaymentSDK.ChecoutServiceReference.TransactionMethod.MSR;
                }
                else if (ObjectTransactionMethod.option == 2)
                {
                    Settings.saveState_MSR = false;
                    Settings.saveState_MSR_EMV = true;
                    Settings.saveState_MSR_EMV_CL = false;
                    Settings.transaction_method = PaymentSDK.ChecoutServiceReference.TransactionMethod.MSR_EMV;
                }
                else if (ObjectTransactionMethod.option == 3)
                {
                    Settings.saveState_MSR = false;
                    Settings.saveState_MSR_EMV = false;
                    Settings.saveState_MSR_EMV_CL = true;
                    Settings.transaction_method = PaymentSDK.ChecoutServiceReference.TransactionMethod.MSR_EMV_CL;
                }
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
            if (ObjectCashBack.CashbackAmount != -1 && content != ContentDialogResult.Secondary)  //Here if ObjectCashBack.CashbackAmount have value=-1, it means that cashback amount was not entered on the propmt
            {
                Settings.transaction_type = PaymentSDK.ChecoutServiceReference.TRANSACTION_OPTION.Cashback;
                //result.Text = (Double.Parse(result.Text) + ObjectCashBack.CashbackAmount).ToString();
                this.splv_Register.IsPaneOpen = !this.splv_Register.IsPaneOpen;
            }
        }
        public async void mn_QuickChipClick(object sender, RoutedEventArgs e)
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


        public async void mn_AuthTokenClick(object sender, RoutedEventArgs e)
        {
           

            AuthToken ObjectAuthToken = new AuthToken();
            var content = await ObjectAuthToken.ShowAsync();

            Uri uriResult;
            bool result = Uri.TryCreate(ObjectAuthToken.shift4BaseURL, UriKind.Absolute, out uriResult)
            && (uriResult.Scheme == "http" || uriResult.Scheme == "https");


            if (content == ContentDialogResult.Primary)
            {
                if (result == true)
                {
                    if (ObjectAuthToken.authToken != null && ObjectAuthToken.shift4BaseURL != null &&
                        ObjectAuthToken.authToken.Length > 0 && ObjectAuthToken.shift4BaseURL.Length > 0)
                    {
                        PaymentManager mgr = PaymentManager.Instance;
                        ConfigParameters cparams = new ConfigParameters();

                        cparams.gateway = SupportedGateway.SHIFT4;

                        Shift4ConfigParameters parameters = new Shift4ConfigParameters();

                        //Shift4 URL
                        parameters.baseUrl = ObjectAuthToken.shift4BaseURL;
                        cparams.gatewayConfigParameters = parameters;
                        string shift4URL = await mgr.SetApplicationConfig(cparams);

                        //Shift4 AccessToken
                        parameters.authtoken = ObjectAuthToken.authToken;
                        cparams.gatewayConfigParameters = parameters;

                        string accessToken = await mgr.SetApplicationConfig(cparams);

                        if (accessToken != null && accessToken.Length > 1 && shift4URL != null && shift4URL.Length > 1)
                        {
                            var dialog = new MessageDialog("success");
                            await dialog.ShowAsync();
                        }
                        else
                        {
                            var dialog = new MessageDialog("denied");
                            await dialog.ShowAsync();
                        }

                    }
                    else
                    {
                        var dialog = new MessageDialog("Enter Enter Empty Fields");
                        await dialog.ShowAsync();
                    }
                    // this.splv_Register.IsPaneOpen = !this.splv_Register.IsPaneOpen;
                }
                else
                {
                    var dialog = new MessageDialog("Invalid URL");
                    await dialog.ShowAsync();
                }
            }
            this.splv_Register.IsPaneOpen = !this.splv_Register.IsPaneOpen;
        }

        public async void mn_ClerkIdClick(object sender, RoutedEventArgs e)
        {

            ClerkId ObjectClerkId = new ClerkId();
            var content = await ObjectClerkId.ShowAsync();
            if (content == ContentDialogResult.Primary)
            {
                PaymentManager mgr = PaymentManager.Instance;

                ConfigParameters parameters = new ConfigParameters();
                parameters.gateway = SupportedGateway.SHIFT4;

                Shift4ConfigParameters s4params = new Shift4ConfigParameters();
                s4params.clerkId = ObjectClerkId.clerkId;

                parameters.gatewayConfigParameters = s4params;
                await mgr.SetApplicationConfig(parameters);
                
            }
            this.splv_Register.IsPaneOpen = !this.splv_Register.IsPaneOpen;
        }


        public async void mn_TipClick(object sender, RoutedEventArgs e)
        {
            Tip objectTip = new Tip();
            var content = await objectTip.ShowAsync();
            if(content == ContentDialogResult.Primary)
            {
                Settings.tip = objectTip.tip; 
            }
            this.splv_Register.IsPaneOpen = !this.splv_Register.IsPaneOpen;
        }

        public async void mn_TaxClick(object sender, RoutedEventArgs e)
        {
            Tax objectTax = new Tax();
            var content = await objectTax.ShowAsync();
            if (content == ContentDialogResult.Primary)
            {
                Settings.tax = objectTax.tax; 
            }
            this.splv_Register.IsPaneOpen = !this.splv_Register.IsPaneOpen;
        }

        // invoice 
        private async void mn_GetTransactionDataClick(object sender, RoutedEventArgs e)
        {
            txtResponse.Text = "Processing ...";

            PaymentManager mgr = PaymentManager.Instance;
            mgr.setPaymentResponseListener(this);

           await mgr.GetTransactionData(lastTransactionID);
        }

        private async void mn_AboutClick(object sender, RoutedEventArgs e)
        {
            About ObjectAbout = new About();
            var content = await ObjectAbout.ShowAsync();
            this.splv_Register.IsPaneOpen = !this.splv_Register.IsPaneOpen;
        }


        

        private async void mn_ConfigureProcessorClick(object sender, RoutedEventArgs e)
        {
            ConfigureProcessor ObjectCP = new ConfigureProcessor();
            var content = await ObjectCP.ShowAsync();
            this.splv_Register.IsPaneOpen = !this.splv_Register.IsPaneOpen;
        }

        private void mn_PowerOffTerminal_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Page_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            //txtResponse.Text = "Changed"+i.ToString();
            //i++;
            if (((Frame)Window.Current.Content).ActualHeight > ((Frame)Window.Current.Content).ActualWidth)
            {
                txtResponse.Text = "Portrait";
            }
            else
            {
                txtResponse.Text = "Landscape";
            }
        }
	}
}
