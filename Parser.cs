using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    public static class Parser
    {
        public const string Inputaddress = "..\\..\\..\\addresses.csv";
        public const string OutputFile = "..\\..\\..\\AddressOutput.txt";
        public static IEnumerable<Utente> Read()
        {
            using var input = File.OpenText(Inputaddress);
            var utenti = new List<Utente>();

            input.ReadLine();
            
            while (true)
            {
                string? line = input.ReadLine();
                if (line is null) return utenti;
                var chunks = line.Split(',')!;

                if (chunks.Length == 6)
                {

                    var nome = chunks[0];
                    var cognome = chunks[1];
                    var via = chunks[2];
                    var città = chunks[3];
                    var provincia = chunks[4];
                    var zip = chunks[5];


                var utente = new Utente(nome, cognome, via, città, provincia, zip);
                utenti.Add(utente);
                }

            }

        }

        public static void Write(IEnumerable<Utente> utenti)
        {
            using var output = File.CreateText(OutputFile);
            output.WriteLine("Lista utenti:");

            foreach (var elem in utenti)
            {
                output.WriteLine();
                output.WriteLine("------ Utente ------");
                output.WriteLine($"Nome: {elem.Nome}");
                output.WriteLine($"Cognome: {elem.Surname}");
                output.WriteLine($"via: {elem.Street}");
                output.WriteLine($"Città:   {elem.City}");
                output.WriteLine($"Provincia:   {elem.Province}");
                output.WriteLine($"zip:   {elem.ZIP}");
                output.WriteLine("-------------------");
            }
        }
    }
}
