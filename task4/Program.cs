int [] GetArray(){

    int[] array = new int[123];

    for (int i = 0; i < array.Length; i++){
    array[i] = new Random().Next(1000);
    }
    return array;
}

int  NewArray(int [] array){
    int count = 0;
    for (int i = 0; i < array.Length; i++){
           if ((array[i] >= 10) & (array[i] <= 99)){
            count++;
           } 
        
    }
    return count;
}


int [] array = GetArray ();
string arr = String.Join(", ", array);
Console.WriteLine(arr);

int  NewArr = NewArray(array);
Console.WriteLine($"Вывод: {NewArr}");

