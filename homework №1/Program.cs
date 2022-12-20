Console.Clear();

Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 1000 && num > 99)
{
    int num_2 = ((num % 100) / 10);
    Console.WriteLine($"второе число из трехзначного = {num_2}");
}
else
{
    Console.WriteLine("Вы ввеели не трехзначное значное как так? вам же сказано трехзначное");
}