Console.Clear();
Console.WriteLine("Введите x: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y: ");
int y = int.Parse(Console.ReadLine());
if (x>0 && y>0)
Console.WriteLine("Плоскость I");
if (x<0 && y>0)
Console.WriteLine("Плоскость II");
if (x<0 && y<0)
Console.WriteLine("Плоскость III");
if (x>0 && y<0)
Console.WriteLine("Плоскость IV");
if (x==0 && y==0)
Console.WriteLine("Плоскость 0");