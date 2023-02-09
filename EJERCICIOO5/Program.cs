using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIOO5
{
    class Program
    {
        static void Main(string[] args)
        {
            string banda1, banda2, banda4, banda1_2, banda3_text;
            char banda3;
            double num_banda1_2, numb_banda3 = 0, banda_totals;
            

        
                Console.WriteLine("Colores de las bandas: /n ");
                Console.WriteLine(" negro  \n1-Marron \n2-Rojo  \n3-Naranja  \n4-Amarillo  \n5-Verde  \n6-Azul \n7-violeta  \n8-gris  \n9-blanco ");
                Console.WriteLine("\n digite el color de la primer banda");
                banda1 = Console.ReadLine();
                Console.WriteLine("digite el color de la segunda banda");
                banda2 = Console.ReadLine();
                Console.WriteLine("digite el color de la tercera banda");
                banda3_text = Console.ReadLine();
                Console.WriteLine("digite el color de la cuarta banda");
                banda4 = Console.ReadLine();
          

            banda1_2 = banda1 + banda2;
                num_banda1_2 = double.Parse(banda1_2);
                banda3 = Char.Parse(banda3_text);
               
                

            switch (banda3)
                {

                    case '0':
                        numb_banda3 = 1;
                        Console.WriteLine(numb_banda3 <= 1);

                        break;

                    case '1':
                        numb_banda3 = 10;
                       

                        break;

                    case '2':
                        numb_banda3 = 100;

                        break;

                    case '3':
                        numb_banda3 = 1000;
                        break;

                    case '4':
                        numb_banda3 = 10000;
                        break;

                    case '5':
                        numb_banda3 = 100000;
                        break;

                    case '6':
                        numb_banda3 = 1000000;
                        break;

                    case '7':
                        numb_banda3 = 10000000;
                        break;

                    case '8':
                        numb_banda3 = 100000000;
                        break;

                    case '9':
                        numb_banda3 = 1000000000;
                        break;

                 
                }

           
                banda_totals = num_banda1_2 * numb_banda3;
            
            Console.Write(banda_totals + " homs");
         
            
                Console.ReadKey();
          


         }
    }
}
