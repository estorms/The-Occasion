﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using The_Occasion.Models;

namespace The_Occasion.ExtensionMethods
{
    public static class ExtensionMethods
    {
        public static IEnumerable<TSource> DistinctBy<TSource, TKey>
        (this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            HashSet<TKey> seenKeys = new HashSet<TKey>();
            foreach (TSource element in source)
            {
                if (seenKeys.Add(keySelector(element)))
                {
                    yield return element;
                }
            }
        }
    }
}
