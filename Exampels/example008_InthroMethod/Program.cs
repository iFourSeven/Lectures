int max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int a1 = 12;
int b1 = 12;
int c1 = 54;
int a2 = 739;
int b2 = 4398;
int c2 = 75;
int a3 = 23;
int b3 = 12;
int c3 = 876564;

int Max1 = max(a1, b1, c1);
int Max2 = max(a2, b2, c2);
int Max3 = max(a3, b3, c3);
int Max = max(Max1, Max2, Max3);
Console.WriteLine(Max);

