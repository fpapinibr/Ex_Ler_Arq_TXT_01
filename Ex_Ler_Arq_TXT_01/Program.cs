using System;
using System.IO;

namespace Ex_Ler_Arq_TXT_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line;
            try
            {
                StreamReader sr = new StreamReader("D:\\Test.txt");//Instancia um Objeto StreamReader (Classe de Manipulação de Leitura de Arquivos)
                line = sr.ReadLine(); //Faz a Leitura de uma linha do arquivo e atribui a string line
                while (line != null)// Laço de Repetição para fazer a leitura de linhas do arquivo até o (EOF - Fim do Arquivo)
                {
                    Console.WriteLine(line);//Imprime o retorno do arquivo no Console
                    line = sr.ReadLine(); //Faz a Leitura de linha do arquivo e atribui a string line
                }
                sr.Close();//Fecha o Arquivo
                Console.WriteLine("Fim da Leitura do Arquivo");
                Console.ReadLine();
            }
            catch (Exception e) // Tratamento de erro na abertura do arquivo
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executando o Bloco de Comando - Sem Erros");
            }
        }
    }
}
