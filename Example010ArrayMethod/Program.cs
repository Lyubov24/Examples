﻿     //Имеется одномерный массив array из n элементов, требуется найти элемент массива равный find.
     // 1. Установить счетчик index впозицию 0
     // 2.  Если array[index] = find, алгоритм завершил работу успешно.
     // 3. Увеличить index на 1
     // 4. Усли index < n, то перейти к шагу 2. В противном случае алгоритм завершил работу безуспешно.

int[] array = { 1, 12, 31, 4, 31, 16, 18, 17, 18 };

int n = array.Length;
int find = 31;

int index = 0;

while (index < n)
{
    if (array[index] == find)

    {
       Console.WriteLine(index);
       break;
    }
    //index = index + 1;
    index++;
}