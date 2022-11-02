namespace AnonymousMethods
{
    public class WorkBench
    {

        // delegate for representing anonymous method
        delegate int del1(int x, int y);
        public delegate int del2(int a, int b, int c);
        public static int defineAfterNum;

        public static void Show(del2 SumOp)
        {
            Console.WriteLine($"In show method : x2 = {SumOp(2, 3, 4)}");
        }

        public static void Calculator(List<int> numList)
        {

            //anonymous method using delegate keyword with return function
            del1 MultOp = delegate (int x, int y) { return x * y; };
            int x1 = MultOp(numList[0], numList[1]);
            Console.WriteLine($"In main method : x1 = {x1}");

            //anonymous method can send to a function as a parameter
            del2 SumOp = delegate (int x, int y, int c) { return x + y + c; };
            Show(SumOp);

            //doesn't require to take parameter
            var defineNum = delegate () { defineAfterNum = 3; };
            defineNum();
            Console.WriteLine($"Defined Num : {defineAfterNum}");

        }

    }

}
