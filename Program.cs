// See https://aka.ms/new-console-template for more information
Console.Write("введите номер задания от 1 до 4: ");
int task = Convert.ToInt32(Console.ReadLine());
switch(task)
{
/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
  case 1:
  Console.Write("Введите число: ");
  int a = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите второе число: ");
  int b = Convert.ToInt32(Console.ReadLine());
  if(a < b)
  {
    Console.Write("max = " +b);
  }
  else
  {
    Console.Write("max = " +a);
  }
break;
/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
case 2:
  Console.Write("Введите число: ");
  int a2 = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите второе число: ");
  int b2 = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите третье число: ");
  int c2 = Convert.ToInt32(Console.ReadLine());
  if(a2 > b2 && a2 > c2)
  {
      Console.WriteLine(a2);
  }
  else if (a2 < b2 && c2 < b2)
  {
    Console.WriteLine(b2);
  }
  else if (a2 < c2 && b2 < c2)
  {
    Console.WriteLine(c2);
  }
  else
  {
    Console.Write("invalid input");
  }
break;
/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/
case 3:
  Console.Write("Введите число: ");
  int a3 = Convert.ToInt32(Console.ReadLine());
  if(a3 % 2 == 0)
  {
    Console.WriteLine("да");
  }
  else
  {
    Console.WriteLine("нет");
  }
break;
/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/
case 4:
  Console.Write("Введите число: ");
  int N = Convert.ToInt32(Console.ReadLine());
  int count =1;
  for(count = 1; count <= N; count++)
  {
    if(count % 2 == 0)
    {
      Console.Write(count + " ");
    }

  }
break;
default:
  Console.WriteLine("Введено несуществующее значение задания перезапустите");
break;

}
