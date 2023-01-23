// Task 21

Console.Clear();
Console.Write("Введите координату точки a X: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату точки a Y: ");
double y = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату точки a Z: ");
double z = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату точки b X1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату точки b Y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату точки b Z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());

double a = x1 - x;
double b = y1 - y;
double c = z1 - z;

double length = Math.Sqrt(a * a + b * b + c * c);
Console.WriteLine($"Длинна отрезка {length}");