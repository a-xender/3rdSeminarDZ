// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите целое пятизначное число");
// int num = Convert.ToInt32(Console.ReadLine());
// CheckPal(num);

// void CheckPal(int num)
// {
//     if (num > 9999 && num < 100000)
//     {
//         int num1 = (num / 10000) % 10;
//         int num2 = (num / 1000) % 10;
//         if (num1 == num5 && num2 == num4)
//             Console.WriteLine("Да");
//         else
//             Console.WriteLine("Нет");
//     }    int num4 = (num / 10) % 10;
//         int num5 = num % 10;
    

//     else Console.WriteLine("Введено некорректное значение");
// }






// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите координату X первой точки");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y первой точки");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Z первой точки");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату X второй точки");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y второй точки");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Z второй точки");
// int z2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Расстояние между точками = " + Math.Round(Dist(x1, x2, y1, y2, z1, z2),2));

// double Dist(int x1, int x2, int y1, int y2, int z1, int z2)
// {

//     double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) +Math.Pow((z2 - z1), 2));
//     return result;

// }






// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Введите целое число");
// int num = Convert.ToInt32(Console.ReadLine());
// Cubed(num);

// void Cubed(int num)
// {
// for (int i=1; i<=num; i++)
// {
//     Console.Write((i*i*i)+" ");
// }
// }