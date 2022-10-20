// Максимальное из 9 чисел
int Max(int arg1, int arg2, int arg3) 
{
int result= arg1;
if(arg2>result) result=arg2;
if(arg3>result) result=arg3;
return result;
}
//             0  1  2  3  4  5  6  7  8
int[] array ={21,29,34,41,56,67,77,88,19}; // Ввели массив чисел
array[0] = 17; // Присвоили нулевому элементу массива значение 12
Console.WriteLine(array[0]); //выводим на консоль нулевой элемент массива