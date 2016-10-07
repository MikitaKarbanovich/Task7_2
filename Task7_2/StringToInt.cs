using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_2
{
    public class StringToInt
    {
        public string Input { get; set; }
        public int ConvertStringToInt(string Input)
        {
            int outPut=1;
            bool IsDigit = Input.Length == Input.Where(c => char.IsDigit(c)).Count();
            if (IsDigit)
            {
                outPut = Convert.ToInt32(Input);
            }
            return outPut;
        }
    }
}
