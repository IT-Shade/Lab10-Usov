// See https://aka.ms/new-console-template for more information
string[] students = { "Аня", "Ярослав", "Вика"};
int count = 0;

foreach (string student in students)
{
    Console.WriteLine(student);
    count++;
}

Console.WriteLine($"Всего учеников: {count}");

int[] points = { 10, 20, 15};

Console.WriteLine("Итоговый массив");
for (int i = 0; i < points.Length; i++)
{
    points[i] = points[i] + 5;
    Console.WriteLine(points[i]);
}