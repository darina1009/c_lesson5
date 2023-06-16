double [] GetArray(int Lenght){

    double[] array = new double[Lenght];

    for (int i = 0; i < Lenght; i++){
   array[i] = new Random().NextDouble();
    }
    return array;
}

int GenLenght(){
    Console.WriteLine("Введите длину");
     int lenght = Convert.ToInt32(Console.ReadLine());
    return lenght;
}

double arrMax(double [] array ){
double max = array.Max();

return max;
}

double arrMin(double [] array ){
double min = array.Min();
return min;
}

double Calculations(double max, double min){
    double calc = max - min;
    return calc;
}

int lenght = GenLenght();
double [] array = GetArray (lenght);
string arr = String.Join(", ", array);
Console.WriteLine(arr);
double max = arrMax( array);
Console.WriteLine($"максимальное: {max}");
double min = arrMin( array);
Console.WriteLine($"Минимальное:{min}");
double calc = Calculations(max,min);
Console.WriteLine($"Результат:{calc}");


