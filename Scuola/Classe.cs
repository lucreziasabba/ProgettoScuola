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

        internal Votazione TrovaVotoMassimo()
        {
            throw new NotImplementedException();
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
                if (voto.GetVoto() > max)
                {
                    max = voto.GetVoto();
                    c = i;
                }
            }
            return studenti[c].TrovaVotoMassimo();
        }
    }
    

}
