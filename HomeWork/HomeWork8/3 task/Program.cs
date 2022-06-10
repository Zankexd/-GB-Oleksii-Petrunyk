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
int[,] a = Masiv(9, 8, 1, 5);
Vyvod(a);
void Smallest(int[,] arr)
{   int CountColumn=0;
    int min = 0;
    
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int Min2= 2147483647;
    for (int i = 0; i < row; i++)
    {  
        min=0;
       
        for (int j = 0; j < column; j++)
        {
            min+=arr[i,j];
            
            // Min2+=arr[i,j+1];
           if(j==column-1 && Min2>min)
           {
           Min2=min;
           CountColumn=i;
           }
           





        }
        
    }
    Console.WriteLine($"Сумма чисел в строке={Min2}");
    Console.WriteLine($"Номер строки={CountColumn+1}");
    
}
Smallest(a);
