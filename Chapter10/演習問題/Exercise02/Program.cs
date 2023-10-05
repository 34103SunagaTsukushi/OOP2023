using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            Pickup3DigitNumber("sample.txt");
        }

        private static void Pickup3DigitNumber(string file) {

            var regex = new Regex(@"\b\d{3,}\b");

            foreach (var line in File.ReadLines(file)) {

                var matches = regex.Matches(line);
                foreach(Match match in matches) {
                    Console.WriteLine(match.Value);
                }
               




            }
        }
    }
}
