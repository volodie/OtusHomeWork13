using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusHomeWork13
{
    public static class TopClass
    {
        public static IEnumerable<int> Top(this IEnumerable<int> source, int percentoflist)
        {
            if (percentoflist is < 0 or > 100) 
                throw new ArgumentException("Значение процентов задаются в диапазоне от 0 до 100");
            if (source == null)
                throw new ArgumentNullException("source");
            var orderedSource = source.OrderByDescending(x => x);
            int count = source.Count();  
            int index = -1; 
            int elements = count * percentoflist % 100 != 0 ? count * percentoflist / 100 + 1 : count * percentoflist / 100;
            foreach (int element in orderedSource)
            {
                index++;
                if (index < elements)
                    yield return element;
            }
        }
        public static IEnumerable<TSource> Top<TSource>(this IEnumerable<TSource> source, int percentoflist, Func<TSource, int> selector)
        {
            if (percentoflist is < 0 or > 100) 
                throw new ArgumentException("Значение процентов задаются в диапазоне от 0 до 100");
            if (source == null)
                throw new ArgumentNullException("source");
            if (selector == null)
                throw new ArgumentNullException("selector");
            var orderedSource = source.OrderByDescending(selector);  
            var sourceElements = orderedSource.Select(selector).ToList();
            int count = source.Count();  
            int index = -1;  
            int elements = count * percentoflist % 100 != 0 ? count * percentoflist / 100 + 1 : count * percentoflist / 100;  //вычисление количества элементов для возврата
            foreach (var element in orderedSource)
            {
                index++;
                if (index < elements)
                    yield return element;
            }

        }
    }
}
