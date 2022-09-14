//Метод печати массива строк s
void PrintArr(string[] s){
    for(int i=0; i<s.Length; i++){                                                                  //Цикл вывода строк массива
        Console.WriteLine(s[i]);
    }
}

//Метод возвращающий массив строк с длиной менее или равной maxLen символов (по условию maxLen=3) из массива строк s
string[] GetArrayOfShortStrings(string[] s, int maxLen){
    int count=0;

    for(int i=0; i<s.Length; i++){                                                                  //Цикл определения необходимой длины результирующего массива
        if(s[i].Length<=maxLen) count++;    
    }

    string[] result = new string[count];

    count=0;

    for(int i=0; i<s.Length; i++){                                                                  //Цикл копирования строк в результирующий массив
        if(s[i].Length<=maxLen){
            result[count]=s[i];
            count++;
        }
    }

    return result;
}

Console.Clear();
string[] s = {"gf2", "dnfl", "123", "fsdff", "f", "fdasndl", "fdg", "fgd12l", "15", "12dfg"};       //Инициализация исходного массива строк
PrintArr(s);                                                                                        //Вывод исходного массива строк
Console.WriteLine();
PrintArr(GetArrayOfShortStrings(s,3));                                                              //Вывод результата выполнения GetArrayOfShortStrings с массивом s и maxLen=3