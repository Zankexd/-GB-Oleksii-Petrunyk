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
int[,] a = Masiv(5, 5, 1, 7);
Vyvod(a);
void Sort (int[,] arr)
{   
    

    for (int i = 0; i < arr.GetLength(0); i++)
    {    
       
        for (int j =0; j < arr.GetLength(1); j++)
        {  
            for(int m=0;m<arr.GetLength(0)-i-1;m++)
            {
                if(arr[j,m]<arr[j,m+1])
                {
                    (arr[j,m],arr[j,m+1])=(arr[j,m+1],arr[j,m]);
                }
            }


        }
    }

}
Sort(a);
Console.WriteLine();
Vyvod(a);
