namespace OTUS_L40_HW
{
    public static class Extension
    {
        public static IEnumerable<T> Top<T, Tkey>(this IEnumerable<T> list, int procent, Func<T, Tkey> selector)
        {
            if (procent < 1 || procent > 100)
            {
                throw new ArgumentException("Значения процентного соотношения выходит за предел от 0 до 100");
            }

            var countTakeItem = (int)Math.Ceiling(procent / (100.0 / list.Count()));

            return list.OrderByDescending(selector).Take(countTakeItem);
        }

        public static IEnumerable<T> Top<T>(this IEnumerable<T> list, int procent)
        {
            return list.Top(procent, x => x);
        }
    }
}
