using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Boring
{
    public static class Extensions
    {
        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }

        public static bool IsNotNullOrEmpty(this string value)
        {
            return !string.IsNullOrEmpty(value);
        }

        public static ISet<TSource> ToISet<TSource>(this IOrderedEnumerable<TSource> source)
        {
            return new HashSet<TSource>(source);
        }

        public static ObservableCollection<TSource> ToObservableCollection<TSource>(this IEnumerable<TSource> source)
        {
            return new ObservableCollection<TSource>(source);
        }

        public static void AddRange<T>(this ISet<T> source, IEnumerable<T> itemsToAdd)
        {
            foreach (var item in itemsToAdd)
            {
                source.Add(item);
            }
        }

        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (var item in source)
                action(item);
        }
    }
}
