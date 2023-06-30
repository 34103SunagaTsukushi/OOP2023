using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            var abbrs = new Abbreviations();

            //7.2.3(Removeの呼び出し)
            
            Console.WriteLine(abbrs.Count);
            Console.Write("消す要素の入力：");
            string remove = Console.ReadLine();
            Console.WriteLine(abbrs.Remove(remove));

            //7.2.4

            abbrs.Sort();
            
        }
    }
}
