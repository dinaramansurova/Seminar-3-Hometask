// Task 19
//  Хотела решить задачу через массив, но не могу понять, как написать корректный код

Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int [5];
if (array[0] == array[4] && array[1] == array[2])
    Console.WriteLine($"Число {n} полиндром");
else
    Console.WriteLine($"Число {n} не полиндром");