int[,] Masiv(int line, int strok, int from, int too)
{
    int[,] array = new int[line, strok];

    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < strok; j++)
        {
            array[i, j] = new Random().Next(from, too);

        }

    }
    return array;
}

void Vyvod(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"({array[i, j]}) ");
        }
        Console.WriteLine();
    }
}
int[,] Matr(int[,]arr,int[,]arr2)
{
    int mark=0;
    int Row=arr.GetLength(0);
    int Column=arr.GetLength(1);
    int Row1=arr2.GetLength(0);
    int Column1=arr2.GetLength(1);
    int[,] NewARR=new int[Row,Column1];
    if(Row!=Column1)Console.WriteLine("Произведение данных матриц не возможно");
    for(int i=0;i<Row;i++)
    {  
        for(int j=0;j<Column1;j++)
        {   
            NewARR[i,j]=arr[i,j]*arr2[i,j];
        }
    }
    return NewARR;
    // Здравствуйте у меня возникли трудности я просто в интернете увидел другую формулу по типу
    //arrnew[0,1]= arr[0,1]*arr2[1,0]+arr[0,2]*arr2[2,0]+arr[0,3]*arr2[3,0]
    // так что признаюсь я посмотрелу вас решение только почему то вы их просто перемножаете
    

}
int[,]b=Masiv(3,3,1,5);
Vyvod(b);
Console.WriteLine();
int[,]a=Masiv(3,3,1,5);
Vyvod(a);
Console.WriteLine();
int[,]c=Matr(a,b);
Vyvod(c);

