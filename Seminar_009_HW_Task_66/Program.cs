// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N.

Console.Clear();
int num1 = GetNumberFromUser("Введите целое число M: ","Ошибка ввода!");
int num2 = GetNumberFromUser("Введите целое число N: ","Ошибка ввода!");
GetSumNumber(num1, num2);
Console.WriteLine($"M = {num1}, N = {num2} -> {GetSumNumber(num1, num2)}");

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

int GetSumNumber(int M, int N)
{
    if (M == N) return M;
    return (M + GetSumNumber(M + 1, N));
}