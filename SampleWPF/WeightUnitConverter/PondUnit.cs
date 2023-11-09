using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightUnitConverter {
    class PondUnit : WeightUnit{
        private static List<PondUnit> units = new List<PondUnit> {
            new PondUnit { Name = "lb", Coefficient = 1,},
            new PondUnit { Name = "oz", Coefficient = 0.0625,},

        };
        public static ICollection<PondUnit> Units { get { return units; } }

        /// <summary>
        /// グラム単位からポンド単位に変換
        /// </summary>
        /// <param name="unit">グラム単位</param>
        /// <param name="value">値</param>
        /// <returns>ポンド単位</returns>
        public double FromGramUnit(GramUnit unit,double value) {
            return (value * unit.Coefficient) / 453.6 / this.Coefficient;
        }


    }
}
