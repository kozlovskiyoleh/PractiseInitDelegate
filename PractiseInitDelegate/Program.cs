// See https://aka.ms/new-console-template for more information
namespace InitDelegate
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] names = { "Oleh", "Maria", "Ivan", "Yura", "Andrew", "Bim", "Toxic", "Dina" };
            BubbleSort(names, CompareStringLenght);
            var compare = new Comparer { Descending = true };
            BubbleSort(names, compare.CompareStrings);
        }

        public static void OutputArray(string[] array)
        {
            foreach(string item in array)
                Console.WriteLine(item);
        }

        public static void BubbleSort(string[] arr, Func<string, string, int> comparer)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (comparer(arr[j], arr[j + 1]) > 0)
                    { 
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
        }

        public static int CompareStringLenght(string? x, string? y)
        {
            if (x == null || y == null)
                throw new ArgumentNullException();
            return x.Length.CompareTo(y.Length);
        }
    }

    class Comparer
    {
        public bool Descending { get; set; }
        public int CompareStrings(string x, string y)
        {
            return x.CompareTo(y) * (Descending ? -1 : 1);
        }
    }
}