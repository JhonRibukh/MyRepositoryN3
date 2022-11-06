

bool q = false;
int[] c = new int[] { 1635, 3270, 6541, 1308, 2616, 5233, 1047, 2093, 4186 };


oktava();

void oktava()
{
    
    do
    {

    
        ConsoleKeyInfo a = Console.ReadKey();
        if (a.Key == ConsoleKey.F1)
        {
            Console.Beep(c[0], 100);
        }
        if (a.Key == ConsoleKey.F2)
        {
            Console.Beep(c[1], 100);
        }
        if (a.Key == ConsoleKey.F3)
        {
            Console.Beep(c[2], 100);
        }
        if (a.Key == ConsoleKey.F4)
        {
            Console.Beep(c[3], 100);
        }
        if (a.Key == ConsoleKey.F5)
        {
            Console.Beep(c[4], 100);
        }
        if (a.Key == ConsoleKey.F6)
        {
            Console.Beep(c[5], 100);
        }
        if (a.Key == ConsoleKey.F7)
        {
            Console.Beep(c[6], 100);
        }
        if (a.Key == ConsoleKey.F8)
        {
            Console.Beep(c[7], 100);
        }
        if (a.Key == ConsoleKey.F9)
        {
            Console.Beep(c[8], 100);
        }
         if (a.Key == ConsoleKey.F10)
        {
           
        }
    }
    while (q = true) ;

}




