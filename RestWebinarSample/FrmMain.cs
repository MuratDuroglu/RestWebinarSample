using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAF.Plugin.UI;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Threading;

namespace RestWebinarSample
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

   
        public void ChangeButtonStatus()
        {
            grpButtons.Enabled = !grpButtons.Enabled;  
            btnLogout.Enabled = !btnLogout.Enabled;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            txtURL.Text = Global.g_URL;
        }

        private void btnGET_Click(object sender, EventArgs e)
        {

            Stopwatch watch = new Stopwatch();
            watch.Start();


            string result =  Global.HttpGet(txtURL.Text, txtAccessToken.Text);

            dynamic resJSON = JsonConvert.DeserializeObject(result.ToString());

            if (resJSON != null)
            {
                txtJSON.Text = resJSON.ToString();
            }

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            MessageBox.Show(elapsedMs.ToString());


        }

        private void addSalesOrderJson_Click(object sender, EventArgs e)
        {
            txtURL.Text = Global.g_URL + "salesOrders";
            txtJSON.Text = Global.Samples.orderSlip;
        }

        private void btnPOST_Click(object sender, EventArgs e)
        {
            string result = Global.HttpPost(txtURL.Text, txtJSON.Text,txtAccessToken.Text);
            try
            {

                dynamic resJSON = JsonConvert.DeserializeObject(result.ToString());

                if (resJSON != null)
                {
                    txtJSON.Text = resJSON.ToString();
                }
            }
            catch (Exception)
            {
                txtJSON.Text = result.ToString();
            }
        }

        private void getAccessToken_Click_1(object sender, EventArgs e)
        {
        }

        private void AddSqlURL_Click(object sender, EventArgs e)
        {
            txtURL.Text = Global.g_URL + "queries?tsql=SELECT TOP 5 ITM.LOGICALREF, ITM.CODE FROM LG_001_ITEMS ITM WHERE ITM.CARDTYPE <> 22";
        }

        private void AddItemsLimit10_Click(object sender, EventArgs e)
        {
            txtURL.Text = Global.g_URL + "items?limit=10";
        }

        private void AddItemsOffset10_Click(object sender, EventArgs e)
        {
            txtURL.Text = Global.g_URL + "items?offset=10&limit=10";

        }

        private void methodVersion_Click(object sender, EventArgs e)
        {
            txtURL.Text = Global.g_URL + "methods/SerialNo";

        }

        private void URLPopup_Opening(object sender, CancelEventArgs e)
        {

        }

        private void AddItemFull_Click(object sender, EventArgs e)
        {
            txtURL.Text = Global.g_URL + "items/2?expandLevel=full";

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
        }

        private void gETCAPIUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtURL.Text = Global.g_URL + "methods/CAPI/Users";

        }

        private void btnInvoiceStressTest_Click(object sender, EventArgs e)
        {

        }

        private void addARPSlipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtURL.Text = Global.g_URL + "ARPSlips/ApplyRePayPln/0/GOP.01";
            txtJSON.Text = Global.Samples.ARPSlip;

        }

        private void btnPUT_Click(object sender, EventArgs e)
        {
            string result = Global.HttpPut(txtURL.Text, txtJSON.Text, txtAccessToken.Text);
            try
            {

                dynamic resJSON = JsonConvert.DeserializeObject(result.ToString());

                if (resJSON != null)
                {
                    txtJSON.Text = resJSON.ToString();
                }
            }
            catch (Exception)
            {
                txtJSON.Text = result.ToString();
            }
        }

        private void btnUnsafeSQL_Click(object sender, EventArgs e)
        {


            string URL = Global.g_URL + @"queries/Unsafe?tsql="
                + "IF OBJECT_ID (N'[dbo].GetMaxDateTime', N'FN') IS NULL BEGIN EXEC dbo.sp_executesql @statement = N' "
                +" CREATE FUNCTION [dbo].[GetMaxDateTime] (@DATE1 DATETIME, @DATE2 DATETIME) RETURNS datetime AS "
                +" BEGIN SET @DATE1 = ISNULL(@DATE1, ''1900-01-01 00:00:00.000'') SET @DATE2 = ISNULL(@DATE2, ''1900-01-01 00:00:00.000'') "
                +" return CASE WHEN @DATE1 > @DATE2 THEN @DATE1 ELSE @DATE2 END END' END";

            string result = Global.HttpGet(URL, txtAccessToken.Text);

            dynamic resJSON = JsonConvert.DeserializeObject(result.ToString());

            if (resJSON != null)
            {
                txtJSON.Text = resJSON.ToString();
            }

        }

        static void getInvoice()
        {
            string url = "http://172.16.57.114:32001/api/v1/salesInvoices?expandLevel=full&limit=1&q=DOC_NUMBER%20eq%20'M726568'";
            string result = Global.HttpGet(url,Global.accessToken);

            dynamic resJSON = JsonConvert.DeserializeObject(result.ToString());

            if (resJSON != null)
            {
               Console.WriteLine("THREAD : " + Thread.CurrentThread.GetHashCode().ToString() + " START");
               Console.WriteLine(resJSON.ToString());
               Console.WriteLine("THREAD : " + Thread.CurrentThread.GetHashCode().ToString() + " END");
            }

        }

        public static int num_threads = 2;
        public int cnt=10000;

        public void Work(object arg)
        {
            #region clCard
            string clCard = "{"
                    + "  \"ACCOUNT_TYPE\": \"3\",                   "
                    + "  \"CODE\": \"C.01." + Guid.NewGuid().ToString() + "\","
                    + "  \"TITLE\": \"CARI 1 UNVAN #" + arg.ToString() + "\","
                    + "  \"ADDRESS1\": \"asdad a a a as a\",         "
                    + "  \"ADDRESS2\": \"s das as a as as \",        "
                    + "  \"TOWN_CODE\": \"06\",                      "
                    + "  \"TOWN\": \"Gebze\",                        "
                    + "  \"CITY_CODE\": \"41\",                      "
                    + "  \"CITY\": \"Kocaeli\",                      "
                    + "  \"COUNTRY_CODE\": \"TR\",                   "
                    + "  \"COUNTRY\": \"TÜRKİYE\",                   "
                    + "  \"DISCOUNT_RATE\": \"10\",                  "
                    + "  \"E_MAIL\": \"a@a.com\",                    "
                    + "  \"TRADING_GRP\": \"TCG01\",                 "
                    + "  \"EXT_ACC_FLAGS\": \"2\",                   "
                    + "  \"ORD_DAY\": \"127\",                       "
                    + "  \"INVOICE_PRNT_CNT\": \"1\",                "
                    + "  \"PURCHBRWS\": \"1\",                       "
                    + "  \"SALESBRWS\": \"1\",                       "
                    + "  \"IMPBRWS\": \"1\",                         "
                    + "  \"EXPBRWS\": \"1\",                         "
                    + "  \"FINBRWS\": \"1\",                         "
                    + "  \"PERSCOMPANY\": \"1\",                     "
                    + "  \"TCKNO\": \"11111111111\",                 "
                    + "  \"ACCEPT_EINV\": \"1\",                     "
                    + "  \"PROFILE_ID\": \"1\",                      "
                    + "  \"CST_CS_OWN_RISK_TOTAL\": \"20555\",       "
                    + "  \"REP_CST_CS_OWN_RISK_TOTAL\": \"3952.05\", "
                    + "  \"TITLE2\": \"CARI 1 UNVAN 2\",             "
                    + "  \"ISFOREIGN\": \"1\",                       "
                    + "  \"POST_LABEL\": \"aaaaaa\",                 "
                    + "  \"SENDER_LABEL\": \"aaaaaa\",               "
                    + "  \"NAME\": \"adı\",                          "
                    + "  \"SURNAME\": \"soysdı\",                    "
                    + "  \"FACTORY_DIV_NR\": \"1\",                  "
                    + "  \"EINV_CUSTOMS\": \"1\",                    "
                    + "  \"SUB_CONT\": \"1\"                         "
                    + "} ";
            #endregion clCard

            #region salesInvoice

            Random rnd = new Random();
            string ficheNo = Guid.NewGuid().ToString().ToUpper();
            string docNumber = "M" + rnd.Next(100000, 999999).ToString();

            string salesInvoice = "{"
                + "\"TYPE\": \"8\",                                          "
                + "\"NUMBER\": \"" + ficheNo + "\",                   "
                + "\"DATE\": \"04.08.2017\",                                 "
                + "\"TIME\": \"389742592\",                                  "
                + "\"DOC_NUMBER\": \"" + docNumber + "\",                              "
                + "\"AUXIL_CODE\": \"KRT\",                                  "
                + "\"AUTH_CODE\": \"MALTA\",                                 "
                + "\"ARP_CODE\": \"CARI.01\",                                "
                + "\"POST_FLAGS\": \"247\",                                  "
                + "\"TC_XRATE\": \"1\",                                      "
                + "\"TC_NET\": \"657.6\",                                    "
                + "\"RC_XRATE\": \"3.0506\",                                 "
                + "\"RC_NET\": \"215.56\",                                   "
                + "\"CURRSEL_TOTALS\": \"1\",                                "
                + "\"TEXTINC\": \"1\",                                       "
                + "\"ITEXT\": \"10/09/2016 - 10/10/2016\",                   "
                + "\"DOC_DATE\": \"04.08.2017\",                             "
                + "\"EINVOICE\": \"1\",                                      "
                + "\"PROFILE_ID\": \"2\",                                    "
                + "\"ESTATUS\": \"10\",                                      "
                + "\"APPLY_ARP_DISCOUNT\": \"1\",                                      "
                + "\"FILL_GL_CODES_CONN\": \"1\",                                      "
                + "\"EBOOK_DOCTYPE\": \"99\",                                "
                + "\"GUID\": \"" + ficheNo + "\",                   "

                + "  \"DISPATCHES\": {                               "
                + "    \"items\": [{                                 "
                + "      \"TYPE\": \"8\",                            "
                + "      \"NUMBER\": \"" + ficheNo + "\",           "
                + "      \"DATE\": \"08.04.2017\",                   "
                + "      \"TIME\": \"389742592\",                    "
                + "      \"DOC_NUMBER\": \"" + docNumber + "\",                "
                + "      \"INVOICE_NUMBER\": \"" + ficheNo + "\",   "
                + "      \"AUXIL_CODE\": \"KRT\",                    "
                + "      \"AUTH_CODE\": \"MALTA\",                   "
                + "      \"ARP_CODE\": \"CARI.01\",                  "
                + "      \"INVOICED\": \"1\",                        "
                + "      \"RC_RATE\": \"3.0506\",                    "
                + "      \"RC_NET\": \"4547.03\",                    "
                + "      \"CURRSEL_TOTALS\": \"1\",                  "
                + "      \"ORIG_NUMBER\": \"" + ficheNo + "\",      "
                + "      \"TC_RATE\": \"1\",                         "
                + "      \"DEDUCTIONPART1\": \"2\",                  "
                + "      \"DEDUCTIONPART2\": \"3\",                  "
                + "      \"AFFECT_RISK\": \"1\",                     "
                + "      \"DISP_STATUS\": \"1\",                     "
                + "      \"EINVOICE\": \"1\",                         "
                + "      \"GUID\": \"" + ficheNo + "\",                   "
                + "    }]                                            "
                + "  },                                              "
                
                + "\"TRANSACTIONS\": {                                       "
                + "  \"items\": [                                            "
                + "    {                                                     "
                + "      \"TYPE\": \"0\",                                    "
                + "      \"MASTER_CODE\": \"MALZEME.01\",                    "
                + "      \"QUANTITY\": \"" + rnd.Next(5,56)+ "\",                                "
                + "      \"PRICE\": \"" + rnd.Next(20,50)+"\",                           "
                + "      \"TC_XRATE\": \"1\",                                "
                + "      \"RC_XRATE\": \"3.0506\",                           "
                + "      \"DESCRIPTION\": \"(10 Ekim-9 Kasım) (12/12)\",     "
                + "      \"DISPATCH_NUMBER\": \"" + ficheNo + "\",     "
                + "      \"UNIT_CODE\": \"ADET\",                            "
                + "      \"UNIT_CONV1\": \"1\",                              "
                + "      \"UNIT_CONV2\": \"1\",                              "
                + "      \"VAT_RATE\": \"18\",                               "
                + "      \"BILLED\": \"1\",                                  "
                + "      \"EDT_CURR\": \"1\",                                "
                + "      \"GUID\": \"" + Guid.NewGuid().ToString().ToUpper() + "\",                   "
                + "    },                                                    "
                + "    {                                                     "
                + "      \"TYPE\": \"2\",                                    "
                + "      \"DISCOUNT_RATE\": \"" + rnd.Next(5,15)+"\",                 "
                + "      \"DESCRIPTION\": \"Üyelik Yaşı İndirimi (2. Yıl)\", "
                + "      \"DISPATCH_NUMBER\": \"" + ficheNo + "\",     "
                + "      \"GUID\": \"" + Guid.NewGuid().ToString().ToUpper() + "\",                   "
                + "    },                                                    "
                + "    {                                                     "
                + "      \"TYPE\": \"0\",                                    "
                + "      \"MASTER_CODE\": \"MALZEME.02\",                    "
                + "      \"QUANTITY\": \"" + rnd.Next(5, 15) + "\",                               "
                + "      \"PRICE\": \"" + rnd.Next(5, 15) + "\",                            "
                + "      \"TC_XRATE\": \"1\",                                "
                + "      \"RC_XRATE\": \"3.0506\",                           "
                + "      \"UNIT_CODE\": \"ADET\",                            "
                + "      \"UNIT_CONV1\": \"1\",                              "
                + "      \"UNIT_CONV2\": \"1\",                              "
                + "      \"VAT_RATE\": \"18\",                                "
                + "      \"DISPATCH_NUMBER\": \"" + ficheNo + "\",     "
                + "      \"GUID\": \"" + Guid.NewGuid().ToString().ToUpper() + "\",                   "
                + "    },"
                + "    {                                                     "
                + "      \"TYPE\": \"0\",                                    "
                + "      \"MASTER_CODE\": \"MALZEME.01\",                    "
                + "      \"QUANTITY\": \"" + rnd.Next(5, 56) + "\",                                "
                + "      \"PRICE\": \"" + rnd.Next(20, 50) + "\",                           "
                + "      \"TC_XRATE\": \"1\",                                "
                + "      \"RC_XRATE\": \"3.0506\",                           "
                + "      \"DESCRIPTION\": \"(10 Ekim-9 Kasım) (12/12)\",     "
                + "      \"UNIT_CODE\": \"ADET\",                            "
                + "      \"UNIT_CONV1\": \"1\",                              "
                + "      \"UNIT_CONV2\": \"1\",                              "
                + "      \"VAT_RATE\": \"18\",                               "
                + "      \"BILLED\": \"1\",                                  "
                + "      \"EDT_CURR\": \"1\",                                "
                + "      \"DISPATCH_NUMBER\": \"" + ficheNo + "\",     "
                + "      \"GUID\": \"" + Guid.NewGuid().ToString().ToUpper() + "\",                   "
                + "    },                                                    "
                + "    {                                                     "
                + "      \"TYPE\": \"2\",                                    "
                + "      \"DISCOUNT_RATE\": \"" + rnd.Next(5, 15) + "\",                 "
                + "      \"DESCRIPTION\": \"Üyelik Yaşı İndirimi (2. Yıl)\", "
                + "      \"DISPATCH_NUMBER\": \"" + ficheNo + "\",     "
                + "      \"GUID\": \"" + Guid.NewGuid().ToString().ToUpper() + "\",                   "
                + "    },                                                    "
                + "    {                                                     "
                + "      \"TYPE\": \"0\",                                    "
                + "      \"MASTER_CODE\": \"MALZEME.02\",                    "
                + "      \"QUANTITY\": \"" + rnd.Next(5, 15) + "\",                               "
                + "      \"PRICE\": \"" + rnd.Next(5, 15) + "\",                            "
                + "      \"TC_XRATE\": \"1\",                                "
                + "      \"RC_XRATE\": \"3.0506\",                           "
                + "      \"UNIT_CODE\": \"ADET\",                            "
                + "      \"UNIT_CONV1\": \"1\",                              "
                + "      \"UNIT_CONV2\": \"1\",                              "
                + "      \"VAT_RATE\": \"18\",                                "
                + "      \"DISPATCH_NUMBER\": \"" + ficheNo + "\",     "
                + "      \"GUID\": \"" + Guid.NewGuid().ToString().ToUpper() + "\",                   "
                + "    },"
                + "    {                                                     "
                + "      \"TYPE\": \"0\",                                    "
                + "      \"MASTER_CODE\": \"MALZEME.01\",                    "
                + "      \"QUANTITY\": \"" + rnd.Next(5, 56) + "\",                                "
                + "      \"PRICE\": \"" + rnd.Next(20, 50) + "\",                           "
                + "      \"TC_XRATE\": \"1\",                                "
                + "      \"RC_XRATE\": \"3.0506\",                           "
                + "      \"DESCRIPTION\": \"(10 Ekim-9 Kasım) (12/12)\",     "
                + "      \"UNIT_CODE\": \"ADET\",                            "
                + "      \"UNIT_CONV1\": \"1\",                              "
                + "      \"UNIT_CONV2\": \"1\",                              "
                + "      \"VAT_RATE\": \"18\",                               "
                + "      \"BILLED\": \"1\",                                  "
                + "      \"EDT_CURR\": \"1\",                                "
                + "      \"DISPATCH_NUMBER\": \"" + ficheNo + "\",     "
                + "      \"GUID\": \"" + Guid.NewGuid().ToString().ToUpper() + "\",                   "
                + "    },                                                    "
                + "    {                                                     "
                + "      \"TYPE\": \"2\",                                    "
                + "      \"DISCOUNT_RATE\": \"" + rnd.Next(5, 15) + "\",                 "
                + "      \"DESCRIPTION\": \"Üyelik Yaşı İndirimi (2. Yıl)\", "
                + "      \"DISPATCH_NUMBER\": \"" + ficheNo + "\",     "
                + "      \"GUID\": \"" + Guid.NewGuid().ToString().ToUpper() + "\",                   "
                + "    },                                                    "
                + "    {                                                     "
                + "      \"TYPE\": \"0\",                                    "
                + "      \"MASTER_CODE\": \"MALZEME.02\",                    "
                + "      \"QUANTITY\": \"" + rnd.Next(5, 15) + "\",                               "
                + "      \"PRICE\": \"" + rnd.Next(5, 15) + "\",                            "
                + "      \"TC_XRATE\": \"1\",                                "
                + "      \"RC_XRATE\": \"3.0506\",                           "
                + "      \"UNIT_CODE\": \"ADET\",                            "
                + "      \"UNIT_CONV1\": \"1\",                              "
                + "      \"UNIT_CONV2\": \"1\",                              "
                + "      \"VAT_RATE\": \"18\",                                "
                + "      \"DISPATCH_NUMBER\": \"" + ficheNo + "\",     "
                + "      \"GUID\": \"" + Guid.NewGuid().ToString().ToUpper() + "\",                   "
                + "    },"
                + "    {                                                     "
                + "      \"TYPE\": \"0\",                                    "
                + "      \"MASTER_CODE\": \"MALZEME.01\",                    "
                + "      \"QUANTITY\": \"" + rnd.Next(5, 56) + "\",                                "
                + "      \"PRICE\": \"" + rnd.Next(20, 50) + "\",                           "
                + "      \"TC_XRATE\": \"1\",                                "
                + "      \"RC_XRATE\": \"3.0506\",                           "
                + "      \"DESCRIPTION\": \"(10 Ekim-9 Kasım) (12/12)\",     "
                + "      \"UNIT_CODE\": \"ADET\",                            "
                + "      \"UNIT_CONV1\": \"1\",                              "
                + "      \"UNIT_CONV2\": \"1\",                              "
                + "      \"VAT_RATE\": \"18\",                               "
                + "      \"BILLED\": \"1\",                                  "
                + "      \"EDT_CURR\": \"1\",                                "
                + "      \"DISPATCH_NUMBER\": \"" + ficheNo + "\",     "
                + "      \"GUID\": \"" + Guid.NewGuid().ToString().ToUpper() + "\",                   "
                + "    },                                                    "
                + "    {                                                     "
                + "      \"TYPE\": \"2\",                                    "
                + "      \"DISCOUNT_RATE\": \"" + rnd.Next(5, 15) + "\",                 "
                + "      \"DESCRIPTION\": \"Üyelik Yaşı İndirimi (2. Yıl)\", "
                + "      \"DISPATCH_NUMBER\": \"" + ficheNo + "\",     "
                + "      \"GUID\": \"" + Guid.NewGuid().ToString().ToUpper() + "\",                   "
                + "    },                                                    "
                + "    {                                                     "
                + "      \"TYPE\": \"0\",                                    "
                + "      \"MASTER_CODE\": \"MALZEME.02\",                    "
                + "      \"QUANTITY\": \"" + rnd.Next(5, 15) + "\",                               "
                + "      \"PRICE\": \"" + rnd.Next(5, 15) + "\",                            "
                + "      \"TC_XRATE\": \"1\",                                "
                + "      \"RC_XRATE\": \"3.0506\",                           "
                + "      \"UNIT_CODE\": \"ADET\",                            "
                + "      \"UNIT_CONV1\": \"1\",                              "
                + "      \"UNIT_CONV2\": \"1\",                              "
                + "      \"VAT_RATE\": \"18\",                                "
                + "      \"DISPATCH_NUMBER\": \"" + ficheNo + "\",     "
                + "      \"GUID\": \"" + Guid.NewGuid().ToString().ToUpper() + "\",                   "
                + "    },"
                + "    {                                                     "
                + "      \"TYPE\": \"0\",                                    "
                + "      \"MASTER_CODE\": \"MALZEME.01\",                    "
                + "      \"QUANTITY\": \"" + rnd.Next(5, 56) + "\",                                "
                + "      \"PRICE\": \"" + rnd.Next(20, 50) + "\",                           "
                + "      \"TC_XRATE\": \"1\",                                "
                + "      \"RC_XRATE\": \"3.0506\",                           "
                + "      \"DESCRIPTION\": \"(10 Ekim-9 Kasım) (12/12)\",     "
                + "      \"UNIT_CODE\": \"ADET\",                            "
                + "      \"UNIT_CONV1\": \"1\",                              "
                + "      \"UNIT_CONV2\": \"1\",                              "
                + "      \"VAT_RATE\": \"18\",                               "
                + "      \"BILLED\": \"1\",                                  "
                + "      \"EDT_CURR\": \"1\",                                "
                + "      \"DISPATCH_NUMBER\": \"" + ficheNo + "\",     "
                + "      \"GUID\": \"" + Guid.NewGuid().ToString().ToUpper() + "\",                   "
                + "    },                                                    "
                + "    {                                                     "
                + "      \"TYPE\": \"2\",                                    "
                + "      \"DISCOUNT_RATE\": \"" + rnd.Next(5, 15) + "\",                 "
                + "      \"DESCRIPTION\": \"Üyelik Yaşı İndirimi (2. Yıl)\", "
                + "      \"DISPATCH_NUMBER\": \"" + ficheNo + "\",     "
                + "      \"GUID\": \"" + Guid.NewGuid().ToString().ToUpper() + "\",                   "
                + "    },                                                    "
                + "    {                                                     "
                + "      \"TYPE\": \"0\",                                    "
                + "      \"MASTER_CODE\": \"MALZEME.02\",                    "
                + "      \"QUANTITY\": \"" + rnd.Next(5, 15) + "\",                               "
                + "      \"PRICE\": \"" + rnd.Next(5, 15) + "\",                            "
                + "      \"TC_XRATE\": \"1\",                                "
                + "      \"RC_XRATE\": \"3.0506\",                           "
                + "      \"UNIT_CODE\": \"ADET\",                            "
                + "      \"UNIT_CONV1\": \"1\",                              "
                + "      \"UNIT_CONV2\": \"1\",                              "
                + "      \"VAT_RATE\": \"18\",                                "
                + "      \"DISPATCH_NUMBER\": \"" + ficheNo + "\",     "
                + "      \"GUID\": \"" + Guid.NewGuid().ToString().ToUpper() + "\",                   "
                + "    },"
                + "    {                                                     "
                + "      \"TYPE\": \"0\",                                    "
                + "      \"MASTER_CODE\": \"MALZEME.01\",                    "
                + "      \"QUANTITY\": \"" + rnd.Next(5, 56) + "\",                                "
                + "      \"PRICE\": \"" + rnd.Next(20, 50) + "\",                           "
                + "      \"TC_XRATE\": \"1\",                                "
                + "      \"RC_XRATE\": \"3.0506\",                           "
                + "      \"DESCRIPTION\": \"(10 Ekim-9 Kasım) (12/12)\",     "
                + "      \"UNIT_CODE\": \"ADET\",                            "
                + "      \"UNIT_CONV1\": \"1\",                              "
                + "      \"UNIT_CONV2\": \"1\",                              "
                + "      \"VAT_RATE\": \"18\",                               "
                + "      \"BILLED\": \"1\",                                  "
                + "      \"DISPATCH_NUMBER\": \"" + ficheNo + "\",     "
                + "      \"GUID\": \"" + Guid.NewGuid().ToString().ToUpper() + "\",                   "
                + "      \"EDT_CURR\": \"1\",                                "
                + "    },                                                    "
                + "    {                                                     "
                + "      \"TYPE\": \"2\",                                    "
                + "      \"DISCOUNT_RATE\": \"" + rnd.Next(5, 15) + "\",                 "
                + "      \"DESCRIPTION\": \"Üyelik Yaşı İndirimi (2. Yıl)\", "
                + "      \"DISPATCH_NUMBER\": \"" + ficheNo + "\",     "
                + "      \"GUID\": \"" + Guid.NewGuid().ToString().ToUpper() + "\",                   "
                + "    },                                                    "
                + "    {                                                     "
                + "      \"TYPE\": \"0\",                                    "
                + "      \"MASTER_CODE\": \"MALZEME.02\",                    "
                + "      \"QUANTITY\": \"" + rnd.Next(5, 15) + "\",                               "
                + "      \"PRICE\": \"" + rnd.Next(5, 15) + "\",                            "
                + "      \"TC_XRATE\": \"1\",                                "
                + "      \"RC_XRATE\": \"3.0506\",                           "
                + "      \"UNIT_CODE\": \"ADET\",                            "
                + "      \"UNIT_CONV1\": \"1\",                              "
                + "      \"UNIT_CONV2\": \"1\",                              "
                + "      \"VAT_RATE\": \"18\",                                "
                + "      \"DISPATCH_NUMBER\": \"" + ficheNo + "\",     "
                + "      \"GUID\": \"" + Guid.NewGuid().ToString().ToUpper() + "\",                   "
                + "    },"
                + "    {                                                     "
                + "      \"TYPE\": \"0\",                                    "
                + "      \"MASTER_CODE\": \"MALZEME.01\",                    "
                + "      \"QUANTITY\": \"" + rnd.Next(5, 56) + "\",                                "
                + "      \"PRICE\": \"" + rnd.Next(20, 50) + "\",                           "
                + "      \"TC_XRATE\": \"1\",                                "
                + "      \"RC_XRATE\": \"3.0506\",                           "
                + "      \"DESCRIPTION\": \"(10 Ekim-9 Kasım) (12/12)\",     "
                + "      \"UNIT_CODE\": \"ADET\",                            "
                + "      \"UNIT_CONV1\": \"1\",                              "
                + "      \"UNIT_CONV2\": \"1\",                              "
                + "      \"VAT_RATE\": \"18\",                               "
                + "      \"BILLED\": \"1\",                                  "
                + "      \"EDT_CURR\": \"1\",                                "
                + "      \"DISPATCH_NUMBER\": \"" + ficheNo + "\",     "
                + "      \"GUID\": \"" + Guid.NewGuid().ToString().ToUpper() + "\",                   "
                + "    },                                                    "
                + "    {                                                     "
                + "      \"TYPE\": \"2\",                                    "
                + "      \"DISCOUNT_RATE\": \"" + rnd.Next(5, 15) + "\",                 "
                + "      \"DESCRIPTION\": \"Üyelik Yaşı İndirimi (2. Yıl)\", "
                + "      \"DISPATCH_NUMBER\": \"" + ficheNo + "\",     "
                + "      \"GUID\": \"" + Guid.NewGuid().ToString().ToUpper() + "\",                   "
                + "    },                                                    "
                + "    {                                                     "
                + "      \"TYPE\": \"0\",                                    "
                + "      \"MASTER_CODE\": \"MALZEME.02\",                    "
                + "      \"QUANTITY\": \"" + rnd.Next(5, 15) + "\",                               "
                + "      \"PRICE\": \"" + rnd.Next(5, 15) + "\",                            "
                + "      \"TC_XRATE\": \"1\",                                "
                + "      \"RC_XRATE\": \"3.0506\",                           "
                + "      \"UNIT_CODE\": \"ADET\",                            "
                + "      \"UNIT_CONV1\": \"1\",                              "
                + "      \"UNIT_CONV2\": \"1\",                              "
                + "      \"VAT_RATE\": \"18\",                                "
                + "      \"DISPATCH_NUMBER\": \"" + ficheNo + "\",     "
                + "      \"GUID\": \"" + Guid.NewGuid().ToString().ToUpper() + "\",                   "
                + "    },"
                + "    {                                                     "
                + "      \"TYPE\": \"0\",                                    "
                + "      \"MASTER_CODE\": \"MALZEME.01\",                    "
                + "      \"QUANTITY\": \"" + rnd.Next(5, 56) + "\",                                "
                + "      \"PRICE\": \"" + rnd.Next(20, 50) + "\",                           "
                + "      \"TC_XRATE\": \"1\",                                "
                + "      \"RC_XRATE\": \"3.0506\",                           "
                + "      \"DESCRIPTION\": \"(10 Ekim-9 Kasım) (12/12)\",     "
                + "      \"UNIT_CODE\": \"ADET\",                            "
                + "      \"UNIT_CONV1\": \"1\",                              "
                + "      \"UNIT_CONV2\": \"1\",                              "
                + "      \"VAT_RATE\": \"18\",                               "
                + "      \"BILLED\": \"1\",                                  "
                + "      \"EDT_CURR\": \"1\",                                "
                + "      \"DISPATCH_NUMBER\": \"" + ficheNo + "\",     "
                + "      \"GUID\": \"" + Guid.NewGuid().ToString().ToUpper() + "\",                   "
                + "    },                                                    "
                + "    {                                                     "
                + "      \"TYPE\": \"2\",                                    "
                + "      \"DISCOUNT_RATE\": \"" + rnd.Next(5, 15) + "\",                 "
                + "      \"DESCRIPTION\": \"Üyelik Yaşı İndirimi (2. Yıl)\", "
                + "      \"DISPATCH_NUMBER\": \"" + ficheNo + "\",     "
                + "      \"GUID\": \"" + Guid.NewGuid().ToString().ToUpper() + "\",                   "
                + "    },                                                    "
                + "    {                                                     "
                + "      \"TYPE\": \"0\",                                    "
                + "      \"MASTER_CODE\": \"MALZEME.02\",                    "
                + "      \"QUANTITY\": \"" + rnd.Next(5, 15) + "\",                               "
                + "      \"PRICE\": \"" + rnd.Next(5, 15) + "\",                            "
                + "      \"TC_XRATE\": \"1\",                                "
                + "      \"RC_XRATE\": \"3.0506\",                           "
                + "      \"UNIT_CODE\": \"ADET\",                            "
                + "      \"UNIT_CONV1\": \"1\",                              "
                + "      \"UNIT_CONV2\": \"1\",                              "
                + "      \"VAT_RATE\": \"18\",                                "
                + "      \"DISPATCH_NUMBER\": \"" + ficheNo + "\",     "
                + "      \"GUID\": \"" + Guid.NewGuid().ToString().ToUpper() + "\",                   "
                + "    },"
                + "    {                                                     "
                + "      \"TYPE\": \"0\",                                    "
                + "      \"MASTER_CODE\": \"MALZEME.01\",                    "
                + "      \"QUANTITY\": \"" + rnd.Next(5, 56) + "\",                                "
                + "      \"PRICE\": \"" + rnd.Next(20, 50) + "\",                           "
                + "      \"TC_XRATE\": \"1\",                                "
                + "      \"RC_XRATE\": \"3.0506\",                           "
                + "      \"DESCRIPTION\": \"(10 Ekim-9 Kasım) (12/12)\",     "
                + "      \"UNIT_CODE\": \"ADET\",                            "
                + "      \"UNIT_CONV1\": \"1\",                              "
                + "      \"UNIT_CONV2\": \"1\",                              "
                + "      \"VAT_RATE\": \"18\",                               "
                + "      \"BILLED\": \"1\",                                  "
                + "      \"EDT_CURR\": \"1\",                                "
                + "      \"DISPATCH_NUMBER\": \"" + ficheNo + "\",     "
                + "      \"GUID\": \"" + Guid.NewGuid().ToString().ToUpper() + "\",                   "
                + "    },                                                    "
                + "    {                                                     "
                + "      \"TYPE\": \"2\",                                    "
                + "      \"DISCOUNT_RATE\": \"" + rnd.Next(5, 15) + "\",                 "
                + "      \"DESCRIPTION\": \"Üyelik Yaşı İndirimi (2. Yıl)\", "
                + "      \"DISPATCH_NUMBER\": \"" + ficheNo + "\",     "
                + "      \"GUID\": \"" + Guid.NewGuid().ToString().ToUpper() + "\",                   "
                + "    },                                                    "
                + "    {                                                     "
                + "      \"TYPE\": \"0\",                                    "
                + "      \"MASTER_CODE\": \"MALZEME.02\",                    "
                + "      \"QUANTITY\": \"" + rnd.Next(5, 15) + "\",                               "
                + "      \"PRICE\": \"" + rnd.Next(5, 15) + "\",                            "
                + "      \"TC_XRATE\": \"1\",                                "
                + "      \"RC_XRATE\": \"3.0506\",                           "
                + "      \"UNIT_CODE\": \"ADET\",                            "
                + "      \"UNIT_CONV1\": \"1\",                              "
                + "      \"UNIT_CONV2\": \"1\",                              "
                + "      \"VAT_RATE\": \"18\",                                "
                + "      \"DISPATCH_NUMBER\": \"" + ficheNo + "\",     "
                + "      \"GUID\": \"" + Guid.NewGuid().ToString().ToUpper() + "\",                   "
                + "    },"
                + "    {                                                     "
                + "      \"TYPE\": \"0\",                                    "
                + "      \"MASTER_CODE\": \"MALZEME.01\",                    "
                + "      \"QUANTITY\": \"" + rnd.Next(5, 56) + "\",                                "
                + "      \"PRICE\": \"" + rnd.Next(20, 50) + "\",                           "
                + "      \"TC_XRATE\": \"1\",                                "
                + "      \"RC_XRATE\": \"3.0506\",                           "
                + "      \"DESCRIPTION\": \"(10 Ekim-9 Kasım) (12/12)\",     "
                + "      \"UNIT_CODE\": \"ADET\",                            "
                + "      \"UNIT_CONV1\": \"1\",                              "
                + "      \"UNIT_CONV2\": \"1\",                              "
                + "      \"VAT_RATE\": \"18\",                              "
                + "      \"BILLED\": \"1\",                                  "
                + "      \"EDT_CURR\": \"1\",                                "
                + "      \"DISPATCH_NUMBER\": \"" + ficheNo + "\",     "
                + "      \"GUID\": \"" + Guid.NewGuid().ToString().ToUpper() + "\",                   "
                + "    },                                                    "
                + "    {                                                     "
                + "      \"TYPE\": \"2\",                                    "
                + "      \"DISCOUNT_RATE\": \"" + rnd.Next(5, 15) + "\",                 "
                + "      \"DESCRIPTION\": \"Üyelik Yaşı İndirimi (2. Yıl)\", "
                + "      \"DISPATCH_NUMBER\": \"" + ficheNo + "\",     "
                + "      \"GUID\": \"" + Guid.NewGuid().ToString().ToUpper() + "\",                   "
                + "    },                                                    "
                + "    {                                                     "
                + "      \"TYPE\": \"0\",                                    "
                + "      \"MASTER_CODE\": \"MALZEME.02\",                    "
                + "      \"QUANTITY\": \"" + rnd.Next(5, 15) + "\",                               "
                + "      \"PRICE\": \"" + rnd.Next(5, 15) + "\",                            "
                + "      \"TC_XRATE\": \"1\",                                "
                + "      \"RC_XRATE\": \"3.0506\",                           "
                + "      \"UNIT_CODE\": \"ADET\",                            "
                + "      \"UNIT_CONV1\": \"1\",                              "
                + "      \"UNIT_CONV2\": \"1\",                              "
                + "      \"VAT_RATE\": \"18\",                                "
                + "      \"DISPATCH_NUMBER\": \"" + ficheNo + "\",     "
                + "      \"GUID\": \"" + Guid.NewGuid().ToString().ToUpper() + "\",                   "
                + "    }"
                + "  ]                                                       "
                + "}                                                         "
                + "}";
            #endregion

            //string url = "http://172.16.57.114:32001/api/v1/ARPs";
            string url = "http://172.16.57.114:32001/api/v1/salesInvoices";

            string result = Global.HttpPost(url, salesInvoice, Global.accessToken);
            try
            {

                dynamic resJSON = JsonConvert.DeserializeObject(result.ToString());

            }
            catch (Exception)
            {
                Console.WriteLine("Thread #" + arg + " Element " + cnt + " ERROR");
            }

            cnt--;
            Console.WriteLine("Thread #" + arg + " Element " + cnt);
        }

        public void AddClCard()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            while (cnt > 0)
            {
                Thread[] threads = new Thread[num_threads];
                for (int i = 0; i < num_threads; ++i)
                {
                    threads[i] = new Thread(Work);
                    threads[i].Start(i);
                }
                for (int i = 0; i < num_threads; ++i)
                {
                    threads[i].Join();
                }
            }

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            MessageBox.Show(elapsedMs.ToString());
        }

        private void btnThreadTest_Click(object sender, EventArgs e)
        {
            
            Thread thread1 = new Thread(new ThreadStart(getInvoice));
            Thread thread2 = new Thread(new ThreadStart(getInvoice));
            Thread thread3 = new Thread(new ThreadStart(getInvoice));
            Thread thread4 = new Thread(new ThreadStart(getInvoice));
            Thread thread5 = new Thread(new ThreadStart(getInvoice));
            Thread thread6 = new Thread(new ThreadStart(getInvoice));
            Thread thread7 = new Thread(new ThreadStart(getInvoice));
            Thread thread8 = new Thread(new ThreadStart(getInvoice));
            Thread thread9 = new Thread(new ThreadStart(getInvoice));
            Thread thread10 = new Thread(new ThreadStart(getInvoice));

            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();
            thread5.Start();
            thread6.Start();
            thread7.Start();
            thread8.Start();
            thread9.Start();
            thread10.Start();

        }

        private void btnItemStressTest_Click(object sender, EventArgs e)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            for (int j = 0; j < 1000; j++)
            {
                 string ItemCrd = "{"
                        + "      \"INTERNAL_REFERENCE\": \"0\",   "
                        + "      \"RECORD_STATUS\": \"1\",        "
                        + "      \"CARD_TYPE\": \"1\",            "
                        + "      \"CODE\": \"M.TST." + Guid.NewGuid().ToString() + "\","
                        + "      \"NAME\": \"REST M.TST\",        "
                        + "      \"USEF_PURCHASING\": \"1\",      "
                        + "      \"USEF_SALES\": \"1\",           "
                        + "      \"USEF_MM\": \"1\",              "
                        + "      \"VAT\": \"18\",                 "
                        + "      \"AUTOINCSL\": \"1\",            "
                        + "      \"LOTS_DIVISIBLE\": \"1\",       "
                        + "      \"UNITSET_CODE\": \"05\",        "
                        + "      \"DIST_LOT_UNITS\": \"1\",       "
                        + "      \"COMB_LOT_UNITS\": \"1\",       "
                        + "      \"EXT_ACC_FLAGS\": \"3\",        "
                        + "      \"SELVAT\": \"18\",              "
                        + "      \"RETURNVAT\": \"18\",           "
                        + "      \"SELPRVAT\": \"18\",            "
                        + "      \"RETURNPRVAT\": \"18\",         "
                        + "      \"EXTCRD_FLAGS\": \"63\",        "
                        + "      \"UPDATECHILDS\": \"1\",         "
                        + "      \"NAME3\": \"ACIKLAMA 2\",       "
                        + "      \"NAME4\": \"ACIKLAMA 3\"        "
                        + "}                                      ";

                string result = Global.HttpPost(txtURL.Text, ItemCrd, txtAccessToken.Text);
            }

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            txtJSON.Text = string.Format("TEST sonucu {0} ms.", elapsedMs.ToString());
            MessageBox.Show(elapsedMs.ToString());

        }

       private void btnTest_Click(object sender, EventArgs e)
        {
            //AddClCard();
            //Global.getRefreshToken(txtURL.Text+ "token");

              txtJSON.Text = Global.HttpGet(Global.g_URL + "productions/FastRealizeFicheGenerate/88/2377/1/23/1/false/2017-09-14T00:00:00/0"
                  , Global.accessToken);

            /*
            //tek malzeme, JSON boş
              txtJSON.Text = Global.HttpPost(Global.g_URL + "productions/ProdOrderAutomaticGenerate/2377/1013/1048/2017-09-14T00:00:00/0/10/2017-09-14T00:00:00/~/23"
                  , txtJSON.Text , Global.accessToken);
                        //{ "Item":{ "items":[]},"Count":0}
            
            
              txtJSON.Text = Global.HttpPost(Global.g_URL + "productions/ProdOrderAutomaticGenerate/4450/1026/1113/2017-09-14T00:00:00/0/3/2017-09-14T00:00:00/~/23"
                  , txtJSON.Text, Global.accessToken);


            //{ "Item":{ "items":[{"ItemRef":2377,"amount":1,"variantRef":0}, {"ItemRef":2391,"amount":2,"variantRef":0}]},"Count":2}
            */


            /*
            txtJSON.Text = Global.HttpPost(Global.g_URL + "productions/QuickProdFicheProc/2/10/132188430/0/0/0/1"
                , txtJSON.Text, Global.accessToken);
            */


        }

        private void btnPatch_Click(object sender, EventArgs e)
        {
            string result = Global.HttpPatch(txtURL.Text, txtJSON.Text, txtAccessToken.Text);
            try
            {

                dynamic resJSON = JsonConvert.DeserializeObject(result.ToString());

                if (resJSON != null)
                {
                    txtJSON.Text = resJSON.ToString();
                }
            }
            catch (Exception)
            {
                txtJSON.Text = result.ToString();
            }
        }

        private void getAccessToken_Click(object sender, EventArgs e)
        {
            string accessToken = Global.getAccessToken(Global.g_URL + "/token", Global.g_UserName, Global.g_UserPass, Global.g_FirmNr);
            if (accessToken != "")
            {
                ChangeButtonStatus();
                txtAccessToken.Text = accessToken;
                txtJSON.Text = accessToken;
            }

        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            Global.HttpGet(Global.g_URL + "revoke", txtAccessToken.Text);
            txtAccessToken.Text = "";
            ChangeButtonStatus();

        }
    }
}
