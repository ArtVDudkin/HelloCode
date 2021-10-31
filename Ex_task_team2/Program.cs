﻿// Имеется числовой массив A, заполненный числами из отрезка [minValue; maxValue]. 
// Создать на его основе массив B, отбрасывая те, которые нарушают порядок:
// 1. возрастания
// 2. элементы, больше 8
// 3. знакочередования

void FillArray(int[] collection, int min, int max)           // заполняем массив случайными числами от minValue до maxValue
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        while (collection[index] == 0)                       // до тех пор пока элемент массива равен 0
            collection[index] = new Random().Next(min, max +1);  // генерируем рандомные целые числа от minValue до maxValue, исключая 0
        index++; 
    }
}

void PrintArray(int[] col)             // печатаем массив, заданный в качестве аргумента       
{
    int count = col.Length;
    int index = 0;
    while (index < count)
    {
        if (col[index] != 0) Console.Write(col[index] +" "); // выводим на экран только те элементы массива, которые не маркированы 0 по умолчанию
        index++;
    }
    Console.WriteLine();  // просто разрыв строки для удобства восприятия
}

int minValue = -5;
int maxValue = 10;
int size = maxValue - minValue +1;       // задаем размер массивов А, В1, В2, В3
int[] arrayA = new int[size];            // создаем исходный массив А
int[] arrayB1 = new int[size];           // создаем массив для чисел, отбрасывая те, которые нарушают порядок возрастания
int[] arrayB2 = new int[size];           // создаем массив для чисел, отбрасывая те, которые больше 8
int[] arrayB3 = new int[size];           // создаем массив для чисел, отбрасывая те, которые нарушают порядок знакочередования
                                         // по умолчанию массивы А, В1, В2 и В3 заполнены нулями
int index = 0;
int flag = 0;                            // переменная-индикатор: 0 - значение < 0. 1 - значение > 0

Console.Clear();                         // очистка экрана
Console.WriteLine($"Размер массива А: {size}");
FillArray(arrayA, minValue, maxValue);   // вызываем функцию для заполнения массива А случайными числами от minValue до maxValue
PrintArray(arrayA);                      // выводим массив А на экран для понимания, с чем мы работаем

// решаем первую задачу, отбрасывая числа, которые нарушают порядок возрастания чисел в массиве А
int max = minValue;                     // по умолчанию считаем нулевой элемент максимальным
index = 0;                               // обнуляем переменную index для решения второй задачи
while (index < size)
{
    if (arrayA[index] > max)             // проверяем, если текущий элемент больше предыдущего (не нарушает порядок возрастания)
    {
        arrayB1[index] = arrayA[index];  // то забираем его в массив В1
        max = arrayA[index];             // запоминаем текущий элемент для сравнения со следующим элементом
    }
    else 
    {                                    // если текущий элемент оказался меньше предыдущего (нарушил возрастание), то дальше ничего не делаем
        break;                           // прерываем цикл
    }                                     
    index++;
}
Console.WriteLine("Элементы массива А, которые не нарушают порядок возрастания:");
PrintArray(arrayB1);                     // выводим массив В1 на экран

// решаем вторую задачу, отбрасывая числа, которые больше 8
index = 0;                               // обнуляем переменную index для решения второй задачи
while (index < size)
{
    if (arrayA[index] <= 8) arrayB2[index] = arrayA[index];  // проверяем, если элемент не больше 8, то забираем его в массив В2
    index++;
}
Console.WriteLine();                     // просто разрыв строки для удобства восприятия
Console.WriteLine("Числа, которые не превышают 8 в массиве А:");
PrintArray(arrayB2);                     // выводим массив В2 на экран

// решаем третью задачу, отбрасывая числа, которые нарушают порядок знакочередования

if (arrayA[0] > 0) flag = 1;             // если нулевой элемент массива А > 0, то flag =1  
else flag = 0;                           // иначе flag =0
arrayB3[0] = arrayA[0];                  // нулевой элемент массива А в любом случае попадет в массив В3
index = 1;                               // проверку знакопеременности остальных элементов начинаем с первого элемента массива А
while (index < size)
{
    if ( (arrayA[index] > 0) && (flag == 0) ) // если текущий элемент > 0, a предыдущий был < 0 (flag==0)
    {
        arrayB3[index] = arrayA[index];  // то забираем его в массив В3
        flag = 1;                        // и меняем значение flag =1 (текущее число было положительное)
    }
    else if ( (arrayA[index] > 0) && (flag == 1) ) break;  // иначе если текущее число снова положительное, прерываем цикл
    if ( (arrayA[index] < 0) && (flag == 1) ) // если текущий элемент < 0, a предыдущий был > 0 (flag==1)
    {
        arrayB3[index] = arrayA[index];  // то забираем его в массив В3
        flag = 0;                        // и меняем значение flag =0 (текущее число было отрицательное)
    }
    else if ( (arrayA[index] < 0) && (flag == 0) ) break;  // // иначе если текущее число снова отрицательное, прерываем цикл                                  
    index++;
}
Console.WriteLine();                     // просто разрыв строки для удобства восприятия
Console.WriteLine("Элементы массива А, которые не нарушают порядок знакопеременности:");
PrintArray(arrayB3);                     // выводим массив В3 на экран