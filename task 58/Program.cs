int [] vvod(){                                                              //запись входных матриц в строку
    Console.WriteLine("Введите значения двузначной матрицы по порядку с лева на права с верху в низ, через пробел");
    int[] array = Console.ReadLine()!.Split(' ').Select(x=>int.Parse(x)).ToArray();	
    return array;
}


int [,] change(int [] mass1, int []mass2){                                  // Перемножение матриц
    int [,] arrey= new int [2,2];
    arrey[0,0]=mass1[0]*mass2[0]+mass1[1]*mass2[2];
    arrey[0,1]=mass1[0]*mass2[1]+mass1[1]*mass2[3];
    arrey[1,0]=mass1[2]*mass2[0]+mass1[3]*mass2[2];
    arrey[1,1]=mass1[2]*mass2[1]+mass1[3]*mass2[3]; 
    return arrey; 
}

void print (int [,] mass){                                                  //печать массива
    for (int i =0; i<mass.GetLength(0); i++){
        for (int j=0; j<mass.GetLength(1); j++){
            Console.Write(mass[i,j]+" ");
        }
    Console.WriteLine();
    }
}

Console.Clear();									
int [] matrica1 = vvod();
int [] matrica2 = vvod();
Console.WriteLine();
print(change(matrica1,matrica2));
