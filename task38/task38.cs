// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//              [3 69.4 -22 0.4 78] ->56
Console.WriteLine("размер массива?:");
int a = Convert.ToInt32(Console.ReadLine());
double [] array = new double [a];
void Mass(int a, double[] array)
{
    for (int i=0; i<a; i++)
    {
        Console.WriteLine($"значение {i+1} элемента массива?:");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
}
double Min_max(int a, double[] array)
{
    double min = array[0];
    double max = array[0];
    double n = 0;
    for (int i=0; i<a; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
        if (max < array[i])
        {
            max = array[i];
        }
    }
    n = max - min;
    return (n);
}
Mass(a,array);
Console.WriteLine($"Разность макс. и мин. = {Min_max(a, array)}");