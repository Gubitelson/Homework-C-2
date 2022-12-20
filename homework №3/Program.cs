Console.Clear();

string[] week = { "понеельник", "вторник", "среда", "четверг", "пятница", "суббота", "восресение" };

Console.WriteLine("Введите номер дня недели");
int num = int.Parse(Console.ReadLine());

if (num > 7)
{
    Console.WriteLine("Сколько по твоему дней в неделе?");
}
else if (num > 5)
{
    Console.WriteLine($"Ура, сегодня {week[num - 1]}, выходной!");
}
else
{
    Console.WriteLine($"Сегодня {week[num - 1]}, работа и счастье для тебя так как ты не отдохнул на выходных");
}