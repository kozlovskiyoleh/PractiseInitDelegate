// See https://aka.ms/new-console-template for more information
using PractiseInitDelegate;

namespace InitDelegate
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] names = { "Oleh", "Maria", "Ivan", "Yura", "Andrew", "Bim", "Toxic", "Dina" };
            BubbleSort(names, new StringsLenghtComparer());
            BubbleSort(names, new StringsComparer());
        }

        public static void BubbleSort(string[] arr, IComparer<string> comparer)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (comparer.Compare(arr[j], arr[j + 1])>0)
                    { 
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
        }
    }
}