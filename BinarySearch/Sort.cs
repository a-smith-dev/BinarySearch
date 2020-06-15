using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearch
{
    public static class Sort
    {
        public static List<int> Bubble(List<int> sortableList)
        {
            var temp = 0;
            for (int i = 0; i < sortableList.Count; i++)
            {
                for (int j = i; j < sortableList.Count; j++)
                {
                    if (sortableList[j] < sortableList[i])
                    {
                        temp = sortableList[j];
                        sortableList[j] = sortableList[i];
                        sortableList[i] = temp;
                    }
                }
            }

            return sortableList;
        }
    }
}
