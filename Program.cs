string[] MonkeyArray=new string[6]{"M", "Mo", "Mon", "Monk", "Monke", "Monkey"}; //исходный массив
string[] UserArray;    //массив вводимый пользователем
string[] ResultArray;  //результирующий массив
ConsoleKeyInfo choise; //переменная ввода клавиши

Console.WriteLine("Поиск в строковом массиве строк с длинной больше 3");
Console.WriteLine("Для 1- выбрать подготовленный массив, 2- ввести массив самостоятельно, Q - завершить работу программы");
choise=Console.ReadKey();
while (choise.Key!=ConsoleKey.Q)
{
    Console.Clear();
    
    Console.WriteLine("Для 1- выбрать подготовленный массив, 2- ввести массив самостоятельно, Q - завершить работу программы");
    choise=Console.ReadKey();

}