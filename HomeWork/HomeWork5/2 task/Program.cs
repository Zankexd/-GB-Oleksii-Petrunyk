void Vyvod(int[] array)
{
     
    for (int i = 0;i<array.Length;i++)
    {
        Console.Write(array[i]+",");
    }
}

int[]Masiv (int Dlina,int min, int max)
{
    int[] array=new int [Dlina];
    for(int i =0;i<Dlina;i++)
    {
        array[i]=new Random().Next(min,max);
    }
    return array;
    
}
int[] array=Masiv(6,-50,50);
int sum =0;
for(int i =0;array.Length>i;i++)
{
    if(i%2==1)
    {
        sum+=array[i];
    }
}
Console.WriteLine(sum);
Vyvod(array);
// Я не знаю нужно ли учитывать 0 по скольку это и нечётное и не чётное по этому я эго не учитывал но если нужно просто укажу в 
//int sum=array[0] 