using PaymentSDK.ChecoutServiceReference;
using System;
using System.Collections.ObjectModel;

namespace ChecoutBasic
{
    class Settings
    {
        public static TRANSACTION_OPTION transaction_type = TRANSACTION_OPTION.Purchase;
        public static TransactionMethod transaction_method = TransactionMethod.MSR_EMV_CL;

        public static bool isQuickChip = false;

        public static String amountOther = "0";

        public static String voice_result = "Approved";

        public static String authCode = "0";

        public static bool saveState_MSR = false;
        public static bool saveState_MSR_EMV = false;
        public static bool saveState_MSR_EMV_CL = false;

        //public static string baseURL;


        // public static string[] apiOptions = null;
        //public static ObservableCollection<string> apiOptions = null;
        //public static string cashback = null;
        public static string surcharge = null;
        public static string tax = null;
        public static string tip = null;
        //public static string entryMode = null;
        //public static string total = null;
        //public static string cardPresent = "Y";
        //public static int numericId;
        //public static string invoice = "158979";
        //public static string notes = null;
        //public static int estimatedDays = 5;
        public static string customerReference = null;
        public static string destinationPostalCode = null;
        //public static string trackData = ";4321000000001119=2212201999999?";



        public static ObservableCollection<string> productDescriptors = new ObservableCollection<string> { "Burger", "Italian Pasta", "Chicken Stake" };
     //   public static ObservableCollection<string> productDescriptors = new ObservableCollection<string> { "Prawns", "Pizza", "Salmon Fish" };
       // public static ObservableCollection<string> productDescriptors = new ObservableCollection<string> { "Soup", "Sushi", "BBQ" };

        //  public static string[] productDescriptors = new string[] { "Spaghetti", "Mexican Pasta", "Beef Stake" };
        //   public static string[] productDescriptors = new string[] { "Prawns", "Tuna Fish", "Salmon Fish" };
        //   public static string[] productDescriptors = new string[] { "Rice", "Sushi", "Chicken Manchurian" };
      //  public static string[] productDescriptors = new string[] { "Soup", "Sushi", "BBQ" };
    }
}
