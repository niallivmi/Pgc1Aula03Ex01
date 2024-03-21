//@niallivmi
using System;

namespace Pgc1Aula03Ex01
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Variável booleana para laço de refazer o cálculo
            bool verifica;

            //Laço
            do
            {
                float peso, altura, imc; //Variáveis pra conta do IMC
                string verificador; //Variável para verificar S/N do usuário

                Console.WriteLine("       Calculadora de IMC");
                Console.WriteLine("---------------------------------");

                Console.Write("Digite o peso (em kg): ");
                peso = float.Parse(Console.ReadLine());

                Console.Write("Digite a altura (em metros): ");
                altura = float.Parse(Console.ReadLine());
                Console.WriteLine("---------------------------------");

                imc = peso / (altura * altura); //Cálculo para IMC

                Console.WriteLine("O IMC é: " + imc);
                Console.WriteLine("---------------------------------");

                //Verificação do peso em IMC
                if (imc < 20)
                {
                    Console.WriteLine("O indivíduo está abaixo do peso.");
                }
                else if (imc < 25)
                {
                    Console.WriteLine("O indivíduo está com o peso normal.");
                }
                else
                {
                    Console.WriteLine("O indivíduo está acima do peso.");
                }

                Console.WriteLine("Deseja refazer o cálculo? (S/N)");
                Console.Write(">> ");
                verificador = Console.ReadLine();

                //Verifica se a resposta foi S para refazer o cálculo
                verifica = (verificador.ToUpper() == "S");
                Console.Clear();

            } while (verifica);

            Console.WriteLine("O programa será fechado!");
            Environment.Exit(0);
        }
    }
}
