int[] array = {121, 23, 352, 4, 65, 67, 78, 85};

int n = array.Length;

int find = 65;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}