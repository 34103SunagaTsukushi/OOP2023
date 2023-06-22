using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            #region

            //var flowerDict = new Dictionary<string, int>() {
            //    ["sunflower"] = 400,
            //    ["pansy"] = 300,
            //    ["tulip"] = 350,
            //    ["rose"] = 500,
            //    ["dahlia"] = 450,
            //};

            ////morning glory(あさがお)【250】を追加
            //flowerDict["morning glory"] = 250;

            //Console.WriteLine("ひまわりの価格は{0}円です。",flowerDict["sunflower"]);
            //Console.WriteLine("チューリップの価格は{0}円です。", flowerDict["tulip"]);
            //Console.WriteLine("あさがおの価格は{0}円です。", flowerDict["morning glory"]);
            
            #endregion

            //Dictionaryの宣言
            var prefDict = new Dictionary<string, string>();


            Console.WriteLine("県庁所在地の登録");
            Console.Write("県名:");
            string pref = Console.ReadLine();
            string city;
            while(pref != ("999")) {
                Console.Write("所在地:");
                city = Console.ReadLine();
                //重複チェック処理
                if (prefDict.ContainsKey(pref)) {
                    Console.WriteLine("同じ県名が存在しています。");
                    Console.WriteLine("上書きしますか？(y/n)");
                    if(Console.ReadLine() == "y") {
                        prefDict[pref] = city;
                    }
                }
                else {
                    prefDict[pref] = city;
                }
                Console.Write("県名:");
                pref = Console.ReadLine();
            }
            //表示方法

            Console.WriteLine("一覧表示:1,県名指定:2");
            int a = int.Parse(Console.ReadLine());
            if(a == 1) {
                foreach(var item in prefDict) {
                    Console.WriteLine("{0}({1})",item.Key,item.Value);
                }
            }
            else {
                Console.Write("県名を入力:");
                string ans = Console.ReadLine();
                if (prefDict.ContainsKey(ans)) {
                    Console.WriteLine("{0}です。", prefDict[ans]);
                }
                else {
                    Console.WriteLine("入力した県名が存在していません。");
                }
            }
            
            

        }
        class CityInfo {
            string City { get; set; }
            string Population { get; set; }
        }
    }
}
