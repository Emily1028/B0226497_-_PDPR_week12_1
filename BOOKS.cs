using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B0226497_段昱如_PDPR_week12_1
{
    class BOOKS
    {
        public string NO { set; get; }
        public string TITLE { set; get; }
        public string AUTHOR { set; get; }
        static int COUNTB = 0;
        static int TOTALP;
        public int PRICE, TOTALB = COUNTB += 1;
        public BOOKS(string no, string title, string author, int price)
        {
            NO = no;
            TITLE = title;
            AUTHOR = author;
            PRICE = price;
            TOTALP += price;
        }
        public int AVERAGE()
        {
            return TOTALP / TOTALB;
        }
        public string printME()
        {
            return $"書號:{NO}，書名:{TITLE}，作者:{AUTHOR}，書價:{PRICE}，書本數:{TOTALB}，總價:{TOTALP}，平均書價:{AVERAGE()}\n";
        }
    }
}
