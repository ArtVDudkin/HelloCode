void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
     while (index < length)
     {
         collection[index] = new Random().Next(10, 100);  // рандомные числа от 10 до 99
         index++; 
     }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        if (col[position] != 0)
            Console.Write(col[position] +" ");
        position++;
    }
}

// int IndexOf(int[] collection, int find)
// {
//     int count = collection.Length;
//     int index = 0;
//      int position = -1;
//      while (index < count)
//      {
//          if (collection[index] == find)
//          {
//              position = index;
//              break;
//          }
//          index++;
//      }
//      return position;
// }

// void SelectArray(int[] col)
// {
//     int count = col.Length;
//     int[] selected = new int[count];
//     int index = 0;
//     int average = 0;
//     int sum = 0;
//     while (index < count)
//     {
//         sum = sum + col[index];
//         index++;
//     }
//     average = sum / count;
//     Console.WriteLine($"Среднее равно = {average}");
//     index = 0;
//     while (index < count)
//     {
//         if (col[index] % 2 != 0) 
//         {
//             arrayB[index] = col[index];
//         }   
//         index++;
//     }
//  //   return selected;
// }



int[] arrayA = new int[20];
int[] arrayB = new int[20]; 

int count = arrayA.Length;
int index = 0;
int average = 0;
int sum = 0;
int max = arrayA[0];

FillArray(arrayA);
PrintArray(arrayA);

while (index < count)
{
    sum = sum + arrayA[index];
    index++;
}
average = sum / count;
Console.WriteLine();
Console.WriteLine($"Среднее равно = {average}");
index = 0;
while (index < count)
{
    if ( (arrayA[index] % 2 != 0) && (arrayA[index] > average) && (arrayA[index] > max) ) 
    {
        arrayB[index] = arrayA[index];  
        max = arrayA[index];  
    }
    else 
    {
        arrayB[index] = 0;
    }   

    index++;
}


Console.WriteLine();
//SelectArray(arrayA);
PrintArray(arrayB);
Console.WriteLine();
// Console.WriteLine();
// int pos = IndexOf(array, 4);
// if (pos == -1)
// {
//     Console.WriteLine("Элемент 4 в массиве не найден");
// }
// else
// {
//     Console.WriteLine($"Элемент 4 находится в массиве под индексом {pos}");
// }

