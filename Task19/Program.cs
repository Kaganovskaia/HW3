/*Напишите программу, которая принимает на вход пятизначное число
 и проверяет, является ли оно палиндромом.
 14212 -> нет 
 23432 -> да 
 12821 -> да */

//Денис, я бьюсь над задачей больше суток((( вроде понимаю как это сделать, но сделать не могу.
//Самое легкое и примитивное решение, которое у меня сработало ниже в Task19((
void Task19()
{
    //int [] number=Console.Readline();
    int [] number={1,2,3,2,1};

    if (number[0]==number[4] && number[1]==number[3]) System.Console.WriteLine("Число является палиндромом");
    else System.Console.WriteLine("Число не является палиндромом");
}

    //Task19();

    //я не могу сделать так, чтобы число вводилось с компа((
        //Я хочу перобразовать ввод с клавиатуры в массив. 
        //Для этого решила преобразовать введенное число в символы и решить как через массив
        //Мне всегда выдает эту ошибку: "Console" не содержит определение для "Readline". А я не знаю что она значит.
void Task191()
{
  System.Console.WriteLine("Введите пятизначное число: ");  
  string[] number=Convert.ToChar(Console.Readline());

    if (number[0]==number[4] && number[1]==number[3]) System.Console.WriteLine("Число является палиндромом");
    else System.Console.WriteLine("Число не является палиндромом");
}

Task191();
