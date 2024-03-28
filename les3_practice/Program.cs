using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace les3_practice
{
    internal class Program
    {

        public class Franction
        {
            public Franction() { }
            public Franction(int num_1, int num_2)
            {
                this.numerator = num_1;
                this.denominator = num_2;
            }

            public void summ(ref Franction obj)
            {

                if (this.denominator == obj.denominator)
                {
                    this.numerator += obj.numerator;

                }
                else
                {
                    
                    this.numerator = (this.numerator * obj.denominator) + (obj.numerator * this.denominator);
                    this.denominator = (this.denominator * (obj.denominator));
                }
                this.Reduction();
                Console.WriteLine($"результат суммы двух дробей: {this.numerator} / {this.denominator}");
            }

            public void substration(ref Franction obj)
            {
                if (this.denominator == obj.denominator)
                {
                    this.numerator += obj.numerator;

                }
                else
                {
                    this.denominator = (this.denominator * (obj.denominator));
                    this.numerator = (this.numerator * (obj.denominator)) - (obj.numerator * this.denominator);
                }
                Console.WriteLine($"результат суммы двух дробей: {this.numerator} / {this.denominator}");
            }
            public void multiplication(ref Franction obj)
            {
                this.numerator *= obj.numerator;
                this.denominator *= obj.denominator;


                Console.WriteLine($"результат суммы двух дробей: {this.numerator} / {this.denominator}");
            }

            public void division(ref Franction obj)
            {
                this.numerator *= obj.denominator;
                this.denominator *= obj.numerator;


                Console.WriteLine($"результат суммы двух дробей: {this.numerator} / {this.denominator}");
            }



            public void Check_franc()
            {
                Console.WriteLine("Ваша текущая дробь:");
                Console.WriteLine($"{this.numerator} / {this.denominator}");
            }
            static public int Nod(int a, int b)
            {

                if (b == 0) return a;
                else return Nod(b, a % b);
            }

            public void Reduction()
            {
                int a = Nod(this.numerator, this.denominator);
                this.numerator = this.numerator / a;
                this.denominator = this.denominator / a;
            }

            public int numerator;
            public int denominator;
        }
        static void Main(string[] args)
        {
            Franction num_1 = new Franction(1, 2);
            Franction num_2 = new Franction(1, 3);
            num_1.summ(ref num_2);
        }
    }
}
