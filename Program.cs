void CountingChars(string[] array, int length)
{
    for (int i = 0; i < length; i++)
    {
        string str_Val = array[i];
        if (str_Val.Length <= 3)
        {
            Console.Write( str_Val + ", ");
        }
    }
}


void Main()
{
    string[] array = new string[] {"Hello", "4", "world", ":-)", "---"};
    int len_array = array.Length;
    Console.WriteLine();
    CountingChars(array, len_array);

}

Main();

