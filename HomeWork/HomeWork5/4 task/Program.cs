void Vyvod(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ",");
    }
}

int[] Masiv(int Dlina, int min, int max)
{
    int[] array = new int[Dlina];
    for (int i = 0; i < Dlina; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;

}
int[] array = Masiv(5, 1, 5);
int[] array1 = Masiv(6, 1, 5);
int[] Sum(int[] array)
{
    int coco = array.Length - 1;
    //int[] array1 =new int [array.Length];
    int sum = 0;

    if (array.Length % 2 == 0)
    {
        array1 = new int[array.Length/2];
        for (int i = 0; array.Length/2 > i; i++)
        {
           
            int alfa = array[i];
            int beta = array[coco - i];
            sum = alfa * beta;
            Console.Write(sum + ".");
            array1[i]=sum;
            
        }
        
    }
    else
    {
        array1 = new int[array.Length/2+1];
    
        for (int i = 0; array.Length / 2 > i; i++)
        {
            
           int alfa = array[i];
            int beta = array[coco - i];
            sum = alfa * beta;
            Console.Write(sum + ".");
            array1[i]=sum;
            
        }
        Console.Write(array[array.Length / 2]);
        array1[array1.Length-1]=array[array.Length/2];
       
    }

    
    return array1;
}

Vyvod(array);
Console.WriteLine();
int[] a =Sum(array);
Console.WriteLine();
Vyvod(a);


