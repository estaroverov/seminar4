//Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 
// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да
void PrintIntArr(int [] arr)
{
    foreach(int i in arr)
        Console.Write(i + " ");

    Console.WriteLine();
}
int [] FillArray(int len )
{
    int [] arr = new int[len];
    for(int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(-10,10);
    }
    return arr;
}

int [] ChangeArr(int [] arr)
{
    int len = arr.Length;
    for(int i = 0; i < len; i++)
    {
        arr[i] = -arr[i];
    }
    return arr;
}


int len = 10;
int [] arr = FillArray(len);
PrintIntArr(arr);
arr = ChangeArr(arr);
PrintIntArr(arr);



void CheckVal(int [] arr, int number)
{
    bool isChecked = false;
    foreach(int i in arr)
    {
        if (i == number)
            isChecked = true;
    }
    if(isChecked)
        Console.WriteLine("yes");
    else
        Console.WriteLine("no");
}
CheckVal(arr,10);

int [,] FillArraySpaces(int len_x,int len_y)
{
    int counter = 0;
    string s ;
    string[] subs;
    int lenS ;
    int [,] arr = new int [len_x,len_y];
    Console.Write("Введите массив через пробел:");
    while(counter<len_x)
    {
        s =  Console.ReadLine(); 
        subs = s.Split();
        lenS = subs.Length;
        for(int i = 0; i<lenS;i++)
            arr[counter,i] = int.Parse(subs[i]);
        counter++;
    }
    return arr;
}
void PrintIntArr1(int [,] arr)
{
    foreach(int i in arr)
        Console.Write(i + " ");

    Console.WriteLine();
}
int [,] initKeg = FillArraySpaces(1,2);

int [,] arr1 = FillArraySpaces(initKeg[0,1],2);
PrintIntArr1(initKeg);




