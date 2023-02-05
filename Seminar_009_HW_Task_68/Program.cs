// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

Console.Clear();
int num1 = GetNumberFromUser("Введите целое положительное число M: ","Ошибка ввода!");
int num2 = GetNumberFromUser("Введите целое положительное число N: ","Ошибка ввода!");
FunctionAkkerman(num1, num2);
Console.WriteLine($"M = {num1}, N = {num2} -> A(M, N) = {FunctionAkkerman(num1, num2)}");

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
int FunctionAkkerman(int M, int N)
{
    if (M == 0) return N + 1;
    else if (N == 0) return FunctionAkkerman(M - 1, 1);
    else return FunctionAkkerman(M - 1, FunctionAkkerman(M, N - 1));
}