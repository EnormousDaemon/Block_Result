void main()
{
    Console.Write("введите символы или слова через пробел: ");
    string FirstStr = Console.ReadLine();
    string[] Strings = FirstStr.Split( );
    CreatNewString(Strings);
}

