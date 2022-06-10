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
void check(int[,] arr)

{
    int sum = 0;
    for (int m = 0; m < 10; m++)
    {
         sum=0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] == m)sum++;
                
            } 

        }
        if(sum>0){
        Console.WriteLine($"{m}встречаеться{sum}раз");
        }
        
     
    }




}
int[,] a = Masiv(3, 3, 1, 10);
Vyvod(a);
check(a);
