int [,]Masiv(int line,int strok,int from , int too)
{
    int[,] array= new int[line,strok];

    for(int i=0;i<line;i++)
    {
        for(int j=0;j<strok;j++)
        {
           array[i,j]=new Random().Next(from,too);
     
        }

    }
    return array;
}

void Vyvod(int[,]array)
{
    for(int i=0;i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
        {
            Console.Write($"({array[i,j]}) ");
        }
        Console.WriteLine();
    }
}
void Aref(int[,]arr)
{     
    int line = arr.GetLength(0);
    int strok = arr.GetLength(1);
    double sum;
    for(int i=0;i<strok;i++)
    {
        sum=0;
        for(int j=0;j<line;j++)sum+=arr[j,i];
        Console.Write($"{Math.Round(sum/line,2)};");
    }
}
int[,]Maska=Masiv(3,5,1,10);
Vyvod(Maska);
Aref(Maska);