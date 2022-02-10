using System;

namespace Tupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cordenadasTotalX;
            int cordenadasTotalY;

            int cordenadasInicialX;
            int cordenadasInicialY;

            
            string funções;

            int graus = 0;
            int total = 0;

            char letras;
            char local;

            int finalX = 0;
            int finalY = 0;

            int robo = 0;
            //cordenadas do local 
            Console.Write("Escreva as cordenadas X iniciais : ");
            cordenadasInicialX = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escreva as cordenadas Y iniciais : ");
            cordenadasInicialY = Convert.ToInt32(Console.ReadLine());

            while (robo<2){
                robo++;
                Console.Write("Escreva as cordenadas X iniciais do Robo : ");
                cordenadasTotalX = Convert.ToInt32(Console.ReadLine());

                Console.Write("Escreva as cordenadas Y iniciais do Robo : ");
                cordenadasTotalY = Convert.ToInt32(Console.ReadLine());

                Console.Write("Escreva a sua orientação inicial (OBS: Letra MAIUSCULA!!!!!!) : ");
                local = Convert.ToChar(Console.ReadLine());

                //funções do robo
                Console.WriteLine("Escreva Suas funções");
                funções = Console.ReadLine();

                if (cordenadasTotalX > cordenadasInicialX || cordenadasTotalY > cordenadasInicialX)
                {
                    Console.WriteLine("Favor colocar as cordenadas corretas");
                }

                if (local == 'S')
                {
                    graus = 180;

                }
                else if (local == 'N')
                {
                    graus = 0;
                }
                else if (local == 'O')
                {
                    graus = 270;
                }
                else if (local == 'L')
                {
                    graus = 90;
                }
                for (int i = 0; i < funções.Length; i++)

                {
                    int contagem = 0;

                    letras = funções[i];

                    if (letras == 'M')
                    {
                        if (graus == 90)
                        {

                            finalY = cordenadasTotalY += 1;

                        }
                        else if (graus == 0)
                        {
                            finalX = cordenadasTotalX += 1;


                        }
                        else if (graus == 180)
                        {


                            finalX = cordenadasTotalX -= 1;
                        }
                        else if (graus == 270 || graus == -270)
                        {


                            finalY = cordenadasTotalY -= 1;

                        }

                    }
                    else if (letras == 'D')
                    {
                        total = graus += 90;


                        if (total >= 360)
                        {
                            graus = 0;
                            total = 0;
                        }
                    }
                    else if (letras == 'E')
                    {
                        total = graus -= 90;

                        if (graus <= -360)
                        {
                            graus = 0;
                            total = 0;
                        }
                    }
                }
                if (graus >= 360 || graus == 0 || graus <= -360)
                {
                    local = 'N';
                    graus = 0;


                }
                else if (graus == 90 || graus == -270)
                {
                    local = 'L';


                }
                else if (graus == 180 || graus == -180)
                {
                    local = 'S';


                }
                else if (graus == 270 || graus == -90)
                {
                    local = 'O';

                }
                Console.WriteLine("(" + "" + finalY + "," + finalX + "," + local + ")");
                continue;
            }
            
        }    
    }
}
