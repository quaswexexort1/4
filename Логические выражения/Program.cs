// Записать логическое выражение, определяющее, что из четырех чисел a,b,c,d одно делится на 3, а другое на 5.
try
{
    Console.Write("Введите число A:");
    int A = int.Parse(Console.ReadLine());

    Console.Write("Введите число B:");
    int B = int.Parse(Console.ReadLine());

    Console.Write("Введите число C:");
    int C = int.Parse(Console.ReadLine());

    Console.Write("Введите число D:");
    int D = int.Parse(Console.ReadLine());

    bool asd = (A % 3 == 0) || (B % 3 == 0) || (C % 3 == 0) || (D % 3 == 0);
    bool dsa = (A % 5 == 0) || (B % 3 == 0) || (C % 5 == 0) || (D % 5 == 0);
    
    if (asd && dsa) 
    {
        Console.WriteLine("Одно из чисел делится на 3, а другое на 5.");
    }
    else
    {
        Console.WriteLine("Условие не выполнено");
    }

}

catch
{
    Console.WriteLine("Error");
}