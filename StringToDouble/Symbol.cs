using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork23
{
    public static class Symbol
    {
        static Analysis currentState;

        public static MyChar GetSymbol(char c)
        {
            switch (c)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    return MyChar.Cifra;
                case '-':
                case '+':
                    return MyChar.Sign;
                case '.':
                case ',':
                    return MyChar.Separator;
                default:
                    return MyChar.Other;
            }
        }
        public Analysis MoveNext(MyChar symbol)
        {
            currentState = GetNext(symbol);
            return CurrentState;
        }
    }
}
