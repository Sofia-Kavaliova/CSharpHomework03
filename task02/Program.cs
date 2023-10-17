// Task 2

int[] pointA = new int[3];
Console.WriteLine("Vvedite koordinatu X tochki pointA: ");
pointA[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvedite koordinatu Y tochki pointA: ");
pointA[1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvedite koordinatu Z tochki pointA: ");
pointA[2] = Convert.ToInt32(Console.ReadLine());

int[] pointB = new int[3];
Console.WriteLine("Vvedite koordinatu X tochki pointB: ");
pointB[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvedite koordinatu Y tochki pointB: ");
pointB[1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvedite koordinatu Z tochki pointB: ");
pointB[2] = Convert.ToInt32(Console.ReadLine());

int resX = (int) Math.Pow(pointA[0] - pointB[0], 2);
int resY = (int) Math.Pow(pointA[1] - pointB[1], 2);
int resZ = (int) Math.Pow(pointA[2] - pointB[2], 2);

double distance = Math.Sqrt(resX+resY+resZ);
Console.WriteLine(distance);
