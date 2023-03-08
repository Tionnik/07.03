
int [,] arrey(int m,int n) {                                    //создание массива случайных чисел
    int [,] mass = new int [m,n];
    for (int i =0; i<m; i++){
        for (int j=0; j<n; j++){
            mass[i,j]=new Random().Next(10,100);
        }
    }
return mass;
}

void change(int [,] mass){                                       // Сорировка строк в массиве от большего к меньшиму
    for (int i=0; i<mass.GetLength(0); i++){
        for (int k=0; k<mass.GetLength(1); k++){
            int max=mass[i,k];
            int n=k;
            for (int j=1+k; j<mass.GetLength(1); j++){
                if(max<mass[i,j]){
                    max=mass[i,j];
                    n=j;
                }
            }
            int d=mass[i,k];
            mass[i,k]=mass[i,n];
            mass[i,n]=d;
        }
    }
        
}

void print (int [,] mass){                                      // Печать массива
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
Console.WriteLine();
print(raa);

