int [] GetArray(int Lenght){

    int[] array = new int[Lenght];

    for (int i = 0; i < Lenght; i++){
    array[i] = new Random().Next(100);
    }
    return array;
}

int GenLenght(){
    Console.WriteLine("Введите длину");
     int lenght = Convert.ToInt32(Console.ReadLine());
    return lenght;
}

int SumNeg(int [] array){
    int sum = 0;
    for(int i = 0; i < array.Length; i++){
        if (i % 2 == 0){
            sum = array[i]+sum;
        }
    }
    return sum;
}

int lenght = GenLenght();
int [] array = GetArray (lenght);
string arr = String.Join(", ", array);
Console.WriteLine(arr);

int SumNegativ = SumNeg(array);
string a = String.Join(", ", SumNeg);
Console.WriteLine(SumNegativ);