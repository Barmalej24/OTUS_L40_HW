namespace OTUS_L40_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var list2 =  new List<string> { "q", "w", "e", "r" };
            var list3 = new List<Person> {
                    new Person() { Age = 82 },                   
                    new Person() { Age = 26 },
                    new Person() { Age = 57 },
                    new Person() { Age = 34 },
                    new Person() { Age = 67 },
                    new Person() { Age = 10 },
                    new Person() { Age = 77 },
                    new Person() { Age = 70 }
                };

            Console.WriteLine("_________первый лист_________");
            var value = list.Top(30);

            Console.WriteLine($"Тим возвращаемого результата :: {value.GetType()}");

            foreach (var item in value)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine("\n_____________________________");

            Console.WriteLine("_________второй лист_________");
            var value2 = list2.Top(40);

            Console.WriteLine($"Тим возвращаемого результата :: {value2.GetType()}");

            list2.Top(30).ToList().ForEach(x => Console.Write($"{x}\t"));

            Console.WriteLine("\n_____________________________");

            Console.WriteLine("_________третий лист_________");
            var value3 = list3.Top(37, person => person.Age);

            Console.WriteLine($"Тим возвращаемого результата :: {value3.GetType()}");

            value3.ToList().ForEach(x => Console.Write($"{x.Age}\t"));

            Console.WriteLine("\n_____________________________");
        }

        public class Person
        {
            public int Age { get; set; }
        }
    }
}
