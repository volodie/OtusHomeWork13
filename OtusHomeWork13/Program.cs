namespace  OtusHomeWork13
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            list.Top(30).ToList().ForEach(x => Console.WriteLine(x));

            TopForInt ti = new TopForInt();         
            ti.TopInt(20, 67, 11, 19);
            Console.WriteLine(new String('=', 50));

            TopPersons tp = new TopPersons();   
            tp.TopPeople(40, 56, 10 , 23);
            Console.ReadLine();
        }
    }
}
public static class IEnumerableExt
{
    public static IEnumerable<T> Top<T>(this IEnumerable<T> list, double percent)
    {
        var elementCount = (int)Math.Ceiling((double)list.Count() * percent / 100);
        return list.OrderByDescending(x => x).Take(elementCount);
    }
}