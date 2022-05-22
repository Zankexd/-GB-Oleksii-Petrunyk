int Summ (int A)
{
    
    int result=0;
    
   while (A>0)
    {
        result+=A%10;
        A/=10;

        
        
    }
  
  return result;
}

Console.Write(Summ(12336));