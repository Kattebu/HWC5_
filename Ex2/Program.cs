// Задача 36: Задать одномерный массив, заполненный случайными числами.
// Найти сумму элементов, стоящих на нечетных позициях.
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
int[]array=NewArray(10,-100,100);
Console.WriteLine($"Массив: [{String.Join(";",array)}]");

int sumNumNegatPos=0;
int size=array.Length;
for(int i =0;i<size;i++)
{
    if (i%2==1)
    {
        sumNumNegatPos+=array[i];
    }
}
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {sumNumNegatPos}");
