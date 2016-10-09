using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Task7_2.Exceptions;

namespace Task7_2
{
    public class StringToInt
    {
        public string Input { get; set; }
        public int ConvertStringToInt(string Input)
        {
            int outPut = 0;
            Regex numberChecker = new Regex(@"^\s*-*[\+0-9,\.]+\s*$");
            Regex integerChecker = new Regex(@"^\s*-*\+*(?=.*[1-9])\d*(?:\,0*)?\s*$");
            if (numberChecker.IsMatch(Input))
            {
                if (integerChecker.IsMatch(Input))
                {
                    checked
                    {
                        outPut = (int)Convert.ToDouble(Input);
                    }
                }
                else
                {
                    throw new NotAnIntegerException($"Error: The string contains not an integer.{Environment.NewLine}");
                }
            }
            else
            {
                throw new NotANumberException($"Error: The string doesn't contain only numbers .{Environment.NewLine}");
            }
            return outPut;
        }
    }
}
