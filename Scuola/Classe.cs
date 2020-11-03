using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoScuola
{
    public class Classe
    {
        private int anno;
        private string sezione;
        List<Studente> studenti = new List<Studente>();

        public Classe(int anno, string sezione)
        {
            this.anno = anno;
            this.sezione = sezione;
        }

        public string GetNome()
        {
            return anno.ToString() + sezione;
        }

        public List<Studente> GetStudenti()
        {
            return studenti;
        }

        public void AddStudente(Studente studente)
        {
            studenti.Add(studente);
        }

        public Votazione TrovaVotoMassimo()
        {
            double max = -1;
            int c = 0;
            for (int i = 0; i < studenti.Count; i++)
            {
                Votazione voto = studenti[i].TrovaVotoMassimo();
                if (voto.GetVotoDouble() > max)
                {
                    max = voto.GetVotoDouble();
                    c = i;
                }
            }
            return studenti[c].TrovaVotoMassimo();
        }
        public Votazione TrovaVotoMinimo()
        {
            double min = 11;
            int c = 0;
            for (int i = 0; i < studenti.Count; i++)
            {
                Votazione voto = studenti[i].TrovaVotoMinimo();
                if (voto.GetVotoDouble() < min)
                {
                    min = voto.GetVotoDouble();
                    c = i;
                }
            }
            return studenti[c].TrovaVotoMinimo();
        }
    }
    

}
