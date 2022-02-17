// Задача 28: Подсчитайте сумму цифр в числе.
using static System.Console;
string number = (ReadLine());
int[] array = number.ToString().Select(c=>(int)char.GetNumericValue(c)).ToArray();
int result = array.Sum();
WriteLine(result);