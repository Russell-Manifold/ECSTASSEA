using System;
using System.Windows.Forms;

namespace ECSTASSEA
{
    public partial class Form1 : Form
    {

        private string Serno = "DK198110007";
        private string Authcde = "5635796";
        private PasSDK.PastelPartnerSDK SDK = new PasSDK.PastelPartnerSDK();
        private string StrReturn;

        //Sage50IntegrationMethods SG = new Sage50IntegrationMethods();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            if (txtDataPath.Text.ToString().Trim().Length < 1)
            {
                MessageBox.Show("No data path entered");
            }
            SDK.SetLicense(Serno, Authcde);
           
            StrReturn = SDK.SetDataPath(txtDataPath.Text);
            if (StrReturn.StartsWith("0"))
            {
                MessageBox.Show(GetResultDesc(StrReturn.Split('|')[0]));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Refer to the Partner SDK ==> SDK Calls ==> ImportDocument document for additional details 

            SDK.SetLicense(Serno, Authcde);
            
            //Set Pastel Data Path
            StrReturn = SDK.SetDataPath(txtDataPath.Text);


            //If you do not trap the returncode the SDK will try to use your application path, i.e. where your project files are
            if (StrReturn == "0")
            {
                //Document procedures generally require you to build a header and then n number of lines depending on your line numbers
                // 1) Open Document Files
                if (StrReturn == "0") { SDK.OpenDocumentFiles(); };

                // Refer to the Partner SDK ==> SDK Calls ==> DefineDocumentHeader document for additional details
                // 2) Define the document Header (construct the string)
                if (StrReturn == "0")
                {
                    //StrReturn = SDK.DefineDocumentHeader("||| Customer Code |Date|Order Number|Incl/Excl|Discount|Message no.1|Message no.2|Message no.3|Delivery no.1|Delivery no.2|Delivery no.3|Delivery no.4|Delivery no.5||00||Closing Date|Telephone|Contact||Ex Rate", true);
                    StrReturn = SDK.DefineDocumentHeader("||Y|ACK001|05/03/1999||N|0|Message no.1|Message no.2|Message no.3|Delivery no.1|Delivery no.2|Delivery no.3|Delivery no.4|Delivery no.5||00||05/03/1999|011-7402156|Johnny|011-7402157|1", true);
                }
                // 3) Define the document Lines -  (construct strings) + You need to catch errors when defining each line
                if (StrReturn == "0")
                {
                    // Refer to the Partner SDK ==> SDK Calls ==> DefineDocumentLine  document for additional details
                    //SDK.DefineDocumentLine("Cost Price| Quantity|Unit Selling Price|Inclusive Price|Unit |Tax Type|Discount Type|Discount Percentage| Code| Description |Line Type|Multi-store");
                    SDK.DefineDocumentLine("285|1|350.88|400.00|EACH|01|||ACC/LOC|Description|4|001");
                    SDK.DefineDocumentLine("25.21|2|87.72|100.00|EACH|01|||COM/PCA|Description|4|001");
                    SDK.DefineDocumentLine("0|1|87.72|100.00|EACH|01|||3150000|Description|6|001");
                }

                // 4) Import the document
                // SDK.ImportDocument(Document Type, UserID (Optional));
                SDK.ImportDocument(103, 0);
                //Refer to the Partner SDK ==> Using the SDK ==> Document Types  document for additional details

                //5) Close Document files
                SDK.CloseDocumentFiles();
            }
        }

        public string GetResultDesc(object strRCode)
        {
            string GetResultDescRet = default;
            switch (strRCode)
            {
                case "0":
                    {
                        GetResultDescRet = "0 = Call successfully executed" + '\r' + '\n';
                        break;
                    }

                case "1":
                    {
                        GetResultDescRet = "1 = File Not found" + '\r' + '\n';
                        break;
                    }

                case "2":
                    {
                        GetResultDescRet = "2 = Invalid number of fields" + '\r' + '\n';
                        GetResultDescRet = GetResultDescRet + "Check your SetDataPath call and make sure" + '\r' + '\n';
                        GetResultDescRet = GetResultDescRet + "pastel files exist at that path" + '\r' + '\n';
                        GetResultDescRet = GetResultDescRet + "Try and use directories less than 8 characters long" + '\r' + '\n';
                        break;
                    }

                case "3":
                    {
                        GetResultDescRet = "3 = Record update not successful" + '\r' + '\n';
                        break;
                    }

                case "4":
                    {
                        GetResultDescRet = "4 = Record insert not successful" + '\r' + '\n';
                        break;
                    }

                case "5":
                    {
                        GetResultDescRet = "5 = Record does not exist in file";
                        break;
                    }

                case "6":
                    {
                        GetResultDescRet = "6 = Data path does not exist";
                        break;
                    }

                case "7":
                    {
                        GetResultDescRet = "7 = Access denied";
                        break;
                    }

                case "9":
                    {
                        GetResultDescRet = "9 = End of file";
                        break;
                    }

                case "10":
                    {
                        GetResultDescRet = "10 = Field number specified not valid";
                        break;
                    }

                case "11":
                    {
                        GetResultDescRet = "11 = Invalid period number (1 to 13)";
                        break;
                    }

                case "12":
                    {
                        GetResultDescRet = "12 = Invalid Date";
                        break;
                    }

                case "13":
                    {
                        GetResultDescRet = "13 = Invalid account type (GDC)";
                        break;
                    }

                case "14":
                    {
                        GetResultDescRet = "14 = Invalid general ledger account number";
                        break;
                    }

                case "15":
                    {
                        GetResultDescRet = "15 = General ledger account contains sub accounts";
                        break;
                    }

                case "16":
                    {
                        GetResultDescRet = "16 = General ledger account number must be numeric";
                        break;
                    }

                case "17":
                    {
                        GetResultDescRet = "17 = Invalid customer account code";
                        break;
                    }

                case "18":
                    {
                        GetResultDescRet = "18 = Invalid supplier account code";
                        break;
                    }

                case "19":
                    {
                        GetResultDescRet = "19 = Invalid inventory item code";
                        break;
                    }

                case "20":
                    {
                        GetResultDescRet = "20 = Invalid salesman code";
                        break;
                    }

                case "21":
                    {
                        GetResultDescRet = "21 = Invalid job code";
                        break;
                    }

                case "22":
                    {
                        GetResultDescRet = "22 = Invalid Tax Type (0 to 30)";
                        break;
                    }

                case "23":
                    {
                        GetResultDescRet = "23 = Transaction amount cannot be less that the tax amount";
                        break;
                    }

                case "24":
                    {
                        GetResultDescRet = "24 = Invalid open item transaction type - must be O (Original) or A (Allocation)";
                        break;
                    }

                case "25":
                    {
                        GetResultDescRet = "25 = There cannot be more than 500 lines in a batch";
                        break;
                    }

                case "26":
                    {
                        GetResultDescRet = "26 = Invalid account description";
                        break;
                    }

                case "27":
                    {
                        GetResultDescRet = "27 = Default group needs to set up in Pastel";
                        break;
                    }

                case "28":
                    {
                        GetResultDescRet = "28 = Invalid document line type – must be 2, 5, or 7";
                        break;
                    }

                case "29":
                    {
                        GetResultDescRet = "29 = Invalid exclusive / inclusive – must be 0 or 1";
                        break;
                    }

                case "30":
                    {
                        GetResultDescRet = "30 = Invalid Entry Type (1 to 90)";
                        break;
                    }

                case "31":
                    {
                        GetResultDescRet = "31 = Duplicate inventory item";
                        break;
                    }

                case "32":
                    {
                        GetResultDescRet = "32 = Invalid multi-store code";
                        break;
                    }

                case "33":
                    {
                        GetResultDescRet = "33 = Invalid Currency Code";
                        break;
                    }

                case "99":
                    {
                        GetResultDescRet = "99 = General Error (the error message is the VB 5 error code and description)";
                        break;
                    }
            }

            return GetResultDescRet;
        }
    }
}
