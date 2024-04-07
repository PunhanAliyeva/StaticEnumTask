namespace StaticEnumTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[0];
            Array.Resize(ref arr, 4);
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            Console.WriteLine(sum);
        }
    }
}