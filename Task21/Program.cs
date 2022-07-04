/*Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84 
A (7,-5, 0); B (1,-1,9) -> 11.53 */
void Task21()
{
System.Console.WriteLine("Введите координаты А: ");
    int AX = Convert.ToInt32(Console.ReadLine()); 
    int AY = Convert.ToInt32(Console.ReadLine()); 
    int AZ = Convert.ToInt32(Console.ReadLine()); 
 System.Console.WriteLine("Введите координаты B: ");
    int BX = Convert.ToInt32(Console.ReadLine()); 
    int BY = Convert.ToInt32(Console.ReadLine()); 
    int BZ = Convert.ToInt32(Console.ReadLine()); 
    Double Length=0;
    Length=Math.Sqrt(Math.Pow(AX-BX,2)+Math.Pow(AY-BY,2)+Math.Pow(AZ-BZ,2));
    System.Console.WriteLine(Length);
}

Task21();