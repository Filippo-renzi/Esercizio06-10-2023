using System.Runtime.CompilerServices;

namespace Gestione_alunni
{
    internal class Program
    {
        class Alunni
        {
            private int Matricola;
            private string Cognome;
            private string Nome;
            private string Data_Nascita;
            private double[] Media_Voti;

            public Alunni (int matricola, string cognome, string nome, string data_Nascita)
            {
                this.Matricola = matricola;
                this.Cognome = cognome;
                this.Nome = nome;
                this.Data_Nascita = data_Nascita;
                
            }

            public int matricola { get { return this.Matricola; }  }
            public string cognome { get { return this.Cognome; } }
            public string nome { get { return this.nome; } }
            public string nascita { get { return this.Data_Nascita; } }

            public double[] Vettore { set { double[] Media_voti = new double[4]; } }

           public void set_medie()
            {
                Console.Write("inserisci la media di Matematica -> ");
                Media_Voti[(int)Materie.Matematica] = double.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.Write("inserisci la media di Reti -> ");
                Media_Voti[(int)Materie.Reti] = double.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.Write("inserisci la media di Informatica -> ");
                Media_Voti[(int)Materie.Informatica] = double.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.Write("inserisci la media di Inglese -> ");
                Media_Voti[(int)Materie.Inglese] = double.Parse(Console.ReadLine());
                Console.WriteLine();



            }

        }
        public enum Materie
        {
            Matematica = 0,
            Reti,
            Informatica,
            Inglese

        }
        static void Main(string[] args)
        {
            Alunni alA = new Alunni(22944, "Rinaldi", "Luca", "21/03/2023") ;
            alA.Vettore = new double[4] ;
            alA.set_medie();


        }
    }
}