using System.Collections.Generic;

namespace BinarySearch
{
    public static class Search
    {
        public static bool Binary(List<int> sortedList, int choice)
        {
            var mid = sortedList.Count / 2;

            if (sortedList[mid] == choice)
            {
                return true;
            }

            else if (sortedList[mid] > choice)
            {
                if (mid == 0)
                {
                    return false;
                }

                sortedList.RemoveRange(mid, mid);
                return Binary(sortedList, choice);
            }

            else
            {
                if (mid == 0)
                {
                    return false;
                }

                sortedList.RemoveRange(0, mid);
                return Binary(sortedList, choice);
            }
        }
    }
}
