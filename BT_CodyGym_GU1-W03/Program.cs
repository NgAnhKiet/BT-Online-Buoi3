internal class Program
{
    private static void Main(string[] args)
    {
        //Thực hành thiết kê menu cho ứng dụng
        int choice = -1;
        while (choice != 0)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Draw the triangle");
            Console.WriteLine("2. Draw the square");
            Console.WriteLine("3. Draw the rectangle");
            Console.WriteLine("0. Exit");
            Console.WriteLine("Enter your choice: ");
            choice = Int32.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Draw the triangle");
                    Console.WriteLine("******");
                    Console.WriteLine("*****");
                    Console.WriteLine("****");
                    Console.WriteLine("***");
                    Console.WriteLine("**");
                    Console.WriteLine("*");
                    break;
                case 2:
                    Console.WriteLine("Draw the square");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    break;
                case 3:
                    Console.WriteLine("Draw the rectangle");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("No choice!");
                    break;
            }
        }

        //Thực hành kiểm tra số nguyên tố
        int number;
        Console.WriteLine("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        if (number < 2)
            Console.WriteLine(number + " is not a prime");
        else
        {
            int i = 2;
            bool check = true;
            while (i <= Math.Sqrt(number))
            {
                if (number % i == 0)
                {
                    check = false;
                    break;
                }
                i++;
            }
            if (check)
                Console.WriteLine(number + " is a prime");
            else
                Console.WriteLine(number + " is not a prime");
        }

        //Bài tập hiển thị các loại hình
        System.Console.WriteLine("Lua chon hinh de in");
        System.Console.WriteLine("Nhap so 1 de in ra hinh tam giac vuong");
        System.Console.WriteLine("Nhap so 2 de in ra hinh chu nhat");
        int select = int.Parse(Console.ReadLine());
        switch (select)
        {
            case 1:
                //Tam giác vuông
                for (int i = 1; i <= 5; i++)
                {
                    for (int j = 1; j < i; j++)
                    {
                        System.Console.Write("* ");
                    }
                    System.Console.WriteLine("* ");
                }
                break;
            case 2:
                //Hình chữ nhật
                for (int i = 1; i <= 4; i++)
                {
                    for (int j = 1; j < 10; j++)
                    {
                        System.Console.Write("* ");
                    }
                    System.Console.WriteLine("* ");
                }
                break;
        }
    }
}