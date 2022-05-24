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
int[]array=Masiv(5,100,1000);
int count =0;
for(int i = 0;array.Length>i;i++)
{
    if (array[i]%2==0)
    {
        count++;
    }
    
}  
Console.WriteLine(count);

Vyvod(array);