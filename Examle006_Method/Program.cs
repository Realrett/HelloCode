﻿// Поиск индекса числа массива, равного заданному числу
int[] array = {11,27,34,45,35,69,71,88}; //Ввели массив

int n = array.Length; //Ввели переменную равную длине (колву символов) массива

int find = 45; //Ввели число равное которому будем искать

int index = 0; //Ввели индекс числа с которого начнём проверку. В данном случае нулевой индекс, т.е. первое число

while(index < n) //вводим цикл, который будет выполнять действия пока индекс будет меньше эн
{
    if(array[index] == find) //вводим цикл если. если переменная массива под номером индекс совпадает с искомой, то она выводится на консоль. Если нет - то к индексу добавляется 1 (в коде ниже )
    {
        Console.WriteLine(index);
    }
index++; // после каждого цикла к индексу будет добавляться единица
}
