int [] GetArray(int Lenght){

    int[] array = new int[Lenght];

    for (int i = 0; i < Lenght; i++){
    array[i] = new Random().Next(100, 1000);
    }
    return array;
}

int GenLenght(){
    Console.WriteLine("Введите длину");
     int lenght = Convert.ToInt32(Console.ReadLine());
    return lenght;
}

int new_arr(int [] array){
   int count = 0;
    foreach(int num in array){
      if (num % 2 == 0 ){
            count++;
        }
    }
    return count;
}

int lenght = GenLenght();
int [] array = GetArray (lenght);
string arr = String.Join(", ", array);
Console.WriteLine(arr);
int ArrayPozitiv = new_arr(array);
string a = String.Join(", ", new_arr);
Console.WriteLine(ArrayPozitiv);