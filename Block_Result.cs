void main()
{
    Console.Write("введите символы или слова через пробел: ");
    string FirstStr = Console.ReadLine();
    string[] Strings = FirstStr.Split( );
    CreatNewString(Strings);
}

void CreatNewString(string[] Strings)
{
    string SumStr = "";
    foreach(string e in Strings)
    {
        if(IsNeed(e))
            SumStr = SumStr + e + " ";
    }
    PrintNewString(SumStr);
}

bool IsNeed(string str)
{
    char[] arr = str.ToCharArray( );
    if(arr.Length <= 3)
        return true;
    else return false;
}

main();
