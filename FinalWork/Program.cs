//Условие задачи прописана в README.md
string[] a = {"hello","2","world",":-"};
string[] b = {"1234","1567","-2","computer science"};
string[] c = {"Russia","Denmark","Kazan"};
itogArray(a);
itogArray(b);
itogArray(c);

//Определение длины будущего массива
int arrayLength(string[] d){
    int k=0;
    for (int i = 0; i < d.Length; i++)
        if(d[i].Length <= 3) k++;
    return k;
}

//Печать массива
void printArray(string[] d){
    System.Console.Write("[");
    for(int i=0; i<d.Length;i++)
        if(i<d.Length-1) 
            System.Console.Write($"\"{d[i]}\", ");
        else 
            System.Console.Write($"\"{d[i]}\"");
    System.Console.WriteLine("]");
}

//Формирование нового массива
void itogArray(string[] t){
    string[] temp = new string [arrayLength(t)];
    int k=0;
    for (int i = 0; i < t.Length; i++)
    {
        if(t[i].Length<=3) {
            temp[k]=t[i];
            k++;
        }
    }
    printArray(temp);
}