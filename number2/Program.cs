int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());

double distanse = Math.Sqrt(Math.Pow((x1+x2), 3) + Math.Pow((y1+y2), 3) + Math.Pow((z1+z2), 3));

Console.WriteLine("Расстояние между точками: " + distanse);