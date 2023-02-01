void Fillarrray (int[] col)
{
int size = col.Length;
int index = 0;
while (index < size)
{
col[index] = new Random().Next(1, 10);

index ++;
}
}

void Printarray(int[] coll )
{
int count = coll.Length;
int position = 0;
while (position < count)
{
Console.WriteLine($"{position + 1}.  {coll[position]}");
position++;
}
}

int Getposition(int[] col, int find)
{
int sizeGet = col.Length;
int indexGet = 0;
int position = 0;
while (indexGet < sizeGet)
{
if (col[indexGet] == find) position = indexGet;
indexGet ++;
} 

return position;
}






int[] array = new int[10];
Fillarrray(array);
Printarray(array);
Console.WriteLine("______");
int pos = Getposition(array, 4);
Console.WriteLine(pos);