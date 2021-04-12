﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queries
{
    public static class MyLinq
    {
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> sourceData,
                                               Func<T, bool> predicate)
        {

            foreach (var item in sourceData)
            {
                if (predicate(item))
                    yield return item;
            }

        }
    }
}
