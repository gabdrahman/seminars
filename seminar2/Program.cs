// задача 1

// void MaxDecimal (int num)
// {
//     int ed = num % 10;
//     int dec = num / 10;
//     if(ed > dec)
//     {
//         Console.WriteLine($"большая цифра числа {num} -> {ed}");
//     }
//     else
//     {
//         Console.WriteLine($"большая цифра числа {num} -> {dec}");
//     }
// }

// int num = new Random().Next(10, 100);
// MaxDecimal(num);
//  Задача 2

int DeleteDecimal (int num)
{
 int sot = num / 100;
 int ed = num % 10;
 return sot * 10 + ed;
}

int randomnumbers = new Random().Next(100, 1000);
Console.WriteLine(randomnumbers);
// int result = DeleteDecimal(randomnumbers);
// Console.WriteLine(result);
Console.WriteLine(DeleteDecimal(num, randomnumbers));