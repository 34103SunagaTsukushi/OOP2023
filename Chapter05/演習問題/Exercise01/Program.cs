using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            Console.Write("文字列1を入力:");
            string s1 = Console.ReadLine();

            Console.Write("文字列2を入力:");
            string s2 = Console.ReadLine();

            if(string.Compare(s1 , s2,true) ==0) {
                Console.WriteLine("等しい");
            }
            else {
                Console.WriteLine("等しくない");
            }
        }
    }
}
