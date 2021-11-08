// Почувствуй себя интерном
//  0. Вывести квадрат числа
//  1. По двум заданным числам проверять является ли первое квадратом второго
//  2. Даны два числа. Показать большее и меньшее число
//  3. По заданному номеру дня недели вывести его название
//  4. Найти максимальное из трех чисел
//  5. Написать программу вычисления значения функции y=f(a)
//  6. Выяснить является ли число чётным
//  7. Показать числа от -N до N
//  8. Показать четные числа от 1 до N
//  9. Показать последнюю цифру трёхзначного числа
// 10. Показать вторую цифру трёхзначного числа
// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
// 12. Удалить вторую цифру трёхзначного числа
// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
// 14. Найти третью цифру числа или сообщить, что её нет

// Почувствуй себя джуном  (у нас зал 3)
// 15. Дано число. Проверить кратно ли оно 7 и 23
// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным 
// 17. По двум заданным числам проверять является ли одно квадратом другого
// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
// 20. Задать номер четверти, показать диапазоны для возможных координат
// 21. Программа проверяет пятизначное число на палиндромом.
// 22. Найти расстояние между точками в пространстве 2D/3D

//  17. По двум заданным числам проверять является ли одно квадратом другого

// int SquareOrNot(int number1, int number2)            // функция для проверки, является ли число 1 квадратом числа 2
// {
//     if (number1 == number2*number2) return 1;        // если является, возвращаем истину
//     else if (number2 == number1*number1) return 2;   // если является, возвращаем истину
//     else return 0;                                   // если не является, возвращаем ложь
// }

// Console.WriteLine("Введите первое число:");            // Выводим на экран приглашение ко вводу
// int number1 = Convert.ToInt32(Console.ReadLine());     // Преобразуем введенное значение в целочисленный тип
// Console.WriteLine("Введите второе число:");
// int number2 = Convert.ToInt32(Console.ReadLine());
// if (SquareOrNot(number1, number2) == 1)             // Вызываем функцию проверки чисел
//     Console.WriteLine($"Число {number1} является квадратом числа {number2}");    // если истина, выводим это сообщение
// if (SquareOrNot(number1, number2) == 2) 
//     Console.WriteLine($"Число {number2} является квадратом числа {number1}"); // если ложь, выводим это сообщение
// if (SquareOrNot(number1, number2) == 0) 
//     Console.WriteLine($"Число {number1} не является квадратом числа {number2} и число {number2} не является квадратом числа {number1}"); // если ложь, выводим это сообщение  


// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y          // x | y | ¬(X ⋁ Y)   | ¬X ⋀ ¬Y
// bool TrueOrFalse(int x, int y)                                      // 0 | 0 | -(0+0) =1  | (1 * 1) =1
// {                                                                   // 0 | 1 | -(0+1) =0  | (1 * 0) =0 
//     bool flagX = (x == 1),                                          // 1 | 0 | -(1+0) =0  | (0 * 1) =0    
//          flagY = (y == 1);                                          // 1 | 1 | -(1+1) =0  | (0 * 0) =0
//     // if (x == 0) flagX = false;           
//     // else flagX = true;                 
                 
//     // if (y == 0) flagY = false;
//     // else flagY = true;
//     bool left =  !(flagX || flagY);       
//     bool right = !(flagX) && !(flagY);      
//     return (left == right);              
// }

// for (int i = 0; i <= 1; i++)
//     for (int j = 0; j <= 1; j++)
//         {
//             if (TrueOrFalse(i, j)) Console.WriteLine($"При х={i} и y={j} выражение ¬(X ⋁ Y) = ¬X ⋀ ¬Y истинно");
//             else Console.WriteLine($"При х={i} и y={j} выражение ¬(X ⋁ Y) = ¬X ⋀ ¬Y ложь");
//         }

// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

// int Quater(int x, int y)                             // функция для проверки, является ли число 1 квадратом числа 2
// {
//     if (number1 == number2*number2) return 1;        // если является, возвращаем истину
//     else if (number2 == number1*number1) return 2;   // если является, возвращаем истину
//     else return 0;                                   // если не является, возвращаем ложь
// }


Console.WriteLine("Введите координаты Х и У, не равные 0:");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
while ( (x == 0) || (y == 0) )
{
    Console.WriteLine("Введенное значение равно 0. Введите координаты Х и У, не равные 0!");
    x = Convert.ToInt32(Console.ReadLine());
    y = Convert.ToInt32(Console.ReadLine());
}

//    Console.WriteLine("Введите координату Х, не равную 0:");            // Выводим на экран приглашение ко вводу
// int number1 = Convert.ToInt32(Console.ReadLine());                  // Преобразуем введенное значение в целочисленный тип
// Console.WriteLine("Введите координату У, не равную 0:");
// int number2 = Convert.ToInt32(Console.ReadLine());

// if (Quater(number1, number2) == 1)             // Вызываем функцию проверки чисел
//     Console.WriteLine($"Число {number1} является квадратом числа {number2}");    // если истина, выводим это сообщение
// if (SquareOrNot(number1, number2) == 2) 
//     Console.WriteLine($"Число {number2} является квадратом числа {number1}"); // если ложь, выводим это сообщение
// if (SquareOrNot(number1, number2) == 0) 
//     Console.WriteLine($"Число {number1} не является квадратом числа {number2} и число {number2} не является квадратом числа {number1}"); // если ложь, выводим это сообщение  












































//  0. Вывести квадрат числа
// Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Квадрат числа {number} равен: {number*number}");

// //  1. По двум заданным числам проверять является ли первое квадратом второго
// Console.WriteLine("Введите первое число:");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int number2 = Convert.ToInt32(Console.ReadLine());
// if (number1 == number2*number2) Console.WriteLine($"Число {number1} является квадратом числа {number2}");
// else Console.WriteLine($"Число {number1} не является квадратом числа {number2}");

//  2. Даны два числа. Показать большее и меньшее число
// Console.WriteLine("Введите первое число:");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int number2 = Convert.ToInt32(Console.ReadLine());
// if (number1 > number2) Console.WriteLine($"Большее число: {number1}, меньшее число: {number2}");
// else Console.WriteLine($"Большее число: {number2}, меньшее число: {number1}");

// //  5. Написать программу вычисления значения функции y=sin^6(a)
// Console.WriteLine("Введите аргумент функции sin^6(a):");
// double a = Convert.ToDouble(Console.ReadLine());
// double res = Math.Sin(a*Math.PI);
// double result = 1;
// for(int index = 0; index < 6; index++)
// {
//     result = result * res;
// }
// Console.WriteLine($"Значение функции sin^6(a) равно: {result}");


//  8. Показать четные числа от 1 до N
// Console.WriteLine("Введите число N:");
// int number = Convert.ToInt32(Console.ReadLine());
// int temp = 1;
// for (int index = 1; index <= number; index++)
// {
//     if (temp % 2 == 0)
//     {
//         Console.Write($"{temp} ");
//     }
//     temp++;
// }

// Console.WriteLine("Введите фамилию сдающего");
// string name = Console.ReadLine();
// int length = name.Length;
// Console.WriteLine($"Длина строки равна {length}");