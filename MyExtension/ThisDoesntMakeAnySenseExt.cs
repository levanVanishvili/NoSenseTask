using System;
using System.Collections.Generic;
using System.Text;

namespace MyExtension
{
     static class ThisDoesntMakeAnySenseExt
     {
        public static IEnumerable<T> ThisDoesntMakeAnySense<T>(this IEnumerable<T> source, Func<T,bool> predicate, Action<T> recorder)
        {
            if (source == null) throw new ArgumentException("source");
            if (predicate == null) throw new ArgumentException("predicate");
            if (recorder == null) throw new ArgumentException("recorder");

            List<T> list = new List<T>();

            foreach (var item in source)
            {
                if (!predicate(item))
                {
                    list.Add(item);
                }
                else
                {
                    recorder(item);
                    return list;
                }
            }
            return list;
        }
     }
}
