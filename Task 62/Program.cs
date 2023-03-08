
int [,] arrey(int m,int n) {                                        //Создание массива случайных чисел
    int [,] mass = new int [m,n];
    int namber=9;
    int i =0;
    int j =0;
    for ( ; j<mass.GetLength(1); j++){                              //Заполнение верхней строки
            namber++;
            mass[i,j]=namber;
        }
    j=j-1;
    for ( i=1; i<mass.GetLength(0); i++){                           //Заполнение правого столбца
            namber++; 
            mass[i,j]=namber;
        }
    i=i-1;
    if (mass.GetLength(1)>1){                                       //Заполнение нижней строки
        for (j =j-1; j>=0; j--){
            namber++;
            mass[i,j]=namber;
        }
    }
    else return mass;
    j=j+1;
    if (mass.GetLength(0)>1){                                       //Заполнение левого столбца
        for (i =i-1; i>=1; i--){
            namber++; 
            mass[i,j]=namber;
        }
    }
    else return mass;                                               //Заполнение второй строки
    i=i+1;
    if (mass.GetLength(1)>2){
        for ( j=j+1; j<mass.GetLength(1)-1; j++){
            namber++;
            mass[i,j]=namber;
        }
    }
    else return mass;
    j=j-1;
    if (mass.GetLength(0)>2){                                       //Заполнение предпоследнего столбца
        for ( i=i+1; i<mass.GetLength(0)-1; i++){
            namber++; 
            mass[i,j]=namber;
        }
    }
    else return mass;
    i=i-1;
    if (mass.GetLength(1)>2){                                       //Заполнение второй строки с низу
        for (j =j-1; j>=1; j--){
            namber++;
            mass[i,j]=namber;
        }
    }
    else return mass;
    j=j+1;
    if (mass.GetLength(0)>2){                                       //Заполнение второго столбца
        for (i =i-1; i>=2; i--){
            namber++; 
            mass[i,j]=namber;
        }
    }
    i=i+1;
    if (mass.GetLength(1)>3){                                       //Заполнение третьей строки
        for ( j=j+1; j<mass.GetLength(1)-2; j++){
            namber++;
            mass[i,j]=namber;
        }
    }
    else return mass;
return mass;
}


void print (int [,] mass){                                                 // Печать массива
    for (int i =0; i<mass.GetLength(0); i++){
        for (int j=0; j<mass.GetLength(1);j++){
            Console.Write(mass[i,j]+" ");    
        }
        Console.WriteLine();
    }
}

Console.Clear();									
Console.WriteLine("Введите колличество строк от 1 до 5");
int m = int.Parse(Console.ReadLine()!);						
Console.WriteLine("Введите колличество столбцов от 1 до 5");
int n = int.Parse(Console.ReadLine()!);
int [,] raa=(arrey(m,n));
print(raa);