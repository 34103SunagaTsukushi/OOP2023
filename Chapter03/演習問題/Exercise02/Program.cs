using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            var names = new List<string> {
                 "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
            };
            Console.WriteLine("*****3.1*****");
            Exercise2_1(names);
            Console.WriteLine();
            Console.WriteLine("*****3.2*****");
            Exercise2_2(names);
            Console.WriteLine();
            Console.WriteLine("*****3.3*****");
            Exercise2_3(names);
            Console.WriteLine();
            Console.WriteLine("*****3.4*****");
            Exercise2_4(names);


        }

        private static void Exercise2_1(List<string> names) {
            Console.WriteLine("都市名を入力,空行で終了");
            do {
                var line = Console.ReadLine();
                if (string.IsNullOrEmpty(line))
                    break;

                int index = names.FindIndex(s => s.Equals(line));
                Console.WriteLine(index);

            } while (true);

        }

        private static void Exercise2_2(List<string> names) {
            var count = names.Count(s => s.Contains("o"));
            Console.WriteLine(count);
        }

        private static void Exercise2_3(List<string> names) {
            var ans = names.Where(s => s.Contains("o")).ToArray();
            foreach(var name in ans) {
                Console.WriteLine(name);
            }
        }

        private static void Exercise2_4(List<string> names) {
            var ans = names.Where(s => s.StartsWith("B")).Select(s => new {s,s.Length });
            foreach(var name in ans) {
                Console.WriteLine("{0},{1}" ,name.s, name.Length);
            }
        }
    }
}
