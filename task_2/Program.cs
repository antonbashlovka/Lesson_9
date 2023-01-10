/*
Задача 2: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N. 
Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


int InputNumber(string M){
    int i = 0;

    while (int.TryParse(M, out i) == false){
        Console.WriteLine("Ошибка. Вы ввели текст, необходимо число. Попробуйте еще раз");
        M = Console.ReadLine() ?? "неизвестное сообщение"; // проверка на NULL
    }

    return i;
}

void NaturalNumSum(int M, int N, int sum = 0){
    sum = sum + M;
    
    if (M==N) {
        Console.WriteLine(sum);

    }else{
        NaturalNumSum(M+1, N, sum); 
        
    }
    
}

Console.WriteLine("введите начало диапазона суммирования");
string userInput = Console.ReadLine()  ?? "неизвестное сообщение";
int M = InputNumber(userInput);

Console.WriteLine("введите конец диапазона суммирования");
userInput = Console.ReadLine()  ?? "неизвестное сообщение";
int N = InputNumber(userInput);

NaturalNumSum(M, N, 0);



