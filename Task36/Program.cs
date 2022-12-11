Console.Write ("Введите количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int [] arr = new int [N];
int sum = 0;
for (int i = 0; i < N; i++){
    arr [i] = new Random().Next(-99, 100);
    Console.Write ($" {arr[i]} ");
    if (i % 2 != 0){ //Если счёт начинается с нуля 
        sum += arr[i];
    }
}
Console.WriteLine ();
Console.WriteLine ($"Сумма элементов стоящих на нечётных позициях (отсчёт позиций начинается с нуля) = {sum}");