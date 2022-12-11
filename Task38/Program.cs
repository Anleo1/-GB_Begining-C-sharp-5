Console.Write ("Введите количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());
double [] arr = new double [N];
double max = 0;
double min = 1000000000.0;
Console.WriteLine ("Введите массив: ");
for (int i = 0; i < N; i++){
    arr [i] = Convert.ToDouble(Console.ReadLine());
    if (arr[i] > max){ 
        max = arr[i];
    }
    if (arr [i] < min){
        min = arr[i];
    }
}
Console.WriteLine ($"Разница между максимальным и минимальным элементами массива = {max - min}");