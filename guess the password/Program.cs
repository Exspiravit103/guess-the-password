namespace guess_the_password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int passwordFirst, passwordSecond, passwordThree, passwordLast,UserPassword,count=0,rounds=0;
            Random random = new Random();
            passwordFirst = random.Next() & 9;
            passwordSecond = random.Next() & 9;
            passwordThree = random.Next() & 9;
            passwordLast = random.Next() & 9;
            //Console.WriteLine($"Пароль {passwordFirst}{passwordSecond}{passwordThree}{passwordLast}"); // небольшая отладка
            while (count < 4)
            {
                rounds++;
                UserPassword = int.Parse(Console.ReadLine().Trim());
                count = 0;
                string[] arr = { "X", "X", "X", "X" };
                if ((UserPassword / 1000) == passwordFirst)
                {
                    arr[0] = passwordFirst.ToString();
                    count++;
                }
                if (((UserPassword / 100) % 10) == passwordSecond)
                {
                    arr[1] = passwordSecond.ToString();
                    count++;
                }
                if (((UserPassword / 10) % 10) == passwordThree)
                {
                    arr[2] = passwordThree.ToString();
                    count++;
                }
                if (UserPassword % 10 == passwordLast)
                {
                    arr[3] = passwordLast.ToString();
                    count++;
                }
                Console.WriteLine($"{arr[0]},{arr[1]},{arr[2]},{arr[3]}");
            }
            Console.WriteLine($"Пароль введен верно с {rounds}-й попытки");
        }
    }
}
