namespace Practical5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hi");
            int[] arr = new int[5] { 20, 30, 12, 45, 56};
            try
            {
                for (int i = 0; i <= arr.Length; i++)
                {
                    Console.WriteLine($"array at index {i} = {arr[i]}");
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Error: {ex.Message} Array length is {arr.Length}.");
            }
            catch (Exception ex)
            {
                    Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("This is finally block");
                Console.ReadLine();
            }
        }
    }
}