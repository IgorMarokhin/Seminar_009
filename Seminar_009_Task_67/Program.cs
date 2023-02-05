// Задача 67: Напишите программу, которая будет принимать
// на вход число и возвращать сумму его цифр.

Console.Clear();
int num = GetNumberFromUser("Введите целое число: ","Ошибка ввода!");
SumCountInNumber(num);
Console.WriteLine($"{num} -> {SumCountInNumber(num)}");

//////////////////////////////////

int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect)
            return userNumber;
    Console.WriteLine(errorMessage);
    }
}

int SumCountInNumber(int num)
{
    if (num == 0) return 0;
    else
    {
        return num % 10 + SumCountInNumber(num / 10);
    }
}