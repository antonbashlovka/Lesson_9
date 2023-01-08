/*Задача 1: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int InputNumber(string M){
    int i = 0;

    while (int.TryParse(M, out i) == false){
        Console.WriteLine("Ошибка. Вы ввели текст, необходимо число. Попробуйте еще раз");
        M = Console.ReadLine() ?? "неизвестное сообщение"; // проверка на NULL
    }

    return i;
}

void PrintNaturalNums(int N){
    switch (N){
        case > 1 : 
        Console.Write(N + ", "); 
        break;

        case 1 : 
        Console.Write(N); 
        break;

        case 0 :
        return;

        default: return;
    }

    PrintNaturalNums(N-1);
}

Console.WriteLine("введите число");
string userInput = Console.ReadLine()  ?? "неизвестное сообщение";
int N = InputNumber(userInput);

PrintNaturalNums(N);

