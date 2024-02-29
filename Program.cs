using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_11_ano
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Exemplo de criação de arquivo
            string caminhoArquivo = "caminho/do/arquivo.txt";
            string conteudo = "Este é um exemplo de conteúdo a ser escrito no arquivo.";

          

            // Exemplo de leitura de arquivo
            string caminhoArquivo1 = "caminho/do/arquivo.txt";

            if (File.Exists(caminhoArquivo))
            {
                using (StreamReader arquivo = File.OpenText(caminhoArquivo))
                {

                    Console.WriteLine("Conteúdo do arquivo:");
                    Console.WriteLine(arquivo.ReadToEnd());
                }
            }
            else
            {
                Console.WriteLine("O arquivo não existe.");
            }

          

            // Exemplo de escrita de arquivo
            string caminhoArquivo2 = "caminho/do/arquivo.txt";
            string conteudoAdicional = "Este é um conteúdo adicional a ser adicionado no arquivo.";

             

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmPrincipal());
        }
    }
}
