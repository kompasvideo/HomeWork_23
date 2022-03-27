using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork23
{
    public static class Symbol
    {
        static readonly string  correctSynbols = "0123456789,.-+ ";

        /// <summary>
        /// Проверка что символ корректен, проверка на "0123456789,.-+ "
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool IsCorrectSymbol(char c)
        {            
            return correctSynbols.Contains(c);
        }

        static readonly string firstSynbols = "0123456789,.-+";
        /// <summary>
        /// Проверка что символ ","  проверка на "0123456789,.-+ "
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool IsFirst(char c)
        {
            return firstSynbols.Contains(c);
        }


        CifraAndSeparatorT
    }
}
