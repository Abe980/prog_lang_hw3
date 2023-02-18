// Напишите программу, которая принимает на вход пятизначное число и проверяет,
//  является ли оно палиндромом.


// Console.Write("Введите пятизначное число: ");
// string numberStr = Console.ReadLine();
// int numberInt;
// bool isNumber = int.TryParse(numberStr, out numberInt);
// string result = "";

// if (isNumber)
// {
//     if (numberInt < 10000 || numberInt > 99999)
//     {
//     Console.WriteLine($"Число {numberInt} не пятизначное");
//     }
//     else
//     {
        
//         for (int i=4; i>=0; i--)
//         {
//             result = result + numberStr[i];
//         }
        
//         if (result == numberStr)
//         {
//             Console.WriteLine("Палиндром");
//         }
//         else
//         {
//             Console.WriteLine("Не палиндром");
//         }
//     }
// }
// else
// {
//     Console.WriteLine("Надо ввести число");
// }





// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве


// Console.WriteLine("Введите координату точки А по оси х");
// int x1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату точки А по оси y");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату точки А по оси z");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату точки B по оси х");
// int x2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату точки B по оси y");
// int y2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату точки B по оси z");
// int z2 = Convert.ToInt32(Console.ReadLine());

// var result = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));
// Console.WriteLine(Math.Round(result, 2));





// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N


Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());

if (N < 1)
{
    Console.WriteLine("Нет чисел в промежутке");
}
else
{
    for (int i=1; i<=N; i++)
    {
        Console.Write(Math.Pow(i, 3) + "\t");
    }
}