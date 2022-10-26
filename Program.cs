
//Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры. 
//При решении не рекомендуется пользоваться коллекциями. 

string[] array1 = new string[4] {"2345", "Рано", "1Ж", "Оптимизм"};
string[] array2 = new string[array1.Length];
void SecondCheckArray(string[] array1, string[] array2)
{
    
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondCheckArray(array1, array2);
PrintArray(array2);
 



