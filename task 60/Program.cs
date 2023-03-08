
int [,,] arrey(int m,int n, int s) {                                        //Создание массива случайных чисел
    int [,,] mass = new int [m,n,s];
    for (int i =0; i<m; i++){
        for (int j=0; j<n;j++){
            for (int k=0; k<s; k++){
                mass[i,j,k]=new Random().Next(10,100);
            }
        }
    }
return mass;
}
void change(int [,,] mass){                                                 //Замена одинаковых чисел в массиве на новое случайное
M:  for (int i=0; i<mass.GetLength(0); i++){
        for (int j=0; j<mass.GetLength(1);j++){
            for (int k=0; k<mass.GetLength(2); k++){

                for(int i1=0; i1<mass.GetLength(0);i1++){
                    for(int j1=0; j1<mass.GetLength(1);j1++){
                        for(int k1=0; k1<mass.GetLength(2); k1++){

                            if ((i==i1)&&(j==j1)&&(k==k1)) {}
                            else{    
                                if((mass[i,j,k]==mass[i1,j1,k1])){
                                    mass[i1,j1,k1]=new Random().Next(10,100);
                                    goto M;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}


void print (int [,,] mass){                                                 // Печать массива
    for (int i =0; i<mass.GetLength(0); i++){
        for (int j=0; j<mass.GetLength(1); j++){
            for (int k=0; k<mass.GetLength(2);k++){
                Console.Write(mass[i,j,k]+"("+i+", "+j+", "+k+")");    
            }
            Console.WriteLine();
        }
    }
}

Console.Clear();									
Console.WriteLine("Введите колличество строк");
int m = int.Parse(Console.ReadLine()!);						
Console.WriteLine("Введите колличество столбцов");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите колличество элементов");
int s = int.Parse(Console.ReadLine()!);
int [,,] raa=(arrey(m,n,s));
/*print(raa);
Console.WriteLine();
raa[0,1,0]=15;
raa[1,1,0]=15;
raa[0,1,1]=15;
raa[2,1,2]=15;
raa[2,2,0]=15;
print(raa);*/
change(raa);
//Console.WriteLine();
print(raa);

