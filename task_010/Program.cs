//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

int randomValue = new Random().Next(100, 1000);

int result1 = randomValue % 10;
int result2 = randomValue - result1;
int result3 = result2 / 10;
int result4 = result3 % 10;

Console.WriteLine(randomValue);

Console.WriteLine(result4);

