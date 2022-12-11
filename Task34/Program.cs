Console.Write ("Введите количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int [] arr = new int [N];
int count = 0;
for (int i = 0; i < N; i++){
    arr [i] = new Random().Next(100, 1000);
    Console.Write ($" {arr[i]} ");
    if (arr[i] % 2 == 0){
        count++;
    }
}
Console.WriteLine ();
Console.WriteLine ($"Количество чётных чисел в массиве = {count}");