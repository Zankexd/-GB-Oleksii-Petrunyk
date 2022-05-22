void RanndomMasiv()
{
    int[]array = new int [8];
    for (int i = 0;i<array.Length;i++)
    {
         array[i]=new Random().Next(1,10);
        Console.Write( "."+array[i]);
    }   
}
RanndomMasiv();


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

Vyvod(Masiv(8,1,10));