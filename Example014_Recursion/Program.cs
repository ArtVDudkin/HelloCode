// string[,] table = new string[2,5];      // задаем двумерный строковый массив, индекс начинаются от 0
// // table[0,0]  table[0,1]  table[0,2]  table[0,3]  table[0,4]
// // table[1,0]  table[1,1]  table[1,2]  table[1,3]  table[1,4]
// table[1,2] = "word";                    // обращаемся к конкретному элементу в массиве

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }

// void PrintArray(int[,] matr)
// {
//     for (int rows = 0; rows < matr.GetLength(0); rows++)      
//     {   // matrix.GetLength - возвращает количество строк и столбцов массива (0 строки, 1 столбцы)
//         for (int columns = 0; columns < matr.GetLength(1); columns++)
//         {
//             Console.Write($"{matr[rows, columns]} ");
//         }
//     Console.WriteLine();
//     }
// }

// void FillArray(int[,] matr)
// {
//     for (int rows = 0; rows < matr.GetLength(0); rows++)      
//     {   // matrix.GetLength - возвращает количество строк и столбцов массива (0 строки, 1 столбцы)
//         for (int columns = 0; columns < matr.GetLength(1); columns++)
//         {
//             matr[rows, columns] = new Random().Next(1,10);  // [1,9] [1,10)
//         }
//     }
// }

// int[,] matrix = new int[3,4];
// PrintArray(matrix);
// Console.WriteLine();
// FillArray(matrix);
// PrintArray(matrix);

int[,] pic = new int[,]
{
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0},
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0},
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0},
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0},
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0},
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0},
    {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
};

void PrintImage(int[,] image)
{
    for (int row = 0; row < image.GetLength(0); row++)      
    {   
        for (int col = 0; col < image.GetLength(1); col++)
        {
            if (image[row, col] == 0) Console.Write($" ");
            else Console.Write($"+");
        }
    Console.WriteLine();    
    }
}

void FillImage(int row, int col)    // метод для закраски фигуры
{
    if (pic[row, col] == 0)         // если текущий пиксель не закрашен,
    {
        pic[row, col] = 1;          // то закрашиваем его
        FillImage(row -1, col);     // идем закрашивать вверх
        FillImage(row, col -1);     // идем закрашивать влево
        FillImage(row +1, col);     // идем закрашивать вниз
        FillImage(row, col +1);     // идем закрашивать вправо
    }
}

PrintImage(pic);
FillImage(2,12);
PrintImage(pic);

int Factorial (int n)
{                                       // 1! = 1
    if (n == 1) return 1;               // 0! = 1
    else return n* Factorial(n -1);
}

Console.WriteLine(Factorial(5));

// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

// в районе 40х чисел в последовательности Фибоначчи рекурсия начинает подтупливать и жрет ресурсы на вычисления
double Fibonacci(double n)
{
    if ( (n == 1) || (n == 2) ) return 1;
    else return Fibonacci(n -1) + Fibonacci(n -2); 
}
Console.WriteLine(Fibonacci(40));  