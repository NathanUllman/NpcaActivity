using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ncpaParsingTask
{
    class Program
    {

/* Task 1 : Change wordToEncrypt to 'nebraska huskers' */
/* Hint: looks like you need to make everything lower case */
        public static void Task1(string wordToEncrypt)
        {
            wordToEncrypt = "Nebraska Huskers";

            /* Your code goes below this line */
            wordToEncrypt = wordToEncrypt.ToLower();

            /* ^^^^^^^^^^ and above this line ^^^^^^^^^^^*/

            Console.WriteLine("Task 1: '{0}'", wordToEncrypt); 
            // wordToEncrypt will be printed out when program is run, that way you can see if you are correct
        }

/* Task 2 : change wordToEncrypt to 'Cozmputers' */
        public static void Task2(string wordToEncrypt)
        {
            wordToEncrypt = "Computers";

            /* Your code goes below this line */
            wordToEncrypt = wordToEncrypt.Replace("m", "z");

            /* ^^^^^^^^^^ and above this line ^^^^^^^^^^^*/

            Console.WriteLine("Task 2: '{0}'", wordToEncrypt);
        }

/* Task 3 : change wordToEncrypt to 'Cod00ing' */
        public static void Task3(string wordToEncrypt)
        {
            wordToEncrypt = "Coding";

            /* Your code goes below this line */
            wordToEncrypt = wordToEncrypt.Insert(3, "00");

            /* ^^^^^^^^^^ and above this line ^^^^^^^^^^^*/

            Console.WriteLine("Task 3: '{0}'", wordToEncrypt);
        }
/* Task 4 : change wordToEncrypt to 'dtwoToo$sNeedet' */
        public static void Task4(string wordToEncrypt)
        {
            wordToEncrypt = "twoToolsNeeded";

            /* Your code goes below this line */
            wordToEncrypt = wordToEncrypt.Replace("l", "$");
            wordToEncrypt = SwitchFirstAndLastLetter(wordToEncrypt);

            /* ^^^^^^^^^^ and above this line ^^^^^^^^^^^*/

            Console.WriteLine("Task 4: '{0}'", wordToEncrypt);
        }
/* Task 5 : change wordToEncrypt to 'eerdeerHeelpsHeeree!!' */
        public static void Task5(string wordToEncrypt)
        {
            wordToEncrypt = "OrderHelpsHere";
            /* Your code goes below this line */
            wordToEncrypt = wordToEncrypt.Insert(14, "!!");
            wordToEncrypt = wordToEncrypt.Replace("O", "e");
            wordToEncrypt = wordToEncrypt.Replace("e", "ee");

            /* ^^^^^^^^^^ and above this line ^^^^^^^^^^^*/

            Console.WriteLine("Task 5: '{0}'", wordToEncrypt);
        }


/* WordToEncrypt now will already be encoded,
* it is your job is to look to see how it was encoded and decode it to its original state */
        public static void Task6(string wordToEncrypt)
        {
            wordToEncrypt = "Scott Frost is cool";

            // here is the encoding
            wordToEncrypt = wordToEncrypt.Insert(15, "not ");


            /* Your code to decrypt goes below this line */
            wordToEncrypt = wordToEncrypt.Replace("not ", "");

            /* ^^^^^^^^^^ and above this line ^^^^^^^^^^^*/

            Console.WriteLine("Task 6: '{0}'", wordToEncrypt);
        }

 /* Task 7 : descode that sucker */
 /* BONUS: dont use Insert to decrypt*/
        public static void Task7(string wordToEncrypt)
        {
            wordToEncrypt = "time to step it up a notch@@@";

            // encoding
            wordToEncrypt = wordToEncrypt.Insert(3, "@@@");
            wordToEncrypt = ReverseAllLetters(wordToEncrypt);

            /* Your code goes below this line */
            wordToEncrypt = ReverseAllLetters(wordToEncrypt);
            wordToEncrypt = SwitchFirstAndLastLetter(wordToEncrypt);
            wordToEncrypt = wordToEncrypt.Replace("@@@", "");
            wordToEncrypt = SwitchFirstAndLastLetter(wordToEncrypt);

            /* ^^^^^^^^^^ and above this line ^^^^^^^^^^^*/

            Console.WriteLine("Task 7: '{0}'", wordToEncrypt);
        }
/* Task 8 : keep on decoding */
        public static void Task8(string wordToEncrypt)
        {
            wordToEncrypt = "Hacker Status Achieved";

            // Encoding
            wordToEncrypt = wordToEncrypt.Replace("H", "");
            wordToEncrypt = wordToEncrypt.Replace("d", "");
            wordToEncrypt = SwitchFirstAndLastLetter(wordToEncrypt);
            wordToEncrypt = wordToEncrypt.Insert(2, "***");
            wordToEncrypt = ReverseAllLetters(wordToEncrypt);
            wordToEncrypt = wordToEncrypt.Replace(" ", "Space");


            /* Your code goes below this line */
            wordToEncrypt = wordToEncrypt.Replace("Space", " ");
            wordToEncrypt = ReverseAllLetters(wordToEncrypt);
            wordToEncrypt = wordToEncrypt.Replace("***", "");
            wordToEncrypt = SwitchFirstAndLastLetter(wordToEncrypt);
            wordToEncrypt = wordToEncrypt.Insert(20, "d");
            wordToEncrypt = wordToEncrypt.Insert(0, "H");

            /* ^^^^^^^^^^ and above this line ^^^^^^^^^^^*/

            Console.WriteLine("Task 8: '{0}'", wordToEncrypt);
        }
/* Task 9 : decode some more */
        public static void Task9(string wordToEncrypt)
        {
            wordToEncrypt = "@@#($%#@#)(*&^%^&*(*&^%$#@+{";

            // encoding
            wordToEncrypt = wordToEncrypt.Replace("%", "@@$");
            wordToEncrypt = wordToEncrypt.Replace("@@", "");
            wordToEncrypt = wordToEncrypt.Insert(5, "actual word");
            wordToEncrypt = wordToEncrypt.Replace(" ", "12300");
            wordToEncrypt = ReverseAllLetters(wordToEncrypt);
            wordToEncrypt = SwitchFirstAndLastLetter(wordToEncrypt);
            wordToEncrypt = wordToEncrypt.Insert(1, "Good Luck");


            /* Your code goes below this line */
            wordToEncrypt = wordToEncrypt.Replace("Good Luck", "");
            wordToEncrypt = SwitchFirstAndLastLetter(wordToEncrypt);
            wordToEncrypt = ReverseAllLetters(wordToEncrypt);
            wordToEncrypt = wordToEncrypt.Replace("12300", " ");
            wordToEncrypt = wordToEncrypt.Replace("actual word", "");
            wordToEncrypt = wordToEncrypt.Insert(0, "@@");
            wordToEncrypt = wordToEncrypt.Replace("@@$", "%");



            /* ^^^^^^^^^^ and above this line ^^^^^^^^^^^*/

            Console.WriteLine("Task 9: '{0}'", wordToEncrypt);
        }

        // what are some flaw with using these decryptions methods?
        // write an encoding that would be impossible to decode without seeing the inital word first

        public static void Task10(string wordToEncrypt)
        {
            wordToEncrypt = "Nathan";

            /* Your code goes below this line */
            wordToEncrypt = wordToEncrypt.Replace("a", "n"); // this is one of many examples

            /* ^^^^^^^^^^ and above this line ^^^^^^^^^^^*/

            Console.WriteLine("Task 10: '{0}'", wordToEncrypt);
        }

        static void Main(string[] args)
        {
            Task1("");
            Task2("");
            Task3("");
            Task4("");
            Task5("");
            Task6("");
            Task7("");
            Task8("");
            Task9("");
            Task10("");

            //normalize for crazy capital letters
            // what are some words that would not work with this encrption, Nathan changing all N's to a's would mess up 
            // either figure out words or figure out encryption 
            // use different character like * to really make it seem hacker like
            // switch up words before you insert them?
            // what word would you have to enter so that this returns 'Nebraska' or something
        }


        public static string ReverseAllLetters(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }


        public static string SwitchFirstAndLastLetter(string s)
        {
            if (s == "")
            {
                return s;
            }

            char[] arr = s.ToCharArray();
            var temp = arr[0];
            arr[0] = arr[arr.Length - 1];
            arr[arr.Length - 1] = temp;
            return new string(arr);
        }

    }


}
