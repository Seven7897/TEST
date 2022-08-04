System.Console.WriteLine("Введите количество элементов в массиве");
int number = Convert.ToInt32(Console.ReadLine());
string[] array = new string [number];
int count = 0; 
for (int i = 0; i < array.Length; i++)
{
    System.Console.WriteLine($"Введите элемент массива {i}");
    array[i] = Console.ReadLine();
    if (array[i].Length <= 3) count +=1;
}
System.Console.WriteLine($" [ {string.Join(", ", array)} ]");
string[] sorting = new string[count];
int index = 0;
for (int i = 0; i < array.Length; i++)
{
    if  (array[i].Length <= 3) 
    {
        sorting[index] = array[i];
        index += 1;
    }
}
System.Console.WriteLine( "[ " + string.Join(" ," , sorting) + " ]");