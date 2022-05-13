using System.Linq;


int[] arr = new int[10]; //створюємо масив на 10 елементів
Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(-10, 10);//заповнення масиву випадковими числами

}

Console.Write("Range is : ");

foreach (int i in arr)
{
    Console.Write(i + " ");//виведення масиву
}

Console.WriteLine();
Console.WriteLine();

var result =               //створення змінної result
    from n in arr          //вибір від'ємних чисел
    where n < 0            //
    select n;              //

Console.Write("Negative numbers : ");

foreach (int i in result)
{
    Console.Write(i + " ");//виведення від'ємних чисел
}

Console.WriteLine();
Console.WriteLine();
Console.Write("Amount of these numbers : ");

int count = result.Count();//створення змінної count, у яку присвоюємо кількість від'ємних чисел
Console.WriteLine(count);//виводимо цю кількість
Console.WriteLine();


Console.Write("Sum of these numbers : ");

int sum = result.Sum();//створення змінної sum, у яку присвоюємо суму від'ємних чисел
Console.Write(sum);//виводимо цю суму
Console.WriteLine();
