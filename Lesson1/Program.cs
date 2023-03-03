class Program

{
public static void Main(String[] args)

{
   Console.WriteLine("Write x value");
   
  float x = Convert.ToSingle(Console.ReadLine());

int cube =Convert.ToInt32(Math.Pow(x,3));
int square = (int)Math.Pow(x,2);
//Math.Max(x, 3);

float equationResult = -6 * cube + 5 *square - 10 * x + 15;
Console.WriteLine("-6x^3 + 5x^2 - 10x + 15 = " + equationResult);
double sinResult = Math.Abs(x) * Math.Sin(x);
Console.WriteLine("abs(x) * sin(x) = " + sinResult);
double piResult = 2 * Math.PI * x;
Console.WriteLine("2 * PI * x = " + piResult);

Console.WriteLine("enter y value");
float y = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("max value is "+ (Math.Max(x,y)));

}

}