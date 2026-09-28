class Program
{




    static void Main(string[] args)
    {
        Random los = new Random();
        int losowa = los.Next(0, 5);
        Console.WriteLine(losowa);
        switch (losowa)
        {
            
            case 1:
                Console.WriteLine("i jest mniejsze od 3 ");
                break;
            case 2:
                goto case 1;
                
            case 3:
                Console.WriteLine("i jest mniejsze od 6");
                goto default;
                
            case 4:
                goto case 3;
                
            case 0:
                goto default;
                



            default:
                Console.WriteLine("Nie został wykonany ani blok case 1, ani blok case 2");
                break;
        }
    }
}