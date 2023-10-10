using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Exercise04 {
    class Program {
        static void Main(string[] args) {
            var lines = File.ReadAllLines("sample.txt");

            //var regex = new Regex(@"(V|v)ersion *= *""v4.0""");
            //var newLines = lines.Select(line => line.Replace(
            //     @"version *= *""v5.0\""", regex.ToString()));

            var newline = lines.Select(s => Regex.Replace(s, @"\b(v|V)ersion\s*=\s*""v4.0""", @"version=""v5.0"""));

            File.WriteAllLines("sample.txt", newline);


            //var pattern = "version=\"v5.0\"";
            //foreach(var line in lines) {
            //    var matches = regex.Matches(line);

            //    foreach(Match match in matches) {
            //        var replace =  
            //            Regex.Replace(line.ToString(), regex.ToString(), @"version *= *""v5.0""");

            //        File.WriteAllLines("sample.text",replace);
            //    }
            //}





            // これ以降は確認用
            var text = File.ReadAllText("sample.txt");
            Console.WriteLine(text);
        }
    }
}
