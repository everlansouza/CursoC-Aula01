using System;

namespace Course {

    class TiposPrimitivos {

        public static void Main(string[] args) {

            int menorNumero1 = int.MinValue;
            Console.WriteLine(menorNumero1);
            int maiorNumero1 = int.MaxValue;
            Console.WriteLine(maiorNumero1);


            decimal menorNumero2 = decimal.MinValue;
            Console.WriteLine(menorNumero2);
            decimal maiorNumero2 = decimal.MaxValue;
            Console.WriteLine(maiorNumero2);



            bool completo = false;
            Console.WriteLine(completo);

            char geneto = 'M';
            Console.WriteLine(geneto);
            char letar = '\u0041';//caracter unicode
            Console.WriteLine(letar);

            byte n1 = 126;
            Console.WriteLine(n1);

            int n2 = 1000;
            Console.WriteLine(n2);

            long n3 = 4000000L;
            Console.WriteLine(n3);

            float n4 = 4.5f;
            Console.WriteLine(n4);
            double n5 = 4.6;
            Console.WriteLine(n5);

            string nome = "Everlan";
            Console.WriteLine(nome);

            object ob1 = "Alex";
            Console.WriteLine(ob1);
            object ob2 = 6.3f;
            Console.WriteLine(ob2);

        }
    }
}
