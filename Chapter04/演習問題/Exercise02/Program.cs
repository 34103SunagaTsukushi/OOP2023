﻿using Exercise01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {

            var ymCollection = new YearMonth[] {
                new YearMonth(1980, 1),
                new YearMonth(1990, 4),
                new YearMonth(2000, 7),
                new YearMonth(2010, 9),
                new YearMonth(2020, 12),
            };

            // 4.2.2
            Console.WriteLine("\n- 4.2.2 ---");
            Exercise2_2(ymCollection);

            Console.WriteLine("\n- 4.2.4 ---");

            // 4.2.4
            Exercise2_4(ymCollection);
            Console.WriteLine("\n- 4.2.5 ---");


            // 4.2.5
            Exercise2_5(ymCollection);
        }

        private static void Exercise2_2(YearMonth[] ymCollection) {
            foreach(var item in ymCollection) {
                Console.WriteLine(item);
            }
        }

        static YearMonth FindFirst21C(YearMonth[] yms) {
            foreach(var ym in yms) {
                if (ym.Is21Century) 
                    return ym;
            }
            return null;
        }

        private static void Exercise2_4(YearMonth[] ymCollection) {
            //var yearmonth = FindFirst21C(ymCollection);
            //var s = yearmonth == null ? "21世紀のデータはありません。" : yearmonth.Year+"年";
            //Console.WriteLine(s);

            if (FindFirst21C(ymCollection) == null) {
                Console.WriteLine("21世紀のデータはありません。");
            }
            else {
                Console.WriteLine(FindFirst21C(ymCollection).Year+"年");
            }
        }

        private static void Exercise2_5(YearMonth[] ymCollection) {
            var newarray = ymCollection.Select(s => s.AddOneMonth()).ToArray();
            Exercise2_2(newarray);
        }
    }
}
