


using CompMath1;
class Program
{
    static void Main(string[] args)
    {
        //// 1 функция
        Console.WriteLine("Для 1 функции:\n");
        Interval interval1 = new Interval(0, 1);
        Interval interval2 = new Interval(-1, 0);
        Interval interval3 = new Interval(3, 4);
        Interval interval4 = new Interval(-4, -3);
        //Простых итераций
        Console.WriteLine("\nПростые итерации:\n");
        float lyambda1 = interval1.Count_Lyambda(Methods.Count1DFunction);
        float lyambda2 = interval2.Count_Lyambda(Methods.Count1DFunction);
        float lyambda3 = interval3.Count_Lyambda(Methods.Count1DFunction);
        float lyambda4 = interval4.Count_Lyambda(Methods.Count1DFunction);
        Interval[] intervals = new Interval[] { interval1, interval2, interval3, interval4 };
        float[] lyambdas = new float[] { lyambda1, lyambda2, lyambda3, lyambda4 };

        for (int i = 0; i < intervals.Length; i++)
        {
            Console.WriteLine($"Для {i + 1} интервала:");
            Methods.SimpleIterations(intervals[i].Get_mid(), lyambdas[i], Methods.Count1Function);
        }
        Console.WriteLine();
        //Ньютон
        Console.WriteLine("\nНьютона:\n");

        float[] intervals_sides = new float[] { interval1.right, interval2.left, interval3.left, interval4.left };
        for (int i = 0; i < intervals.Length; i++)
        {
            Console.WriteLine($"Для {i + 1} интервала:");
            Methods.Neuton(intervals_sides[i], Methods.Count1Function, Methods.Count1DFunction);
        }
        //Половинного деления
        Console.WriteLine("\nПоловинного деления:\n");

        for (int i = 0; i < intervals.Length; i++)
        {
            Console.WriteLine($"Для {i + 1} интервала:");
            Methods.Bisection(intervals[i], Methods.Count1Function);
        }
        // 2 функция
        Console.WriteLine("Для 2 функции:\n");
        Interval interval5 = new Interval(99, 101);
        float lyambda5 = interval5.Count_Lyambda(Methods.Count2DFunction);
        Console.WriteLine("\nПростые итерации:\n");
        Methods.SimpleIterations(interval5.Get_mid(), lyambda5, Methods.Count2Function);
        Console.WriteLine("\nНьютона:\n");
        Methods.Neuton(interval5.right, Methods.Count2Function, Methods.Count2DFunction);
        Console.WriteLine("\nПоловинного деления:\n");
        Methods.Bisection(interval5, Methods.Count2Function);
    }


   
}