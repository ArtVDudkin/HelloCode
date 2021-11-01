﻿// Найти самый большой простой множитель для числа 600851475143

int GenNextSimple(int currentSimple)     // Функция для нахождения нового простого числа, следующего за текущим простым числом
{
    int index = 2;                       // 2 - это самое первое простое число
    int deviders = 0;                    // количество чисел, на которое текущее число делится без остатка
    int flag = 0;                        // флаг найдено ли новое простое число (1 найдено, 0 не найдено)
    if (currentSimple == 2) currentSimple += 1;  // частный случай для получения следующего простого числа 3
    else currentSimple += 2;             // предполагаемое новое простое число находим по схеме р + 2 (https://oeis.org/A109611)
    while (flag != 1)
    {
        deviders = 0;                    // обнуляем количество найденных чисел, на которое исходное число делится без остатка
        index = 2;                       // задаем начальное значение числа, на которое будем делить предполагаемое простое число 
        while (index <= currentSimple)   // ищем, сколько предполагаемое новое простое число имеет делителей
        {
            if (currentSimple % index == 0) deviders++;  // если найден новый делитель, то увеличиваем их количество на 1
            index++;                     // иначе делим предполагаемое простое число на следующее по порядку число
        }
        if (deviders == 1)               // если найден всего 1 делитель (число делится без остатка только само на себя)
        {
            flag = 1;                    // то прерываем дальнейший поиск, новое простое число найдено (флаг =1)
        }
        else if (deviders > 1)           // если делителей найдено больше одного, значит это число не является простым
        {
            flag = 0;                    // ищем следущее предполагаемое простое число
            currentSimple += 2;          // по схеме р + 2
        }
    }
    return currentSimple;                // возвращаем найденное новое простое число

}

double number = 600851475143;                        // вводим исходное число
int firstSimple = 2;                                 // 2 самое первое простое число
int max = firstSimple;                               // по умолчанию принимаем, что самый большой простой множитель равен 2
int nextSimple = firstSimple;                        // для нахождения 

Console.Clear();                                     // очистка экрана
Console.WriteLine($"Для числа {number} простыми множителями являются:");
while (number > 1)
{
    if (number % nextSimple == 0)                   // если наше число делится на текущий простой множитель ли без остатка 
    {
        number = number / nextSimple;               // то делим наше число на этот простой множитель
        Console.Write(nextSimple + " ");            // выводим текущий простой множитель на экран
    }
    else nextSimple = GenNextSimple(nextSimple);    // если число не делится без остатка на текущее простое число, то генерируем следующее по порядку простое число
    if (nextSimple > max) max = nextSimple;         // запоминаем новое значение самого большого простого множителя для нашего числа
}
Console.WriteLine();
Console.WriteLine($"Самый большой простой множитель для этого числа равен: {max}");