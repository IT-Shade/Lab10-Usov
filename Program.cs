string subject = "Программирование";

foreach (char letter in subject)
{
    Console.WriteLine(letter);
}

Console.WriteLine($"Общее количество букв: {subject.Length}");

int[] grades = { 4, 5, 3, 5, 4 };
int sum = 0;
int count = 0;

Console.WriteLine($"Сумма всех оценок: {subject.Length}");

Console.WriteLine("Вводите оценки, для завершения введите -1:");
int grade = int.Parse(Console.ReadLine());
while (grade != -1)
{
    Console.WriteLine($"Оценка принята: {grade}");
    sum += grade;
    count++;
    grade = int.Parse(Console.ReadLine());
}
