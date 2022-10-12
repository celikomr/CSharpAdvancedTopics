namespace ExceptionHandling
{
    public class WorkBench
    {
        public static void WriteInt(int number)
        {
            var arr = new[] { 1, 2, 3 };

            for(int i = 0; i < number; i++)
            {
                try
                {
                    Console.WriteLine(arr[i]);
                }
                catch
                {
                    Console.WriteLine("Index is out of range exception");
                }
                finally
                {
                    Console.WriteLine("This part will be run in every cycle");
                }
            }
        }

        public static void WriteInt2(int number)
        {
            var arr = new[] { 1, 2, 3 };

            for (int i = number; i > number*-1; i--)
            {
                try
                {
                    Console.WriteLine(arr[i]);
                }
                catch(System.Exception) when (i < 0)
                {
                    Console.WriteLine("Index is out of range but 'i' is less then 0");
                }
                catch(System.Exception)
                {
                    Console.WriteLine("Index is out of range exception");
                }
            }
        }
    }
    
}
