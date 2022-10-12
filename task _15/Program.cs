//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет
 //     НЕ ПОНИМАЮ ПОЧЕМУ НЕ РАБОТАЕТ!!!!  ВСЕ СДЕЛАЛ КАК НА УРОКЕ!!!!!!!

 Console.WriteLine("Введите день недели (1- понедельник)");
 string value = Console.ReadLine();
 int a = int.Parse(value);
 
 if (a==1)
 {
    Console.WriteLine("Понедельник,  рабочий день");
 }
 else if (a==2)
 {
    Console.WriteLine("Вторник,  рабочий день");
 }
 else if (a==3)
 {
    Console.WriteLine("Среда,  рабочий день");
 }
 else if (a==4)
 {
    Console.WriteLine("Четверг,  рабочий день");
 }
 else if (a==5)
 {
    Console.WriteLine("Пятнаца,  рабочий день");
 }
 else if (a==6)
 {
    Console.WriteLine("Суббота, выходной день");
 }
 else if (a==7)
 {
    Console.WriteLine("Воскресенье, выходной день");
 }


