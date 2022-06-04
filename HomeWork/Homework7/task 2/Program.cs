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
void Check(int[,]arr,int First,int Second)
{
    if(First<arr.GetLength(0)+1&&Second < arr.GetLength(1)+1)
    {    
        Console.WriteLine("Под данным номером находиться число=");
        Console.Write(arr[First-1,Second-1]);
    }
    else Console.Write("Числа по данным кординатах нету");
}
int[,]busket=Masiv(3,5,1,100);
Vyvod(busket);
Check(busket,2,7);

