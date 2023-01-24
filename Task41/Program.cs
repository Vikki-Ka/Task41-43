/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

int GetUserData(string massage)
{
    Console.ForegroundColor=ConsoleColor.DarkBlue;
    Console.WriteLine(massage);
    int UserData = int.Parse(Console.ReadLine()!);
    Console.ResetColor();
    return UserData;
}
void CountPositiveNumber (int length)
{
    int [] array = new int[length];
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        array[i] = GetUserData("Ввидите число массива");
        if (array[i] > 0 ) count++;
    }
    PrintArray(array);
    Console.WriteLine($" -> Положительных чисел {count}");
}
void PrintArray(int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length -1)
        {
            Console.Write(arr[i] + "");
        }
        else Console.Write(arr[i] + ", ");
    }
 
}

int lengthArray = GetUserData("Ввидите длину массива: ");
CountPositiveNumber(lengthArray);