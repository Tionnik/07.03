
int [,] arrey(int m,int n) {                                    //создание массива случайных чисел
    int [,] mass = new int [m,n];
    for (int i =0; i<m; i++){
        for (int j=0; j<n;j++){
            mass[i,j]=new Random().Next(10,100);
        }
    }
return mass;
}

void change(int [,] mass){                                      // Нахождение суммы в каждой строке
    int [] arrey= new int [mass.GetLength(0)];
    for (int i=0; i<mass.GetLength(0); i++){
        for (int j=0; j<mass.GetLength(1); j++){
            arrey[i]= arrey[i]+mass[i,j];
        }
    }
    int n=1;                                                    // Наихождение минимальной суммы в строках
    int min =arrey[0];
    for (int k=0; k<arrey.Length-1;k++){
        while (min>arrey[k+1]){
            n=k+2;
            min=arrey[k+1];
        }
    }
    Console.WriteLine((n)+" строка");                           // Показа номера строки с минимальной суммой
}

void print (int [,] mass){                                      // печать массива
    for (int i =0; i<mass.GetLength(0); i++){
        for (int j=0; j<mass.GetLength(1); j++){
            Console.Write(mass[i,j]+" ");
        }
    Console.WriteLine();
    }
}

Console.Clear();									
Console.WriteLine("Введите колличество строк");
int m = int.Parse(Console.ReadLine()!);						
Console.WriteLine("Введите колличество элементов");
int n = int.Parse(Console.ReadLine()!);
int [,] raa=(arrey(m,n));
print(raa);
change(raa);
