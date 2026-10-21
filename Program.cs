string word = "Строка";

for (int i = word.Length - 1; i >= 0; i--)
{
    Console.WriteLine(word[i]);
}

int[] numbers = { 7, 3, 0, 9, 2 };

        
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = numbers[i] + 1; 
}

Console.WriteLine("Итоговый массив:");
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
}