void Sumar(double k1,double k2 , double b1 ,double b2)
{
  double x =(k1-k2)/(b1-b2);
  double y = k1*x+b1;
  Console.Write($"решение=({x}:{y})");
}
Sumar(2,5,4,9);