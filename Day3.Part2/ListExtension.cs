using System;
using System.Linq;

namespace Day3.Part2
{
    public static class ListHelpers
    {
        public static T FindMostCommon<T>(this IEnumerable<T> list)
        {  

            if(IsEqualAmountOfBinaryBits(ConvertToIntList(list)))
            {
                return list.Max();
            }
            return list.GroupBy(_ => _).OrderByDescending(_ => _.Count()).Select(_ => _.Key).First();
        }
        public static T FindLeastCommon<T>(this IEnumerable<T> list)
        {
            if (IsEqualAmountOfBinaryBits(ConvertToIntList(list)))
            {
                var x = list.Min();
                return x;
            }
            return list.GroupBy(_ => _).OrderByDescending(_ => _.Count()).Select(_ => _.Key).Last();
        }

        private static bool IsEqualAmountOfBinaryBits(IEnumerable<int> list) 
        {
            var ones = list.Where(x => x == 1).Count();
            var zeroes = list.Where(x => x == 0).Count();

            if(ones.Equals(zeroes))
            {
                return true;
            }

            return false;
        }

        private static List<int> ConvertToIntList<T>(IEnumerable<T> list)
        {
            List<int> result = new();
            foreach(var item in list)
            {
                int.TryParse(item.ToString(), out int converted);
                result.Add(converted);
            }
            return result;
        }
    }
}