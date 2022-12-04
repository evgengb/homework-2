// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. 
// Не использовать строки

// 456 -> 5
// 782 -> 8
// 918 -> 1

int Promt(string massage)
{
    System.Console.Write($"{massage} >");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int A = Promt("Number");

// int number1 = A/10;
// int number2 = number1%10;

// Console.WriteLine("Two Number" + " " + number2);

if (A>=100 && A<1000)
{
    int rez = A / 10 % 10;
    System.Console.WriteLine($"Two number {rez}");
}
else
{
    System.Console.WriteLine("the number is not three-digit");
}