//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Write("Введите число:");
int Value = Convert.ToInt32(Console.ReadLine());
int Length = Value.ToString().Length;
if (Length >= 3) 
{
	while (Value > 999)
	{
		Value = Value / 10;
	}
	int result = Value % 10;
	Console.WriteLine("Третья цифра:" + result);
} else 
{
	Console.WriteLine("Третьей цифры нет");
}

