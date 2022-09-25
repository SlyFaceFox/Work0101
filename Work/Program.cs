using System;
class Mainclass
{
    static void Main()
    {
        double R, r;
        Console.WriteLine("Введите значение R:");
        R = int.Parse (Console.ReadLine());
        Console.WriteLine("Введите значение r:");
        r = int.Parse (Console.ReadLine());
        double S = Math.PI * ((Math.Pow(R, 2) - (Math.Pow(r, 2))));
        Console.WriteLine("Ответ: {0}", S);
    }
}
