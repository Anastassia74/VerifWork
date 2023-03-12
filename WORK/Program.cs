// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Clear();
System.Console.WriteLine("Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.");
System.Console.WriteLine();
string [] arrayBase;
string [] arrayTemp;
string [] arrayEl3;
string [] arrayTempEl3;
string element;
int count=0;
int countEl3=0;
arrayBase=new string[count];
arrayEl3=new string[countEl3];

System.Console.WriteLine("Введите по очереди элементы массива строк:");

do
{
    element= Console.ReadLine();
    if (element!="")
    {
        count++;
        arrayTemp=new string [count];
        for (int i = 0; i < count-1; i++) arrayTemp[i]=arrayBase[i];
        arrayTemp[count-1]=element;
        arrayBase=arrayTemp;
    }
}
while (element!="");


for (int i = 0; i < arrayBase.Length; i++)
{   if (arrayBase[i].Length<=3)
    {   countEl3++;
        arrayTempEl3=new string [countEl3];
        for (int j = 0; j < countEl3-1; j++) arrayTempEl3[j]=arrayEl3[j];
        arrayTempEl3[countEl3-1]=arrayBase[i];
        arrayEl3=arrayTempEl3;
    }
}

System.Console.Write("Сформированный массив из строк, длина которых меньше либо равна 3 символа:  \n\r[ ");
foreach (var item in arrayEl3) Console.Write($"   '{item}'   ");
Console.Write("]");
