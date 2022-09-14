//метод проверки вводимого значения
int CheckIntInput(string Message)
{
    bool InputNotOk=true; //введены некорректные данные
    int Buffer=0;                 //число для ввода
    string ErrMessage="";
    while (InputNotOk) //пока введены некорректные данные
    {
        Console.Write($"{ErrMessage}{Message} :");
        try
        {
            Buffer=Convert.ToInt32(Console.ReadLine());
            InputNotOk=false; //считаем что данные введены корректно
        }
        catch (SystemException) 
        {
                InputNotOk=true; //пока введены некорректные данные
                ErrMessage="Неправильный ввод. ";
                Console.WriteLine();
        }
        }
    return Buffer;
}

//метод поиска в исходном массиве строк определённой длины
string[] FindInArray(string[] ArgInput, int ArgLenght)
{
    string[] Buffer=new string[0];
    string[] Result=new string[0];
    int BufferDeep=0;
    for (int i = 0; i < ArgInput.Count(); i++)
    {
        if (ArgInput[i].Length>=ArgLenght)
        {
            BufferDeep++;
            System.Array.Resize(ref Buffer, BufferDeep); //увеличение размера массива
            Buffer[BufferDeep]=ArgInput[i];
        }
    }
    if (Buffer.Count()>1) 
    {
        Result=new string[BufferDeep-1];
        for (int i = 0; i < BufferDeep-1; i++)
        {
            Result[i]=Buffer[i+1];
        }
    }
    return Result;
}

//метод вывода массива на экран
void PrintStringArray<T>(T[] ArgInput)
{
    if (ArgInput.Count!=0)
    {
        Console.Write("{");
        for (int i = 0; i < ArgInput.Count; i++)
        {
           Console.Write($" {Convert.ToString(Arginput[i])}"); 
        }
        Console.WriteLine("}");
    }
}
string[] MonkeyArray=new string[6]{"M", "Mo", "Mon", "Monk", "Monke", "Monkey"}; //исходный массив, заготовленный
string[] UserArray;    //исходный массив, вводимый пользователем
string[] ResultArray;  //результирующий массив
int ConditionLenght; //нужная длина для поиска
ConsoleKeyInfo choise; //переменная ввода клавиши

Console.Clear();
Console.WriteLine("Поиск в строковом массиве строк с длинной больше 3");
Console.WriteLine("Для 1- выбрать подготовленный массив, 2- ввести массив самостоятельно, Q - завершить работу программы");
choise=Console.ReadKey();
while (choise.Key!=ConsoleKey.Q)
{
    ConditionLenght=0;
    Console.Clear();
    if (choise.Key==ConsoleKey.D1 || choise.Key==ConsoleKey.D2) //пользователь сделал выбор
    {

        if (choise.Key==ConsoleKey.D1) //используем подготовленный массив
        {
            //исходный массив
            Console.WriteLine("Исходный массив строк: ");
            PrintStringArray(MonkeyArray);

            //запрос длины для поиска
            while (ConditionLenght<=0)
            {
                ConditionLenght=CheckIntInput("Введите количество знаков в строке для поиска в массиве");
            }
            ResultArray=new string[]; //чистка массива
            ResultArray=FindInArray(MonkeyArray,ConditionLenght);
        } 
        if (choise.Key==ConsoleKey.D2) //используем подготовленный массив
        {
            //исходный массив
            Console.WriteLine("Исходный массив строк: ");
            PrintStringArray(MonkeyArray);

            //запрос длины для поиска
            while (ConditionLenght<=0)
            {
                ConditionLenght=CheckIntInput("Введите количество знаков в строке для поиска в массиве");
            }
            ResultArray=new string[]; //чистка массива
            ResultArray=FindInArray(MonkeyArray,ConditionLenght);
        } 
    }
    
    Console.WriteLine("Для 1- выбрать подготовленный массив, 2- ввести массив самостоятельно, Q - завершить работу программы");
    choise=Console.ReadKey();

}