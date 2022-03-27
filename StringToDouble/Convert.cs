using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork23
{
    public static class Convert
    {
        static Next next = Next.First;
        public static double ConvertToDouble(string str)
        {
            foreach (char c in str)
            {
                if(Symbol.IsCorrectSymbol(c))
                {
                    if (next == Next.First)
                    {
                        if (Symbol.IsFirst(c))
                        {
                            next = Next.CifraAndSeparatorT;
                        }
                    }   
                    else if (next == Next.CifraAndSeparatorT)
                    {

                    }
                    else if (next == Next.CifraAndSeparatorZ)
                    {

                    }
                    else
                    {

                    }
                }
            }
            return 0;
        }
    }
}
