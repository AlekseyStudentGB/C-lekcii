int [] num;
num = new int[3];
num[0] = 6;
num[1] = 3;
num[2] = 2;
int index = 0;
int size = 3;
int max = num[0];

while(index < size) 
{
    if (num[index] > max) 
 {
      max = num[index];
    index = index + 1;
   }
   
    else
   {
     index = index + 1; 
    }   
}


Console.WriteLine(max);

//Console.WriteLine("введите вес первой гири : ");
//string a = Console.RiadLine();
