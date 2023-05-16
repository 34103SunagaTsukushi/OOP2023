using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculator {
    public class SalesCounter {

        private IEnumerable<Sale> _sales;

        //コンストラクタ
        public SalesCounter(string filePath) {
            _sales = ReadSales(filePath);

        }
        //店舗別売り上げを求める
        public IDictionary<string, int> GetPerStoreSales() {
            var dict = new Dictionary<string, int>();
            foreach(var sale in _sales) {
                if (dict.ContainsKey(sale.ShopName))
                    dict[sale.ShopName] += sale.Amount;//店名が存在する
                else
                    dict[sale.ShopName] = sale.Amount;//店名が存在しない
            }
            return dict;
        }
        //売り上げデータを読み込み、Saleオブジェクトのリストを返す
        private static IEnumerable<Sale> ReadSales(string filePath) {
            List<Sale> sales = new List<Sale>();
            //売り上げデータを格納する
            string[] lines = File.ReadAllLines(filePath);
            //ファイルからすべてのデータを読み込む
            foreach (string line in lines) {//すべての行から一行ずつ取り出す

                string[] items = line.Split(',');//区切りで項目別に分ける
                Sale sale = new Sale {  //Saleインスタンスを生成

                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2])
                };
                sales.Add(sale);//Saleインスタンスをコレクションに追加
            }
            return sales;
        }
    }
}
