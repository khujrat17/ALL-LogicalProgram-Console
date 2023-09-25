namespace logicalprogram
{
    static class Allpattern
    {

        public static void Pattern1()
        {
            try
            {


                Console.WriteLine(" Enter your Range");
                int n = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= i; j++)

                        Console.Write(i + "");
                    Console.WriteLine();


                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
        public static void Pattern2()
        {
            try
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine("This is pttern no 2 ");
                Console.WriteLine(" Enter your Range");
                int n = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= i; j++)

                        Console.Write(j + "");
                    Console.WriteLine();


                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
        public static void Pattern2(int x)
        {
            try
            {


                Console.WriteLine("--------------------------");
                Console.WriteLine("This is pattern no 3");
                Console.WriteLine(" Enter your Range");
                int n = Convert.ToInt32(Console.ReadLine());
                for (int i = n; i >= 1; i--)
                {
                    for (int j = i; j >= 1; j--)

                        Console.Write(i + "");
                    Console.WriteLine();


                }

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
        public static void Pattern2(string y)
        {
            try
            {


                Console.WriteLine("--------------------------");
                Console.WriteLine("This is pattern no 3");
                Console.WriteLine(" Enter your Range");
                int n = Convert.ToInt32(Console.ReadLine());
                for (int i = n; i >= 1; i--)
                {
                    for (int j = i; j >= 1; j--)

                        Console.Write(j + "");
                    Console.WriteLine();


                }

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
        public static void alphabetpattern1()
        {
            try
            {


                Console.WriteLine("--------------------------");
                Console.WriteLine(" This is alphabetical pattern 1 :");
                Console.WriteLine(" Enter a range:");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-----");

                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= i; j++)

                        Console.Write((char)(i + 64));
                    Console.WriteLine(" ");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        public static void alphabetpattern2()
        {
            try
            {


                Console.WriteLine("-----------");
                Console.WriteLine("This is alphabet pattern no 2:");
                Console.WriteLine("Enter a range:");
                int n = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= i; j++)
                        Console.Write((char)(j + 64));
                    Console.WriteLine(" ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
        public static void alphabetpattern3()
        {
            try
            {


                Console.WriteLine("---------");
                Console.WriteLine("This is alphabet pattern no 3:");
                Console.WriteLine(" Enter a range:");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-----");
                for (int i = n; i >= 1; i--)
                {
                    for (int j = i; j >= 1; j--)
                        Console.Write((char)(i + 64));
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

        }
        public static void alphabetpattern4()
        {
            try
            {


                Console.WriteLine("---------");
                Console.WriteLine("This is alphabet pattern no 4:");
                Console.WriteLine(" Enter a range:");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-----");
                for (int i = n; i >= 1; i--)
                {
                    for (int j = i; j >= 1; j--)
                        Console.Write((char)(j + 64));
                    Console.WriteLine();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
        public static void alphabetpattern5()
        {
            try
            {


                Console.WriteLine("----------");
                Console.WriteLine("This is alphabet pattern no 5:");
                Console.WriteLine("Enter a range :");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-------");
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= n - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write((char)(j + 64));
                    }
                    for (int j = i - 1; j >= 1; j--)
                    {
                        Console.Write((char)(j + 64));
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
        public static void alkphabetpattern6()
        {
            try
            {


                Console.WriteLine("-------------");
                Console.WriteLine("This is alphabet pattern no 6:");
                Console.WriteLine("Enter a range:");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("------");
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= n - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write((char)(i + 64));
                    }
                    for (int j = i - 1; j >= 1; j--)
                    {
                        Console.Write((char)(i + 64));

                    }
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }





    }
    class Program
    {
        static void Main()
        {

            Allpattern.Pattern1();
            Allpattern.Pattern2();
            Allpattern.Pattern2(0);
            Allpattern.Pattern2("");
            Allpattern.alphabetpattern1();
            Allpattern.alphabetpattern2();
            Allpattern.alphabetpattern3();
            Allpattern.alphabetpattern4();
            Allpattern.alphabetpattern5();
            Allpattern.alkphabetpattern6();

        }
    }
}