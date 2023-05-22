using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {
            var sales = new SalesCounter(@"data\sales.csv");//..\ 一階層上
            Console.WriteLine("**売上集計**");
            Console.WriteLine("1.店舗別売上");
            Console.WriteLine("2.商品カテゴリー別売上");

            int ans = int.Parse(Console.ReadLine());

            if (ans == 1) {
                var amountPerStore = sales.GetPerStoreSales();
                foreach (var obj in amountPerStore) {
                    Console.WriteLine("{0}{1:C}", obj.Key, obj.Value);
                }
            }
            else if(ans == 2) {
                var amountPerCategory = sales.GetPerCategorySales();
                foreach (var obj in amountPerCategory) {
                    Console.WriteLine("{0}{1:C}", obj.Key, obj.Value);
                }
            }
        }
    }
}
