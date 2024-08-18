// See https://aka.ms/new-console-template for more information
namespace InitDelegate
{
    public delegate int StringComparer(string x, string y);
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] names = { "Oleh", "Maria", "Ivan", "Yura", "Andrew", "Bim", "Toxic", "Dina" };
            Console.WriteLine("Default array");
            OutputArray(names);
            Console.WriteLine("\n Sorted array by lenght");
            BubbleSort(names, new StringComparer(CompareStringLenght));
            OutputArray(names);
            Console.WriteLine("\n Sorted array by names");
            BubbleSort(names, new StringComparer(CompareString));
            OutputArray(names);
        }

        public static void OutputArray(string[] array)
        {
            foreach(string item in array)
                Console.WriteLine(item);
        }

        public static void BubbleSort(string[] arr, StringComparer comparer)
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

        public static int CompareString(string? x, string? y)
        {
            if (x == null || y == null)
                throw new ArgumentNullException();
            return x.CompareTo(y);
        }
    }
}