﻿int max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int[] array = { 12, 23, 34, 46, 523, 61, 75, 18, 39 };

int result = max(
    max (array[0], array[1], array[2]),
    max (array[3], array[4], array[5]),
    max (array[6], array[7], array[8])
);
Console.WriteLine(result);

