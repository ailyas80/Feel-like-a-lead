﻿// Написать программу преобразования десятичного числа в двоичное

int GetNumber()
{
    Console.WriteLine("Введите число :");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int number = GetNumber();
int Pow = 0;
int i = 0;
while(Math.Pow(2,i)<=number)
{
    Pow = i;
    i++;
}
Pow++;
Console.WriteLine($"степень равна {Pow-1}");
int[] Array = new int[Pow];
int result = 0;
for(int j = Pow-1; j>=0;j--)
{
    result=number%2;
    Array[j]=result;
    number=number/2;
}
for(int k=0; k<Pow;k++)
{
    Console.Write(Array[k]);
}
