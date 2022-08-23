// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// Расстояние = sqrt {(x2-x1) ^{2} + (y2-y1) ^{2} + (z2-z1) ^{2}}

Console.WriteLine("Введите координату аx: ");
double ax = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату аy: ");
double ay = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату аz: ");
double az = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату bx: ");
double bx = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату by: ");
double by = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату bz: ");
double bz = Convert.ToDouble(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2) + Math.Pow((bz - az), 2));

Console.WriteLine($"Расстояние между точками: {distance}");