// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
using static System.Console;
int x = 0;
int y = 0;

if (-x * -y == -(x * y))
{
    WriteLine("Выражение истено x = 0, y = 0");
}
else WriteLine("Выражение не истено x = 0, y = 0");
x = 0;
y = 1;
if (-x * -y == -(x * y))
{
    WriteLine("Выражение истено x = 0, y = 1");
}
else WriteLine("Выражение не истено x = 0, y = 1");
x = 1;
y = 0;
if (-x * -y == -(x * y))
{
    WriteLine("Выражение истено x = 1, y = 0");
}
else WriteLine("Выражение не истено x = 1, y = 0");
x = 1;
y = 1;
if (-x * -y == -(x * y))
{
    WriteLine("Выражение истено x = 1, y = 1");
}
else WriteLine("Выражение не истено  x = 1, y = 1");