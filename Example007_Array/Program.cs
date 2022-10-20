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
int[] array = new int[10]; //Вводим массив, в котором будет 10 элементов.

FillArray(array); // вызываем метод филлЭррэй
PrintArray(array); // вызываем метод Принт Эррэй