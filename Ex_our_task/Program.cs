void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
     while (index < length)
     {
         collection[index] = new Random().Next(10, 99);
         index++; 
     }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
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

int[] arrayA = new int[20];
int[] arrayB = new int[20]; 
FillArray(arrayA);
PrintArray(arrayA);
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

