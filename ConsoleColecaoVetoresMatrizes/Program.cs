using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleColecaoVetoresMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Array           
            // criando um vetor (Array) de 5 posições
            int[] numeros = new int[5];
            numeros[0] = 10;
            numeros[1] = 100;
            numeros[2] = 1000;
            numeros[3] = 10000;
            numeros[4] = 100000;

            Console.WriteLine(numeros[4]);
           
            // criando um array de string tamanho 7
            string[] semana = new string[7];
            semana[0] = "Segunda";
            semana[1] = "Terça";
            semana[2] = "Quarta";
            semana[3] = "Quinta";
            semana[4] = "Sexta";
            semana[5] = "Sabado";
            semana[6] = "Domingo";

            // Outra forma de declarar vetores/arrays
            string[] meses = 
            { 
                "Janeiro", 
                "Fevereiro", 
                "Março", 
                "Abril", 
                "Maio", 
                "junho", 
                "Julho", 
                "Agosto", 
                "Setembro", 
                "Outrubo", 
                "Novembro", 
                "Dezembro" 
            };

            Console.WriteLine(meses.Length);
            #endregion

            #region Matriz/Vetor bidimensional
            // nesse formato, para tratar cada celula, faz referencia da linha e coluna

            // declarando uma matriz de numeros, com 2 linhas e 3 colunas
            int[,] notas = new int[2, 3];
            notas[0, 0] = 90;
            notas[0, 1] = 80;
            notas[0, 2] = 95;
            notas[1, 0] = 85;
            notas[1, 1] = 85;
            notas[1, 2] = 75;

            // Matrizes também podem ser declarado diretamente sem new

            string[,] nomes = 
            {
                { "Jefferson", "Rafaela" },
                { "Ronaldinho", "Sarinha" },
                { "Sandrinha", "Luluca" }
            };

            Console.WriteLine(nomes[0,1]);
            #endregion

            Console.ReadKey();
        }
    }
}
