void ElementLenght(int m,int n)
{
    if(n<m)return;
    if(n%2<1)
    {
        Console.Write($"{n},");
    }

    ElementLenght(m,n-1);
}
ElementLenght(2,10);