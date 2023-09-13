using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            DateTime days = new DateTime(2019, 1, 15);
            foreach(var dayofweek in Enum.GetValues(typeof(DayOfWeek))) {

                DateTime nextweek = NextWeek(DateTime.Today, (DayOfWeek)dayofweek);

               Console.WriteLine("{0}の次週の{1}:{2}",DateTime.Today.ToString("yyyy/MM/dd"),
                   nextweek.ToString("dddd"),nextweek.ToString("yyyy/MM/dd (ddd)"));

            }


            //Console.WriteLine( NextWeek(DateTime.Today, DayOfWeek.Sunday));


        }
        public static DateTime NextWeek(DateTime date,DayOfWeek dayOfWeek) {
            var nextday = date.AddDays(7);
            var days = (int)dayOfWeek - (int)(date.DayOfWeek);
            return nextday.AddDays(days);
        }
    }
}
