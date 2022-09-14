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
    int BufferDeep=0;
    for (int i = 0; i < ArgInput.Count(); i++)
    {
        if (ArgInput[i].Length>=ArgLenght)
        {
            BufferDeep++;
            System.Array.Resize(ref Buffer, BufferDeep); //увеличение размера массива
            Buffer[BufferDeep-1]=ArgInput[i];
        }
    }
    return Buffer;
}

//метод вывода массива на экран
void PrintStringArray<T>(T[] ArgInput)
{
    if (ArgInput.Count()!=0)
    {
        Console.Write("{");
        for (int i = 0; i < ArgInput.GetLength(0); i++)
        {
           Console.Write($"{Convert.ToString(ArgInput[i])} "); 
        }
        Console.WriteLine("}");
    }
}
string[] MonkeyArray=new string[6]{"M", "Mo", "Mon", "Monk", "Monke", "Monkey"}; //исходный массив, заготовленный
string[] UserArray;    //исходный массив, вводимый пользователем
int UserArrayLenght;   //длина исходного массива, вводимого пользователем
int ConditionLenght;   //нужная длина для поиска
ConsoleKeyInfo choise; //переменная ввода клавиши

Console.Clear();
Console.WriteLine("Поиск в строковом массиве строк с длинной больше 3");
Console.WriteLine("Для 1- выбрать подготовленный массив, 2- ввести массив самостоятельно, Q - завершить работу программы");
choise=Console.ReadKey();
while (choise.Key!=ConsoleKey.Q)
{
    ConditionLenght=0;
    UserArrayLenght=0;
    string[] ResultArray=new string[0];  //результирующий массив
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
            ResultArray=FindInArray(MonkeyArray,ConditionLenght);
        } 
        if (choise.Key==ConsoleKey.D2) //используем подготовленный массив
        {
            //исходный массив
           //запрос длины для поиска
            while (UserArrayLenght<=0)
            {
                UserArrayLenght=CheckIntInput("Какой длины будет ваш массив строк");
            }
            UserArray=new string[UserArrayLenght];
            Console.Clear();
            for (int i = 0; (i < UserArrayLenght); i++)
            {
                Console.Write($"Введите {i+1}/{UserArrayLenght} элемент:");
                UserArray[i]=Console.ReadLine();
            }
            //исходный массив
            Console.Clear();
            Console.WriteLine("Ваш массив строк: ");
            PrintStringArray(UserArray);
            //запрос длины для поиска
            while (ConditionLenght<=0)
            {
                ConditionLenght=CheckIntInput("Введите количество знаков в строке для поиска в массиве");
            }
            ResultArray=FindInArray(UserArray,ConditionLenght);
        } 
    }
    if (ResultArray.Count()!=0)
    { 
        Console.WriteLine("Результирующий массив: ");
    }
    else 
    {
        Console.WriteLine("Строки заданной длины в массиве не найдены");
    }
    PrintStringArray(ResultArray);
    Console.WriteLine("Для 1- выбрать подготовленный массив, 2- ввести массив самостоятельно, Q - завершить работу программы");
    choise=Console.ReadKey();

}