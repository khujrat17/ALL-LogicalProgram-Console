using System;
using System.Speech;
using System.Speech.Synthesis;

namespace logicalprogram
{
    class String
    {
        // SpeechSynthesizer sy = new SpeechSynthesizer();



        public void reverse()
        {



            Console.WriteLine(" Enter a string which you want to reverse");
            string str = Console.ReadLine();
            string rev = " ";
            for (int i = str.Length - 1; i > 0; i--)
            {
                rev = rev + str[i];
            }
            Console.WriteLine(rev);
        }
        public void stringlength()
        {

            Console.WriteLine("============================");
            Console.WriteLine(" Enter a string ");
            string st = Console.ReadLine();
            Console.WriteLine(" The length of the string is: " + st.Length);
        }

        public void reversenumber()
        {

            Console.WriteLine("=============================");
            int num, rev = 0, rem;
            Console.WriteLine(" Enter a number");
            num = Convert.ToInt32(Console.ReadLine());
            while (num != 0)
            {
                rem = num % 10;
                rev = rev * 10 + rem;
                num /= 10;
            }
            // sy.Speak(" Chal aati ky 9 se 12 ");

            Console.WriteLine(" reversed number is:" + rev);

        }
        public void reverseword()
        {
            Console.WriteLine("=========================");
            int sk;
            Console.WriteLine(" Enter a string ");
            string str = Console.ReadLine();
            string[] a = str.Split(' ');
            int k = a.Length - 1;
            sk = k;
            for (int i = k; sk >= 0; k--)
            {
                Console.Write(a[sk] + "" + ' ');
                --sk;
            }
            Console.ReadKey();

        }
        public void duplicatearray()
        {
            Console.WriteLine("======================");
            int[] arr = new int[] { 1, 2, 2, 3, 4, 56, 7, 56, 78, 87, 78 };
            Console.WriteLine(" Duplicates elements in array are:");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                        Console.WriteLine(arr[j]);
                }
            }

        }



    }
    class Run
    {
        static void Main(string[] args)
        {
            // SpeechSynthesizer sy = new SpeechSynthesizer();
            String sn = new String();
            //sn.reverse();
            //sn.stringlength();
            //sn.reversenumber();
            //sn.reverseword();
            sn.duplicatearray();


        }

    }

}

