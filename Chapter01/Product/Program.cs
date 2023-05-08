using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSample {


class Program {
        static void Main(string[] args) {

            #region P26のサンプルプログラム
            //インスタンスの生成
            //Product karinto = new Product(123, "かりんとう", 180);
            //Product daifuku = new Product(235, "大福もち", 160);

            //Console.WriteLine("かりんとうの税込価格：" + karinto.GetPriceIncludingTax());
            //Console.WriteLine("大福もちの税込価格：" + daifuku.GetPriceIncludingTax());
            #endregion

            #region 0508演習1
            //今日の日付
            DateTime date = DateTime.Today;
            string today = date.ToString("yyyy年MM月dd日");
            Console.WriteLine("今日の日付:"+today);

            //10日後を求める
            string daysAfter10 = date.AddDays(10).ToString("yyyy年MM月dd日");
            Console.WriteLine("今日の10日後:" + daysAfter10);

            //10日前を求める
            string daysbefore10 = date.AddDays(-10).ToString("yyyy年MM月dd日");
            Console.WriteLine("今日の10日前:" + daysbefore10);
            #endregion




        }
    }
}
