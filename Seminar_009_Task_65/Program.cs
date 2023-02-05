// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.

Console.Clear();
int num1 = GetNumberFromUser("Введите целое число M: ","Ошибка ввода!");
Console.Clear();
int num2 = GetNumberFromUser("Введите целое число N: ","Ошибка ввода!");
FindSequence(num1, num2);
Console.Write($"M = {num1}, N = {num2} -> ");
if (num1 < num2) Console.WriteLine(FindSequence(num1, num2));
else Console.WriteLine(FindSequence(num2, num1) + " ");

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

string FindSequence(int start, int end)
{
    if (start == end) return end.ToString();
    else return start + " " + FindSequence(start + 1, end);
}
