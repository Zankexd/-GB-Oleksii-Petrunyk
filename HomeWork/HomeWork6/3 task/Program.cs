int[,] Matr(int strok,int stolb)
{
 int[,]matrix= new int [strok,stolb];
 for(int i=0;i<strok;i++)
 {
   for(int j=0; j<stolb;j++)
   {
       matrix[i,j]=new Random().Next(1,10);
   }
 }
 for(int i=0;i<strok;i++)
{
    for (int j=0;j<stolb;j++)
    {
        Console.Write($"{matrix[i,j]}");
    }
    Console.WriteLine();
}
 Console.WriteLine();
 Console.WriteLine();
 
 int[,] matrix2=new int[strok,stolb];
   
   for(int i=0;i<strok;i++)
   {
       for(int j=0;j<stolb;j++)
       {
           matrix2[i,j]=matrix[i,j];

       }
   }
    for(int i=0;i<strok;i++)
{
    for (int j=0;j<stolb;j++)
    {
        Console.Write($"{matrix2[i,j]}");
    
    }
    Console.WriteLine();

}
return matrix2;
  
}


int[,]a=Matr(3,6);