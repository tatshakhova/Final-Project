string[] Array = new string[] {"Hello", "2", "world", ":-D"};
void Count(string[] array)
{ 
    Console.WriteLine("Массив из строк, длина которых меньше либо равна 3 символам:");
    foreach(string el in array)
    {
        if (el.Length <= 3) 
        {
           Console.Write($"{el} ");
        }
    }

}