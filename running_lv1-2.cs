int[] numbers = { 28, 29, 30, 31, 32 };
int sum = 0;

//sum
for (int i = 0; i < 5; i++)
    sum += numbers[i];

//average
float average = sum / 5;

Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Average: {average}");