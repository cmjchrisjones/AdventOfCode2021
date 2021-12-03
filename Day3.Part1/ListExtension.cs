using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.Part1
{
    public static class ListHelpers
    {
        public static T FindMostCommon<T>(this IEnumerable<T> list)
        {
            return list.GroupBy(_ => _).OrderByDescending(_ => _.Count()).Select(_ => _.Key).First();
        }
        public static T FindLeastCommon<T>(this IEnumerable<T> list)
        {
            return list.GroupBy(_ => _).OrderByDescending(_ => _.Count()).Select(_ => _.Key).Last();
        }
    }
}