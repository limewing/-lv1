for (int i = 1; i <= 100; i++)//for문
{
    if (i % 2 == 1)
    {
        Console.WriteLine(i);
    }
}

int j = 1;//while문
while (j <= 100)
{
    if (j % 2 == 1)
        Console.WriteLine(j);
    j++;
}

int k = 0;//do while문
do
{
    if (k % 2 == 1)
        Console.WriteLine(k);
    k++;
} while (k <= 100);
