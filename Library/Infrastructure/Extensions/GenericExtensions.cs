using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Infrastructure.Extensions
{
    public static class GenericExtensions
    {
        public static string ToString<T>(this List<T> list)
        {
            string str = "";

            for (int i = 0; i < list.Count; i++)
            {
                if (i != list.Count - 1) str += list[i] + ",";
                else str += list[i];
            }

            return str;
        }
    }
}
