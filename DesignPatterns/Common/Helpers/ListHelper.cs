using System;
using System.Collections.Generic;

namespace Common.Helpers
{
    /// <summary>
    /// Helpers for lists
    /// </summary>
    public static class ListHelper
    {
        public static void For<T>(this List<T> list, Action<T, int> action)
        {
            for (int i = 0; i < list.Count; i++)
            {
                action(list[i],i);
            }
        }
    }
}
