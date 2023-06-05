using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {
            var text = "Jackdaws love my big sphinx of quartz";

            Exercise3_1(text);
            Console.WriteLine("-----");

            Exercise3_2(text);
            Console.WriteLine("-----");

            Exercise3_3(text);
            Console.WriteLine("-----");

            Exercise3_4(text);
            Console.WriteLine("-----");

            Exercise3_5(text);
            //{\rtf1}

        }

        private static void Exercise3_1(string text) {
            //var spaces = text.Count(s=> s.ToString().Contains(" "));//訂正版
            var spaces = text.Count(c => c == ' ');//模範 charなのでsよりcの方が望ましい。
            //var spaces = text.ToList().FindAll(s => s.Equals(' ')).Count(); 
            Console.WriteLine("空白数:{0}" ,spaces);
            
            
        }

        private static void Exercise3_2(string text) {
            var replaced = text.Replace("big", "small");
            Console.WriteLine(replaced);
        }

        private static void Exercise3_3(string text) {
            var counts = text.Split(' ').Count();
            Console.WriteLine("単語数：{0}", counts);
        }

        private static void Exercise3_4(string text) {
            var words = text.Split(' ').Where(s => s.Length <= 4);
            foreach (var word in words) {
                Console.WriteLine(word);
            }
            
        }

        private static void Exercise3_5(string text) {
            var sb = new StringBuilder();
            var words = text.Split(' ');
            foreach (var word in words) {
                sb.Append(word);
                if (word != words.Last()) 
                    sb.Append(' ');
            }
            var createWords = sb.ToString();
            Console.WriteLine(createWords );
        }
    }
}
