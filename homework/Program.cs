//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2
/*
int[]CreateArray(int size)   
{
    
    int[] array=new int[size];
    for(int i = 0; i<array.Length;i++)
        array[i]=new Random().Next(100,1000);
    return array;
}    

void CountEven(int[] array)
{   
    int count=0;
    for(int i = 0; i<array.Length;i++)
        if(array[i]%2==0)
            count++;
    Console.WriteLine("Количество четных " + count);  
}

void ShowArray(int[] array)
{
    for(int i = 0; i<array.Length;i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();

}

Console.WriteLine("Введите количество эл-тов ");
int n=Convert.ToInt32(Console.ReadLine());
int[] t=CreateArray(n);
CountEven(t);
ShowArray(t);
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях. [3, 7, 23, 12] -> 19 [-4, -6, 89, 6] -> 0
/*
int[]CreateArray(int size)   
{
    
    int[] array=new int[size];
    for(int i = 0; i<array.Length;i++)
        array[i]=new Random().Next(1,100);
    return array;
}    

int SumOdd(int[] array)
{   
    int sum=0;
    for(int i = 0; i<array.Length;i++)
        if(i%2==1)
            sum+=array[i];
    return sum;
}
void ShowArray(int[] array)
{
    for(int i = 0; i<array.Length;i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();

}

Console.WriteLine("Введите количество эл-тов ");
int n=Convert.ToInt32(Console.ReadLine());
int[] t=CreateArray(n);
int s=SumOdd(t);
ShowArray(t);
Console.WriteLine(s);
*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.[3 7 22 2 78] -> 76
/*
int[]CreateArray(int size)     
{
    
    int[] array=new int[size];
    for(int i = 0; i<array.Length;i++)
        array[i]=new Random().Next(-1,100);
    return array;
}    
int ResMax(int[] array)
{   
    
    int max=0;
    for(int i = 0; i<array.Length;i++)
    {
        if(array[i]>max)
            max=array[i];
    }    
    return max;
}
int ResMin(int[] array)
{   
    
    int min=100;
    for(int i = 0; i<array.Length;i++)
    {
        if(array[i]<min)
            min=array[i];
    }    
    return min;
}
void ShowArray(int[] array)
{
    for(int i = 0; i<array.Length;i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();

}
Console.WriteLine("Введите количество эл-тов ");
int n=Convert.ToInt32(Console.ReadLine());
int[] t=CreateArray(n);
int s=ResMax(t);
int m=ResMin(t);
ShowArray(t);
Console.WriteLine(s-m);
*/