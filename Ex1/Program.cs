// Задать массив, заполненный случайными положительными трехзначными числами.
// Написать программу, которая покажет количество четных чисел в массиве.
int[]NewArray(int size, int minVal, int maxVal)
{
    int[] result=new int[size];
    for(int i=0;i<result.Length;i++) 
    {
        result[i]=new Random().Next(minVal,maxVal+1);
    }
    return result;
}
//вызываем метод
int[]array=NewArray(10,100,999);
Console.WriteLine($"Массив: [{String.Join(";",array)}]");

int evenNumbers=0;
int size=array.Length;
for(int i =0;i<size;i++)
{
    if (array[i]%2==0)
    {
        evenNumbers++;
    }
}
Console.WriteLine($"Количество четных чисел в массиве: {evenNumbers}");
