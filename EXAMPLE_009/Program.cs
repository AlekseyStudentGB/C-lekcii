int Max(int arg1, int arg2, int arg3)
{
int result = arg1;
if (result < arg2) result = arg2;
if (result < arg3) result = arg3;
return result;
}


int a1 = 12;
int b1 = 23;
int c1 = 33;
int a2 = 13;
int b2 = 23;
int c2 = 88;
int a3 = 13;
int b3 = 23;
int c3 = 33;

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));
Console.WriteLine($" Рузультат => {max}");
