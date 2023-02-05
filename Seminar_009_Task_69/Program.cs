// Задача 69: Напишите программу, которая на вход принимает два
// числа A и B, и возводит число А в целую степень B с помощью рекурсии.

Console.Clear();
int num1 = GetNumberFromUser("Введите целое число A: ","Ошибка ввода!");
int num2 = GetNumberFromUser("Введите целое число B: ","Ошибка ввода!");
Exponentiation(num1, num2);
Console.WriteLine($"A = {num1}, B = {num2} -> {Exponentiation(num1, num2)}");

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

int Exponentiation(int A, int B)
{
    if (B == 1) return A;
    else
    {
        return A * Exponentiation(A, B - 1);
    }
}
