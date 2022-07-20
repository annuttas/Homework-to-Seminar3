// 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// Примеры:
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
    Console.Write(i * i * i + " ");

// Решение 2:
//int i = 1;
//while (i <= n)
//{
//Console.WriteLine(i * i*i);
//i++;
//}