using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace signos_sodiacales_uwu
{
    class sodiacal
    {
        int dia;
        int mes;

        public void presentacion()
        {
            Console.WriteLine("Conoce tu signo ZODIACAL.");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
        }


        public void dym()
        {
            Console.WriteLine("Escribe el dia que naciste: ");
            dia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");

            Console.WriteLine("Escribe el mes que naciste: (formato en numero)");
            mes = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(" ");
        }



        public void sodiaco()
        {
            if ((dia >= 20 && mes == 3) || (dia <= 18 && mes == 4))
            {
                Console.WriteLine("Tu signo es Aries");

            }
            if ((dia >= 19 && mes == 4) || (dia <= 19 && mes == 5))
            {
                Console.WriteLine("Tu signo es Tauro");

            }
            if ((dia >= 20 && mes == 5) || (dia <= 20 && mes == 6))
            {
                Console.WriteLine("Tu signo es Geminis");

            }
            if ((dia >= 21 && mes == 6) || (dia <= 21 && mes == 7))
            {
                Console.WriteLine("Tu signo es Cáncer");

            }
            if ((dia >= 22 && mes == 7) || (dia <= 21 && mes == 8))
            {
                Console.WriteLine("Tu signo es Leo");

            }
            if ((dia >= 22 && mes == 8) || (dia <= 21 && mes == 9))
            {
                Console.WriteLine("Tu signo es Virgo");
            }
            if ((dia >= 22 && mes == 9) || (dia <= 22 && mes == 10))
            {
                Console.WriteLine("Tu signo es Libra");

            }
            if ((dia >= 23 && mes == 10) || (dia <= 20 && mes == 11))
            {
                Console.WriteLine("Tu signo es Escorpio");

            }
            if ((dia >= 21 && mes == 11) || (dia <= 20 && mes == 12))
            {
                Console.WriteLine("Tu signo es Sagitario");

            }
            if ((dia >= 21 && mes == 12) || (dia <= 19 && mes == 1))
            {
                Console.WriteLine("Tu signo es Capricornio");

            }
            if ((dia >= 20 && mes == 1) || (dia <= 18 && mes == 2))
            {
                Console.WriteLine("Tu signo es Acuario");

            }
            if ((dia >= 19 && mes == 2) || (dia <= 19 && mes == 3))
            {
                Console.WriteLine("Tu signo es Picsis");
            }


        }

                                                
      }


  }



