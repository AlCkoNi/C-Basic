using System;
using System.Text;
using static System.Console;


namespace C__Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            C_sharp_Basic c = new C_sharp_Basic();
            c.lesson8();
        }
    }
    public class C_sharp_Basic
    {
        public void lesson1() //lESSON - 1 wHAT iS .nET aND CLI, CLR, SDK
        {
            //.Net - is Free.Cross - platform.Open source.
            // A developer platform for building all your apps.
            WriteLine("Hello World");
        }
        public void lesson2() //Data types
        {
            //For example
            string name = "Tolibjon";
            int age = 20;
            string job = "Student";
            bool isMarried = false;
            /*
            bool
            • boolean toifasi 1 bit ma’lumotni ifodalash uchun ishlatiladi.
            • Faqat ikkita qiymat qabul qilishi mumkin : true va false
            • Default qiymati false
            • Example: boolean one = true;
            */
            /*
             byte
            • Byte toifasi hajmi 8-bit bo’lgan butun sonlarni ifodalash uchun qo’llaniladi.
            • Minimum qiymati -128 (-2^7)
            • Maximum qiymati 127 (inclusive)(2^7 -1)
            • Default qiymati 0
            • Example: byte a = 100, b = -50;
            */
            /*
            short
            • Short toifasi hajmi 16-bit bo’lgan butun sonlarni ifodalash uchun qo’llaniladi.
            • Minimum qiymati -32,768 (-2^15)
            • Maximum qiymati 32,767 (inclusive) (2^15 -1)
            • Default qiymati 0.
            • Example: short s = 10000, r = -20000, x; //x=0
            */
            /*
            int
            • int toifasi hajmi 32-bit bo’lgan butun sonlarni ifodalash uchun qo’llaniladi.
            • Minimum qiymati - 2,147,483,648 (-2^31)
            • Maximum qiymati 2,147,483,647(inclusive) (2^31 -1)
            • int barcha butun sonli toifalarning default toifasi hisoblanadi.
            • Default qiymati 0
            • Example: int a = 100000, b = -200000;
            */
            /*
            long
            • Long toifasi hajmi 64-bit bo’lgan butun sonlarni ifodalash uchun
            qo’llaniladi.
            • Minimum qiymati -9,223,372,036,854,775,808(-2^63)
            • Maximum qiymati 9,223,372,036,854,775,807 (inclusive)(2^63 -1)
            • Default qiymati 0L
            • Example: long a = 100000L, b = -200000L, x=9
            */
            /*
            float
            • float toifasi 32- bitli vergulli sonlarni ifodalash uchun ishlatiladi.
            • Default qiymati 0.0f
            • Example: float f1 = 234.5f
            */
            /*
            double
            • double toifasi 64- bitli vergulli sonlarni ifodalash uchun ishlatiladi.
            • Ushbu toifa vergulli sonlar uchun default toifa hisoblanadi.
            • Default value is 0.0d
            • Example: double d1 = 123.4 
            */
            /*
            char
            • char toifasi yordamida istalgan belgini ifodalash mumkin.
            • Example: char letterA = ‘A’, number=‘1’;
            */
            // Data_type variableName = value;
        }
        public void lesson3() //Casting
        {

        }
        public void lesson4() //Operators
        {

        }
        public void lesson5() //Control statements
        {

        }
        public void lesson6() //Loops
        {

        }
        public void lesson7() //Methods
        {

        }
        public void lesson8() // Strings
        {
            /*
            What is a String this Sum eny chars in one line  
            For examplr :
            */
            char[] name = { 'T', 'o', 'l', 'i', 'b', 'j', 'o', 'n' };
            string name1 = "Tolibjon";
            /*
            String have 2 types one word and eny words
            For example :
            */
            string str1 = "HI";
            string str2 = "Hello World";
            /*
            How to giving value for string
            For examle :
            */
            string massage1 = null;// this is a giving null value
            string massage2 = " ";// this is a string with empty value
            string massage3 = System.String.Empty;// this is a giving empty value 
            string massage4 = new string(" This is new value for this string");// new string
            /*
            We sholud pluse some strings
            For example :
            */
            string s1 = "Hello";
            string s2 = "World";
            s1 += s2;
            WriteLine(s1);
            //Verbatim string literal
            //string path = "C:Donw\sasda\asda\da\sda";//Error
            string path1 = @"C:Donw\sasda\asda\da\sda";// Whith literals
            string World = "Hello";
            WriteLine($"{World} World");//inerapolation
            WriteLine("{0} World", World);//composite
            // String Builder 
            StringBuilder sb = new StringBuilder("Salom");
            sb[0] = 'C';
            WriteLine(sb.ToString());
        }
    }
}
