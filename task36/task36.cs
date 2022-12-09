// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
//    [3, 7, 23, 12] -> 19       [-4, -6, 89, 6] -> 0
Console.WriteLine("чего ждем? сколько?");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
Random random = new Random();
Console.WriteLine("на массив, держи: ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(-99, 100);
}

int FindElement(int[] array)
{
    int sum =0;
    for (int i = 0; i < array.Length;i++)
    {
        if (i % 2 ==1)
        {
            sum = sum + array[i];
            Console.WriteLine(array[i]);
        }
    
    }
    return sum;    
}
Console.WriteLine(string.Join(",",array));
Console.WriteLine(FindElement(array));