using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork23
{
    public static class Convert
    {
        static MyChar next;
        public static double ConvertToDouble(string str)
        {
            double result = 0;
            bool minus = false;
            double divider = 1;

            for (int i = 0; i < str.Length; i++)
            {
                char currentChar = str[i];
                next = Symbol.GetSymbol(currentChar);
                var process = Symbol.MoveNext(next);
                switch (process)
                {
                    case ProcessState.Start:
                        break;
                    case ProcessState.SignCheck:
                        if (currentChar == '-')
                            minus = true;
                        break;
                    case ProcessState.FirstPart:
                        result *= 10;
                        result += (currentChar - '0');
                        break;
                    case ProcessState.Point:
                        break;
                    case ProcessState.LastPart:
                        divider *= 10;
                        result += (currentChar - '0') / divider;
                        break;
                    case ProcessState.Error:
                        break;
                    case ProcessState.Finish:
                        break;
                    default:
                        break;
                }
            }
            return minus ? -result : result;
            return 0;
        }
    }
}
