using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace Projeto_11_ano
{
      static class Escola
    {
        
        public static BindingList<GestDados> Alunos = new BindingList<GestDados>(); 
       
        //public static string appVer = "v2.0 Beta";
        //public static string appNProcesso = "ControloEscolar";

        static Escola()
        {
            Alunos.Add(new GestDados("41490", "Miguel", "11", "H",new DateTime(2004,12,21),"Maria", "96457567", true));
            Alunos.Add(new GestDados("12345", "Lucas", "11", "H",new DateTime(2003,4,23),"João", "922190607", false));
            Alunos.Add(new GestDados("23608", "Primo", "1", "E",new DateTime(2005,7,5),"Maria", "904359510", true));
            Alunos.Add(new GestDados("23456", "João", "12", "Q",new DateTime(2021, 8, 6), "Luis", "651805479", false));
            Alunos.Add(new GestDados("23456", "Maria","13","w",new DateTime(2000,8,17),"Filipe", "67653223", true ));
            Alunos.Add(new GestDados("22169", "Mary", "12", "M", new DateTime(2004,6,12), "Mario", "67653223", false));
            Alunos.Add(new GestDados("22169", "Asdrubol", "3", "A", new DateTime(2005, 3, 13), "Antnieta", " 987654321", true));


        }
        public static void CarregarDados(string nomeFicheiro)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = File.OpenRead(nomeFicheiro))
            {
                Alunos = (BindingList<GestDados>)formatter.Deserialize(stream);
            }
        }

        public static void GuardarDados(string nomeFicheiro)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = File.Create(nomeFicheiro))
            {
                formatter.Serialize(stream, Alunos);
            }
        }




    }



}
  