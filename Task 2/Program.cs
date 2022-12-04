// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет. 

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


int Promt(string massage)
{
    System.Console.Write($"{massage} >");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int A = Promt("Ваше число");

while (A>=1000)
{
    A=A/10;
}
if (A>=100 && A<1000)
{
    int rez = A%10;
    System.Console.WriteLine($"Третья цифра числа {rez}");
}
else
{
    System.Console.WriteLine("Третьей цифры нет");
}


// int Promt(string massage)
// {
//     System.Console.Write($"{massage} >");
//     int answer = Convert.ToInt32(Console.ReadLine());
//     return answer;
// }
// int A = Promt("Ваше число =>" + " ");

// int number = A % 10;
// int number1 = A / 100;

// if(number1 == 0)
// {
//     Console.WriteLine("Третьей цифры в вашем числе нет");
// }
// else
// {
//     if(number >= 0)
//     Console.WriteLine($"Третья цифра вашего числа {number}");
// }
    
