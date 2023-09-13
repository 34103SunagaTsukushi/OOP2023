using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0411 {
    class Program {
        static void Main(string[] args) {

            Console.Write("金額：");
            int kingaku = int.Parse(Console.ReadLine());
            Console.Write("支払額：");
            int siharai = int.Parse(Console.ReadLine());
            //メソッドの呼び出し
            Calc(kingaku, siharai);

        }
        //メソッド
        private static void Calc(int kingaku, int siharai) {

            int oturi = siharai - kingaku;
            Console.WriteLine("お釣：" + oturi + "円");

            //お釣計算
            string[] moneyString = { "一万円札", "五千円札","二千円札","千円札 ", "五百円玉", "百円玉", "五十円玉",
                "十円玉", "五円玉", "一円玉" };

            int[] money = { 10000, 5000, 2000, 1000, 500, 100, 50, 10, 5, 1 };

            for (int i = 0; i < money.Length; i++)
            {
                Console.Write(moneyString[i] + "："); //oturi / money[i]
                astOut(oturi / money[i]);
                oturi %= money[i];
            }
        }
        private static void astOut(int count) {
            for (int j = 0; j <count ; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}