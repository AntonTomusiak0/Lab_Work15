namespace ConsoleApp40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 14, 15, 16, 21, 28, 35, 42, 49, 56, 63 };
            Console.WriteLine("Весь масив цілих чисел:");
            PrintArray(numbers);
            Console.WriteLine("\nПарні числа:");
            PrintArray(numbers.GetEvenNumbers());
            Console.WriteLine("\nНепарні числа:");
            PrintArray(numbers.GetOddNumbers());
            int greaterThan = 20;
            Console.WriteLine($"\nЧисла більші за {greaterThan}:");
            PrintArray(numbers.GetNumbersGreaterThan(greaterThan));
            int minRange = 10;
            int maxRange = 30;
            Console.WriteLine($"\nЧисла в діапазоні від {minRange} до {maxRange}:");
            PrintArray(numbers.GetNumbersInRange(minRange, maxRange));
            Console.WriteLine("\nЧисла, кратні семи (відсортовані за зростанням):");
            PrintArray(numbers.GetMultiplesOfSeven());
            Console.WriteLine("\nЧисла, кратні восьми (відсортовані за спаданням):");
            PrintArray(numbers.GetMultiplesOfEightDescending());
            string[] cities = { "Kyiv", "London", "New York", "Paris", "Madrid", "Rome", "Amsterdam", "Berlin", "Los Angeles" };

            Console.WriteLine("Весь масив міст:");
            PrintArray(cities);

            int nameLength = 6;
            Console.WriteLine($"\nМіста з назвою, що має довжину {nameLength}:");
            PrintArray(cities.GetCitiesWithNameLength(nameLength));

            Console.WriteLine("\nМіста, які починаються на 'A':");
            PrintArray(cities.GetCitiesStartingWith('A'));

            Console.WriteLine("\nМіста, які закінчуються на 'm':");
            PrintArray(cities.GetCitiesEndingWith('m'));

            Console.WriteLine("\nМіста, які починаються на 'N' і закінчуються на 'k':");
            PrintArray(cities.GetCitiesStartingWithEndingWith("N", "k"));

            Console.WriteLine("\nМіста, які починаються на 'Ne' (відсортовані за спаданням):");
            PrintArray(cities.GetCitiesStartingWithDescending("Ne"));
            static void PrintArray(int[] array)
            {
                foreach (int num in array)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
            Student[] students = {
            new Student("John", "Doe", 21, "MIT"),
            new Student("Alice", "Brooks", 18, "Oxford"),
            new Student("Boris", "Smith", 22, "MIT"),
            new Student("Emma", "Brown", 20, "Harvard"),
            new Student("Mark", "Taylor", 19, "Stanford"),
            new Student("Nina", "Clark", 23, "Cambridge"),
            new Student("Brody", "Adams", 25, "Oxford"),
            new Student("Noah", "Walker", 20, "MIT")
        };

            Console.WriteLine("Весь масив студентів:");
            PrintArray(students);

            string name = "Boris";
            Console.WriteLine($"\nСтуденти з ім'ям '{name}':");
            PrintArray(students.GetStudentsWithName(name));

            string lastNameStartsWith = "Bro";
            Console.WriteLine($"\nСтуденти з прізвищем, яке починається на '{lastNameStartsWith}':");
            PrintArray(students.Get
        }
    }
    public static class ArrayExtensions
    {
        public static int[] GetEvenNumbers(this int[] array)
        {
            return array.Where(x => x % 2 == 0).ToArray();
        }

        public static int[] GetOddNumbers(this int[] array)
        {
            return array.Where(x => x % 2 != 0).ToArray();
        }

        public static int[] GetNumbersGreaterThan(this int[] array, int value)
        {
            return array.Where(x => x > value).ToArray();
        }

        public static int[] GetNumbersInRange(this int[] array, int min, int max)
        {
            return array.Where(x => x >= min && x <= max).ToArray();
        }

        public static int[] GetMultiplesOfSeven(this int[] array)
        {
            return array.Where(x => x % 7 == 0).OrderBy(x => x).ToArray();
        }

        public static int[] GetMultiplesOfEightDescending(this int[] array)
        {
            return array.Where(x => x % 8 == 0).OrderByDescending(x => x).ToArray();
        }
    }
    public static class StringArrayExtensions
    {
        public static string[] GetCitiesWithNameLength(this string[] array, int length)
        {
            return array.Where(x => x.Length == length).ToArray();
        }

        public static string[] GetCitiesStartingWith(this string[] array, char startChar)
        {
            return array.Where(x => x.StartsWith(startChar.ToString(), StringComparison.OrdinalIgnoreCase)).ToArray();
        }

        public static string[] GetCitiesEndingWith(this string[] array, char endChar)
        {
            return array.Where(x => x.EndsWith(endChar.ToString(), StringComparison.OrdinalIgnoreCase)).ToArray();
        }

        public static string[] GetCitiesStartingWithEndingWith(this string[] array, string start, string end)
        {
            return array.Where(x => x.StartsWith(start, StringComparison.OrdinalIgnoreCase) && x.EndsWith(end, StringComparison.OrdinalIgnoreCase)).ToArray();
        }

        public static string[] GetCitiesStartingWithDescending(this string[] array, string start)
        {
            return array.Where(x => x.StartsWith(start, StringComparison.OrdinalIgnoreCase)).OrderByDescending(x => x).ToArray();
        }
    }
}