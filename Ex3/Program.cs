// Задача 38: Задать массив вещественных чисел.
// Найти разницу между максимальным и минимальным элементами массива.
double[]NewArray(int size)
{
    double[] result=new double[size];
    for(int i=0;i<result.Length;i++) 
    {
        result[i]=new Random().NextDouble();
    }
    return result;
}
//вызываем метод
double[]array=NewArray(5);
Console.WriteLine($"Массив: [{String.Join(";",array)}]");
double minNumber=1;
double maxNumber=0;
int size=array.Length;
for(int i =0;i<size;i++)
{
    if (array[i]<minNumber)
    {
        minNumber=array[i];
    }
}
for(int i =0;i<size;i++)
{
    if (array[i]>maxNumber)
    {
        maxNumber=array[i];
    } 
}
//Console.WriteLine(minNumber);
//Console.WriteLine(maxNumber);
double difference = maxNumber - minNumber;
Console.WriteLine($"Разница между максимальным и минимальным элементами: {difference}");
