// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным. 

// 6 -> да
// 7 -> да
// 1 -> нет

int Promt(string massage)
{
    System.Console.Write($"{massage} >");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}
int day = Promt("День недели");

if(day>=1 && day<=5)
{
    Console.WriteLine("Будний день");
}
else
{
    if(day>=6 && day<=7)
    {
        Console.WriteLine("Выходной день");
    }
    else
    {
        Console.WriteLine("Такого дня недели не существует");
    }
}