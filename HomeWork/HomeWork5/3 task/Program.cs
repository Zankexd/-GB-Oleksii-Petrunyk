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
int[] array =Masiv(6,1,100);
int min=array[0];
int max=0;
for(int i =0; array.Length>i;i++)
{
    if(array[i]>max)
    {
        max = array[i];
    }
    if(array[i]<min)
    {
        min=array[i];
    }

}

Console.WriteLine(min);
Console.WriteLine(max);
Console.WriteLine(max-min);
Vyvod(array);