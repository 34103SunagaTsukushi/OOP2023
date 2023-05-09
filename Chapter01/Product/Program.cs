using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSample {


class Program {
        static void Main(string[] args) {
            string[] DayOfWeekjp = { "日曜日", "月曜日", "火曜日", "水曜日", "木曜日", "金曜日", "土曜日" };



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
            Console.WriteLine("今日の日付:"+ today);

            //10日後を求める
            string daysAfter10 = date.AddDays(10).ToString("yyyy年MM月dd日");
            Console.WriteLine("今日の10日後:" + daysAfter10);

            //10日前を求める
            string daysbefore10 = date.AddDays(-10).ToString("yyyy年MM月dd日");
            Console.WriteLine("今日の10日前:" + daysbefore10);
            #endregion


            #region 0508演習2
            //入力
            Console.WriteLine("誕生日を入力");
            Console.Write("西暦:");
            int y = int.Parse(Console.ReadLine());
            Console.Write("月:");
            int m = int.Parse(Console.ReadLine());
            Console.Write("日:");
            int d = int.Parse(Console.ReadLine());
            //誕生日
            DateTime birthDay = new DateTime(y, m, d);
            //比較
            TimeSpan timespan = date-birthDay;//dateは今日の日付
            Console.WriteLine("あなたは生まれてから今日まで{0}日目です。",timespan.Days);
            #endregion


            //誕生日の曜日   ( ０１２３４５６ )
            //string youbi = ("日月火水木金土").Substring(int.Parse(birthDay.DayOfWeek.ToString("d")), 1);//substringで取り出す

            Console.WriteLine("あなたは{0}に生まれました。",DayOfWeekjp[(int)birthDay.DayOfWeek]);


        }
    }
}
