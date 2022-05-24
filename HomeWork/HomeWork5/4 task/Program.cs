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
int[]array=Masiv(5,1,5);
int[]array1=Masiv(6,1,5);
void Sum(int[]array)
{
    int sum=0;
    int coco=array.Length-1;
    if(array.Length%2==0)
    {
        for(int i =0;array.Length/2>i;i++)
        {
            int alfa=array[i];
            int beta=array[coco-i];
             sum=alfa*beta;
            Console.Write(sum+".");
            
        }
    }
    else
    {
        for(int i=0;array.Length/2>i;i++)
        {
            int alfa=array[i];
            int beta=array[coco-i];
             sum=alfa*beta;
            Console.Write(sum+".");
        }
        Console.Write(array[array.Length/2]);
    }


}

Vyvod(array);
Console.WriteLine();
Sum(array);