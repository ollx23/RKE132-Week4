﻿


int sum = 0;


for(int i = 0; i < 11; i++)
{
    Console.WriteLine($"i = {i}");
    Console.WriteLine($"Current total: {sum}");
    sum = sum + i;
}

Console.WriteLine($"Fianl total {sum}");