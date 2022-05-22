//double SumAll (double A, double b)
//{
//    double result = Math.Pow(A,b);
//    return result;
//}
//Console.WriteLine (SumAll(5,7));
//Console.WriteLine (SumAll(3,15));
//Console.WriteLine (SumAll(2,7));
int SumAll (int A, int b)
{
    int result =A;
    
    for (int i = 1; i <b;i++)
    {
        
         result *=A;

     
    }
    
  return result;
    
}

Console.Write(SumAll(3,5));