using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace Projeto_11_ano
{
    public class GestDados
    {

        public string NProcesso;
        public string nProcesso
        {
            get { return NProcesso; }
            set
            {
                if (IsValidtxt_Processo(value))
                    NProcesso = value;
                else
                    NProcesso = "";
            }
        }

        public string Nome;
        public string nome
        {
            get { return Nome; }
            set
            {
                if (IsValidtextNome(value))
                    Nome = value;
                else
                    Nome = "(Sem_Nome)";
            }
        }

        public string Ano;
        public string ano
        {
            get { return Ano; }
            set
            {
                if (IsValidAnoEscolar(value))
                    TelefoneEE = value;
                else
                    TelefoneEE = "";
            }
        }

        public string Turma;
        public string turma
        {
            get { return Turma; }
            set
            {
                if (IsValidturma(value))
                    Turma = value;
                else
                    Turma = "";
            }
        }
        public DateTime DataNasc { get; set; }

        public string NomeEE;
        public string nomeEE
        {
            get { return NomeEE; }
            set
            {
                if (IsValidtextEE(value))
                    NomeEE = value;
                else
                {
                    NomeEE = "(sem_NomeEE)";
                }
            }

        }
        public string TelefoneEE;
        public string telefoneEE
        {
            get { return TelefoneEE; }
            set
            {
                if (IsValidTelefoneEE(value))
                    TelefoneEE = value;
                else
                    TelefoneEE = "";
            }
        }



        public bool Autorizacao { get; set; }
        public int idade { get { return ((DateTime.Now.Year) - DataNasc.Year); } }
        public bool NaEscola { get; set; }


        public GestDados(string _NProcesso, string _Nome, string _ano, string _turma, DateTime _DataNasc, string _NomeEE, string _TelefoneEE, bool _Autorizacao)
        {
            NProcesso = _NProcesso;
            Nome = _Nome;
            Ano = _ano;
            Turma = _turma;
            DataNasc = _DataNasc;
            NomeEE = _NomeEE;
            TelefoneEE = _TelefoneEE;
            Autorizacao = _Autorizacao;

        }
        public static bool IsValidTelefoneEE(string TelefoneEE)
        {
            string pattern = @"^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\s[0-9]*$";

            return Regex.IsMatch(TelefoneEE, pattern);
        }


        public static bool IsvalidNomeEE(string NomeEE)
        {
            bool valido = true;
            if (NomeEE.Length < 7 || NomeEE.Length > 150)
                valido = false;

            if (NomeEE.Trim().IndexOf(" ") < 0)
                valido = false;

            return valido;
        }

        public static bool IsValidtextEE(string NomeEE)
        {
            bool valido = true;
            if (NomeEE.Length < 7 || NomeEE.Length > 150)
                valido = false;

            if (NomeEE.Trim().IndexOf(" ") < 0)
                valido = false;

            return valido;
        }
        public static bool IsValidtxt_Processo(string NProcesso)
        {
            string pattern = @"^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\s[0-9]*$";

            return Regex.IsMatch(NProcesso, pattern);
        }
        public static bool IsValidtextNome(string Nome)
        {
            bool valido = true;
            if (Nome.Length < 7 || Nome.Length > 150)
                valido = false;

            if (Nome.Trim().IndexOf(" ") < 0)
                valido = false;

            return valido;
        }

        public static bool IsValidAnoEscolar(string Ano)
        {
            string pattern = @"^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\s[0-9]*$";

            return Regex.IsMatch(Ano, pattern);
        }
        public static bool IsValidturma(string Turma)
        {
            bool valido = true;
            if (Turma.Length < 2 || Turma.Length > 0)
                valido = false;

            if (Turma.Trim().IndexOf(" ") < 0)
                valido = false;

            return valido;
        }



        
      
        
    }
}
















