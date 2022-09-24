// Из имеющегося массива строк формирует новый массив
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив задать на старте выполнения алгоритма. 
// Пример [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

string[] array = { "Hello", "23t", "would", "You", "65578G", "work"};
int newArray = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        newArray++;
    }
}

string[] NewArray = new string[newArray];
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        NewArray[count] = array[i];
        count++;
    }
}

for (int i = 0; i < NewArray.Length; i++)
{
    Console.Write(NewArray[i] + " ");
}
