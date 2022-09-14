//Метод печати массива строк
void PrintArr(string[] s){
    Console.Write("[");
    for(int i=0; i<s.Length; i++){                                  //Цикл вывода строк массива
        Console.Write($"\"{s[i]}\"");
        if(i!=s.Length-1)
            Console.Write(", ");
    }
    Console.Write("] ");
}

//Метод возвращающий массив строк с длиной менее или 
//равной maxLen символов (по условию maxLen=3) из массива строк s
string[] GetArrayOfShortStrings(string[] s, int maxLen){
    int count=0;
    for(int i=0; i<s.Length; i++){                                  //Цикл определения необходимой длины результирующего массива
        if(s[i].Length<=maxLen) count++;    
    }
    string[] result = new string[count];
    count=0;
    for(int i=0; i<s.Length; i++){                                  //Цикл копирования строк в результирующий массив
        if(s[i].Length<=maxLen){
            result[count]=s[i];
            count++;
        }
    }
    return result;
}

Console.Clear();
string[] test1 = {"hello", "2", "world", ":-)"};                     //Тестовый массив 1
string[] test2 = {"1234", "1567", "-2", "computer science"};         //Тестовый массив 2
string[] test3 = {"Russia", "Denmark", "Kazan"};                     //Тестовый массив 3

PrintArr(test1);                                                     //Вывод тестового массива 1
Console.Write("-> ");
PrintArr(GetArrayOfShortStrings(test1,3));                           //Вывод результата выполнения GetArrayOfShortStrings с массивом test1 и maxLen=3

Console.WriteLine();
PrintArr(test2);                                                     //Вывод тестового массива 2
Console.Write("-> ");
PrintArr(GetArrayOfShortStrings(test2,3));                           //Вывод результата выполнения GetArrayOfShortStrings с массивом test2 и maxLen=3

Console.WriteLine();
PrintArr(test3);                                                     //Вывод тестового массива 3
Console.Write("-> ");
PrintArr(GetArrayOfShortStrings(test3,3));                           //Вывод результата выполнения GetArrayOfShortStrings с массивом test3 и maxLen=3