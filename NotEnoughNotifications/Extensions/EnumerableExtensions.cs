using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotEnoughNotifications.Extensions
{
    internal static class EnumerableExtensions
    {
        public static IEnumerable<T> SkipLast<T>(this IEnumerable<T> source)
        {
            T previous = default;
            bool first = true;

            foreach (T element in source) {
                if (!first) {
                    yield return previous;

                }
                previous = element;
                first = false;
            }
        }
    }
}
