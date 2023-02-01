//             0  1  2  3  4  5  6  7  8  9
int[] array = {1, 2, 5, 4, 5, 6, 7, 8, 4, 10};
int size = array.Length;
int find = 5;
int index = 0;

while (index < size)
{
if (array[index] == find) 
{
    Console.WriteLine($"Первое {index}");
    break;
}
index ++;
}
index ++;
while (index < size)
{
if (array[index] == find) 
{
    Console.WriteLine($"Второе {index}");
    break;
}
index ++;
}

