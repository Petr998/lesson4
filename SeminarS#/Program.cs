// See https://aka.ms/new-console-template for more information

// Эта команда выводит текст
// Console.WriteLine("Hello, World!");

// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное само на себя)
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49


// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int rezult= num*num;
// Console.WriteLine(rezult);


// Задача №2 Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3, b = 9 -> нет

// Console.WriteLine("Введите число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if(num1 == num2*num2)
// {
//     Console.WriteLine("Да");
// }
// else
// {
// Console.WriteLine("Нет");    
// }


// Задача №3 Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

// Console.WriteLine("Введите число");
// int num1 = Convert.ToInt32(Console.ReadLine());

// if(num1 == 1)
// {
//    Console.WriteLine("Понедельник"); 
// }
// else if(num1 == 2)
// {
//    Console.WriteLine("Вторник"); 
// }
// else if(num1 == 3)
// {
//    Console.WriteLine("Среда"); 
// }
// else if(num1 == 4)
// {
//    Console.WriteLine("Четверг"); 
// }
// else if(num1 == 5)
// {
//    Console.WriteLine("Пятница"); 
// }
// else if(num1 == 6)
// {
//    Console.WriteLine("Суббота"); 
// }
// else if(num1 == 7)
// {
//    Console.WriteLine("Воскресенье"); 
// }
// else
// {
//    Console.WriteLine("Такого дня нет"); 
// }


//  Задача №4 Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
//  4 -> "-4, -3,-2, -1, 0, 1, 2, 3, 4"
//  2 -> "-2, -1, 0, 1, 2"

// Console.WriteLine("Введите число");
// int num1 = Convert.ToInt32(Console.ReadLine());

// int NegNum = num1 * -1;

// while(NegNum <= num1)
// {
//     Console.Write(NegNum + " ");
//     NegNum = NegNum + 1;
// }


// Задача №5 Напишите программу, которая принимает на вход трехзначное число,а на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

// Console.WriteLine("Введите число");
// int num1 = Convert.ToInt32(Console.ReadLine());

// int rezult = num1 % 10;
// Console.WriteLine(rezult);


// Домашнее задание
// Задача 1. На вход принимает 2 числа и выводит какое число большее, какое меньшее.

// Console.Write("firstNumber: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("secondNumber: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// if(firstNumber > secondNumber)
// {
//    Console.WriteLine("первое число больше"); 
// }
// else if(firstNumber < secondNumber)
// {
//   Console.WriteLine("второе число больше");  
// }
// else
// {
//   Console.WriteLine("числа равны");   
// }


//Задача 2. На вход принимает число(Number), а на выходе выводит все четные числа от 1 до Number (включительно), после каждого числа должен быть знак пробела.

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());

// int num = 1;

// while(num < number)
// {
//     num = num + 1;
//     if(num % 2 == 0)
//     Console.Write(num + " ");
// }


//Задача 3. На вход принимает число number и выводит, является ли число четным.

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());

// if(number % 2 == 0)
// {
//  Console.WriteLine("четное");   
// }
// else
// {
//   Console.WriteLine("нечетное");   
// }


//Задача 4. Принимает на вход 3 числа и выдает максимальное из этих чисел.

// Console.WriteLine("Введите число a:");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число b:");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число c:");
// int c = Convert.ToInt32(Console.ReadLine());

// int max = a;
// if (b > a)
// {
//     max = b;
// }
// if (c > max)
// {
//     max = c;
// }
// //return max;
// Console.WriteLine("Максимальное число: " + max); 