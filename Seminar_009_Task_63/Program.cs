// Задача 63: Задайте значение N. Напишите программу, которая
// выведет все натуральные числа в промежутке от 1 до N.

Console.Clear();
int num = GetNumberFromUser("Введите целое число N: ","Ошибка ввода!");
FindSequence(1, num);
Console.WriteLine(FindSequence(1, num));

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