void FillArray(int[] collection) // void - метод, который не использует возвращение. при этом методе не используется команда return. Данная конструкция заполняет массив разными числами
{
    int length = collection.Length; //Вводим переменную равную длине массива collection
    int index = 0; //Вводим номер первого элемента массива
    while(index < length)
    {
        collection[index] = new Random().Next(1,10); //индексу массива Collection присваиваются случайные значения от 1 до 10
        index++;
    }
}
void PrintArray(int[] col) // выводит массив на печать (на экран)
{
    int count = col.Length; // вводим каунт равную длине массива
    int position =0;
    while(position < count)
    {
    Console.WriteLine(col[position]);
    position++;
    }
}

int IndexOf(int[] collection, int find) //Это какой-то третий ебанутый метод с возвращением. Что такое возвращение - в душе не ебу.
{
    int count = collection.Length; // вводим интежированные переменные
    int index = 0;
    int position =-1; //-1 делается для того, чтоб если элемента нет в списке - выводилось значение -1.
    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break; // Останавливаем работу цикла в случае первого совпадения
        }
        index++;
    }
    return position; // возврращаем (щито???) позицию
}
int[] array = new int[10]; //Вводим массив, в котором будет 10 элементов.

FillArray(array); // вызываем метод филлЭррэй
PrintArray(array); // вызываем метод Принт Эррэй
Console.WriteLine();

int pos = IndexOf(array, 8); // вводим переменную пос, которая будет равна номеру цифры 8 в массиве обработанном методом Индекс оф
Console.WriteLine(pos); // Выводим пос на экран (Ебанутый метод ей Богу)