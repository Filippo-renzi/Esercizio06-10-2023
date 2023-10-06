namespace idea_soluzione
{
    internal class Program
    {
        enum Materia
        {
            Matematica,
            Reti,
            Informatica,
            Inglese,
            Italiano,
            Storia,
            TPSIT,
            Religione
           
        }

        class Alunno
        {
            public int Matricola { get; }
            public string Cognome { get; }
            public string Nome { get; }
            public DateTime DataDiNascita { get; }

            private double[] voti = new double[Enum.GetValues(typeof(Materia)).Length];

            public Alunno(int matricola, string cognome, string nome, DateTime dataDiNascita)
            {
                Matricola = matricola;
                Cognome = cognome;
                Nome = nome;
                DataDiNascita = dataDiNascita;
            }

            public double this[Materia materia]
            {
                get
                {
                    int materiaIndex = (int)materia;
                    if (materiaIndex < 0 || materiaIndex >= voti.Length)
                    {
                        throw new Exception ("Materia non valida");
                    }

                    return voti[materiaIndex];
                }
                set
                {
                    int materiaIndex = (int)materia;
                    if (materiaIndex < 0 || materiaIndex >= voti.Length)
                    {
                        throw new Exception("Materia non valida");
                    }

                    voti[materiaIndex] = value;
                }
            }
        }


        static void Main()
        {
            // Creazione di un nuovo alunno
            Alunno alunno1 = new Alunno(12345, "Rossi", "Mario", new DateTime(2000, 5, 10));

            // Impostazione dei voti per le materie
            alunno1[Materia.Matematica] = 8.5;
            alunno1[Materia.Reti] = 7.0;
            alunno1[Materia.Informatica] = 9.0;
            alunno1[Materia.Inglese] = 6.7;
            alunno1[Materia.Italiano] = 7.4;
            alunno1[Materia.Storia] = 8.9;
            alunno1[Materia.TPSIT] = 6.3;
            alunno1[Materia.Religione] = 9.9;


            // Accesso ai dati dell'alunno
            Console.WriteLine($"Matricola: {alunno1.Matricola}");
            Console.WriteLine($"Cognome: {alunno1.Cognome}");
            Console.WriteLine($"Nome: {alunno1.Nome}");
            Console.WriteLine($"Data di nascita: {alunno1.DataDiNascita.ToShortDateString()}");

            // Accesso ai voti
            Console.WriteLine($"Voto Matematica: {alunno1[Materia.Matematica]}");
            Console.WriteLine($"Voto Reti: {alunno1[Materia.Reti]}");
            Console.WriteLine($"Voto Informatica: {alunno1[Materia.Informatica]}");
            Console.WriteLine($"Voto Inglese: {alunno1[Materia.Inglese]}");
            Console.WriteLine($"Voto Italiano: {alunno1[Materia.Italiano]}");
            Console.WriteLine($"Voto Storia: {alunno1[Materia.Storia]}");
            Console.WriteLine($"Voto TPSIT: {alunno1[Materia.TPSIT]}");
            Console.WriteLine($"Voto Reliogione: {alunno1[Materia.Religione]}");


        }
        
    }
}