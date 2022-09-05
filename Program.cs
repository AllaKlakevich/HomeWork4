// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// void Step(int a, int b){
//     if(b > 0){
//     int result = 1;
//     for (int curr = 1; curr < b+1; curr++){
//         result = result*a;
//     }
//     Console.WriteLine("Заданное число в заданной степени равно " + result);
//     }
//     else if(b < 0){
//     double result = 1;
//     for (int curr = 1; curr < 1-b; curr++){
//          result = result*a;
//     }
//     double resultat = 1 / result;
//     Console.WriteLine("Заданное число в заданной степени равно " + resultat);
//     }  
//     else Console.WriteLine("Заданное число в заданной степени равно 1"); 

// }

// Console.WriteLine("Введите два числа: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// Step(a, b);


// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// void Sum(int num){
//     int result = 0;
//     while(num > 0){
//         result = result + num%10;
//         num/=10;
//     }
//     Console.WriteLine("Сумма цифр в числе равна " + result);
// } 

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Sum(num);


// Напишите программу, которая задаёт массив из произвольных элементов и выводит их на экран.

int[] CreateRandomArray(int size, int min, int max){
    int[] array = new int[size];     
    for (int i = 0; i < size; i++)
    {         
        array[i] = new Random().Next(min, max+1);
    }     
return array; 
}

void ShowArray(int[] array){
    Console.Write($"[ ");
    for (int i = 0; i < array.Length; i++)
    { 
        Console.Write(array[i]+" ");
    }     
    Console.Write($"]"); 
} 

Console.WriteLine("Введите размер массива: "); 
int size = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Минимальное число: "); 
int min = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Максимальное число: "); 
int max = Convert.ToInt32(Console.ReadLine()); 
int[] array = CreateRandomArray(size, min, max); 

ShowArray(array);
