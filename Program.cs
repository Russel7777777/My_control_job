/*
Задача:
Написать программу, которая из имеющегося массива строк формирует массив из строк,
длинна которых меньше либо равна трём. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами!
*/

string[] array = { "777", "888", "555", "Mecami", "Kazan", "Auto", "Audi", "Second" };
int lenNewArray = 0;

// Длинна нового массива
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        lenNewArray++;
    }
}

// Добавление значений <= 3 из данного массива в новый массив 

string[] newArray = new string[lenNewArray];
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        newArray[count] = array[i];
        count++;
    }
}

// Вывести значения массива в терминал
for (int i = 0; i < newArray.Length; i++)
{
    Console.Write(newArray[i] + " ");
}