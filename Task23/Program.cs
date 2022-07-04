/*Напишите программу, которая принимает на вход число (N)
 и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27.
5 -> 1, 8, 27, 64, 125 */

void Task20()
 {
System.Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int count =1;
    while (count<=number)
    {
        System.Console.WriteLine(Math.Pow(count,3));
        count++;
    }
 }
Task20();
