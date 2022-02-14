//Найти расстояние между точками в пространстве 2D/3D
using static System.Console;
int[] a = { 1, 1 };
int[] b = { 5, 4 };
double road = 0;
road = ((Math.Pow(b[0], 2) - Math.Pow(a[0], 2) + (Math.Pow(b[1], 2) - Math.Pow(a[1], 2))));
road = Math.Sqrt(road);
WriteLine("Расстояние между точками равно = " + road);