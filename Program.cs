
void PrintArray(string[] arrayStr){
    for (int index = 0; index < arrayStr.Length; index++) {
        Console.Write('"' + arrayStr[index] + '"');
        if (index < arrayStr.Length-1) {
            Console.Write(",");
        }
    }
}


string[] isxArrayStrings = {"Hello", "2", "world", ":-)"};
//string[] isxArrayStrings = {"1234", "1567", "-2", "computer science"};
//string[] isxArrayStrings = {"Russia", "Denmark", "Kazan"};


int countIsxArray = isxArrayStrings.Length;

int countResArray = 0;
for (int index = 0; index < countIsxArray; index++) {
    if (isxArrayStrings[index].Length <= 3) {
        countResArray++;
    }
}

string[] resArrayStrings = new string[countResArray];
int indexResArray = 0;
for (int index = 0; index < countIsxArray; index++) {
    if (isxArrayStrings[index].Length <= 3) {
        resArrayStrings[indexResArray] = isxArrayStrings[index];
        indexResArray++;
    }
}

Console.Write("Исходный массив строк: [");
PrintArray(isxArrayStrings);
Console.Write("]");
Console.WriteLine();
Console.Write("Результирующий массив строк: [");
PrintArray(resArrayStrings);
Console.Write("]");
Console.WriteLine();