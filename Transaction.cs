using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestWebinarSample
{
    public class Transaction
    {
        public int INTERNAL_REFERENCE { get; set; }
        public DateTime DATE { get; set; }

        public int SIGN { get; set; }
        public string GL_CODE { get; set; }
        public int TRCODE { get; set; }
        public string PARENT_GLCODE { get; set; }
        public double DEBIT { get; set; }
        public double CREDIT { get; set; }
        public int LINENO { get; set; }
        public string DESCRIPTION { get; set; }
        public int CURR_TRANS { get; set; }
   
        public double CURRSEL_TRANS { get; set; }





























        //   "INTERNAL_REFERENCE": 1 ,
        //"DATE": "2022-08-18",
        //"SIGN": "0",
        //"GL_CODE": "120.11.1.0006",
        //"TRCODE": 4,
        //"PARENT_GLCODE": 120,
        //"DEBIT": 2500.00,
        //"CREDIT": 0.00,
        //"LINENO": 1,
        //"DESCRIPTION": "mÃ¼ÅŸteri faturasÄ±",
        //"CURR_TRANS": 0,
        //"SOURCE_XRATEDIFF": 0,
        //"RC_XRATE": 0.0,
        //"RC_AMOUNT": 0.0,
        //"TC_XRATE": 1.00000,
        //"TC_AMOUNT": ,
        //"EURO_DEBIT": ,
        //"EURO_CREDIT": ,
        //"CURRSEL_TRANS": 2 },










    }
}
