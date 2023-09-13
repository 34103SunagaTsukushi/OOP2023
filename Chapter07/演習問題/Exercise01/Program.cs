using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            var text = "Cozy lummox gives smart squid who asks for job pen";
            Exercise1_1(text);
            Console.WriteLine();
            Exercise1_2(text);

        }

        private static void Exercise1_1(string text) {
            var dict = new Dictionary<Char, int>();
            foreach(var c in text.ToUpper().Where(s=> s != ' ')) {//textを大文字にしつつ、空白を排除
                if (dict.ContainsKey(c)) {
                    dict[c]++;
                }
                else {
                    dict[c] = 1;
                }
            }
            foreach(var item in dict.OrderBy(s => s.Key)) {
                Console.WriteLine("'{0}':{1}", item.Key, item.Value);
            }
        }

        private static void Exercise1_2(string text) {
            var dict = new SortedDictionary<Char, int>();
            foreach(var c in text.ToUpper().Where(s => s !=' ')) {
                if (dict.ContainsKey(c)) {
                    dict[c]++;
                }
                else {
                    dict[c] = 1;
                }

            }
            foreach(var item in dict){//SortedDictionaryなのでOrderByを使わない
                Console.WriteLine("'{0}':{1}", item.Key, item.Value);
            }

        }
    }
}
