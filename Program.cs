int[] numbers = { 7, 9, 3, 11, 4};
int sum = 0;

foreach (int number in numbers)
{
    Console.WriteLine(number);
    sum += number;
}

Console.WriteLine($"CУмма чисел: {sum}");

string[] daysWeek = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

foreach (string day in daysWeek)
{
    Console.WriteLine(day + "!");
}