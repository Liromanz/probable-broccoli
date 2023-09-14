string txt;
do
{
    Console.WriteLine("Выберите цвет");
    Console.WriteLine("1. Красный");
    Console.WriteLine("2. Коричневый");
    Console.WriteLine("3. Черный");
    Console.WriteLine("4. Желтый");
    Console.WriteLine("5. никакой");
    txt = Console.ReadLine();
    /* if (txt == "1")
     {
         int a = 5;
         Console.WriteLine(a);
     }
     else if (txt == "2")
     {
         Console.WriteLine("коричневый классный");
     }*/

    switch (txt)
    {
        case "1":
            Console.WriteLine("sdfsd");
            break;
        case "2":
            Console.WriteLine("коричневыйыывалывдаоыдвлоа");
            break;
        case "3":
            break;
    }
} while (txt != "5");