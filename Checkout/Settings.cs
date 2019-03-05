using PaymentSDK;
using PaymentSDK.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout
{
    class Settings
    {
        public static TRANSACTION_OPTION transaction_type = TRANSACTION_OPTION.Purchase;
        public static TransactionMethod transaction_method = TransactionMethod.MSR_EMV_CL;

        public static bool isQuickChip = false;

        public static String amountOther = "0";

        public static string voice_result = "Approved";

        public static String authCode = "0";
    }
}
