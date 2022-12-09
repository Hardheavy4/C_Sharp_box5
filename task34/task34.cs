//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.    [345, 897, 568, 234] -> 2
//Диапазон трехзначных чисел, ввод случайный.
Console.WriteLine("число чисел в массиве из чисел надо ввести прямо сюда");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
Random random = new Random();
Console.WriteLine("Итаки вот он, наш массив: ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(100, 1000);//Заполняем одну ячейку array случайным числом от -9 до 9. 
}

int FindElement(int[] array)
{
    int count=0;
    for (int i = 0; i < array.Length;i++)
    {
        if (array[i] % 2 ==0)
        {
            count++;
            Console.WriteLine(array[i]);
        }
    
    }
    return count;    
}
Console.WriteLine(string.Join(",",array));
Console.WriteLine(FindElement(array));