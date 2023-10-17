// Task 3

Console.Write("Vvedite chislo: ");
int N = Math.Abs(Convert.ToInt32(Console.ReadLine()));

for (int i = 1; i <=N; i++)
{
    Console.WriteLine(Math.Pow(i,3) + " ");
}