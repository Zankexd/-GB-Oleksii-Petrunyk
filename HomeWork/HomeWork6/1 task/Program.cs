int Lum ()
{
    string slovo;
    int count=0;
    while(true)
    {
        Console.WriteLine("Введите целое число =");
        slovo=Console.ReadLine();
        if(slovo=="")return count;

        else if (int.Parse(slovo)>0)count++;

    }
}
Console.WriteLine(Lum());