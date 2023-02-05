// Задача 64: Задайте значение N. Напишите программу, которая
// выведет все натуральные числа в промежутке от N до 1.

Console.Clear();
int num = GetNumberFromUser("Введите целое число: ","Ошибка ввода!");
FindSequence(num);
Console.WriteLine($"N = {num} -> {FindSequence(num)}");

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

string FindSequence(int N)
{
    if (N == 1) return "1";
    else return (N + " " + FindSequence(N - 1));
}