using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator001
{
    class Calculations
    {
        public double Value { get; set; }
        public double Number { get; set; }
        public string Calculation { get; set; }
        public bool Op { get; set; }
        public bool IsDecimal { get; set; }


        public static double Addition(Double Value, Double Number)
        {
            return Value + Number;
        }
        public static double Multiplication(Double Value, Double Number)
        {
            return Value * Number;
        }
        public static double Division(Double Value, Double Number)
        {
            return Value / Number;
        }
        public static double Subtraction(Double Value, Double Number)
        {
            return Value - Number;
        }
    }
}
