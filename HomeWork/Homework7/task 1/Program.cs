double[,]Masiv(int line,int strok,int from , int too)
{
    double[,] array= new double[line,strok];

    for(int i=0;i<line;i++)
    {
        for(int j=0;j<strok;j++)
        {
            int a = new Random().Next(from,too);
        double K= a/10.0;
        array[i,j]= K;
     
        }

    }
    return array;
}

void Vyvod(double[,]array)
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
Vyvod(Masiv(3,5,-100,100));
