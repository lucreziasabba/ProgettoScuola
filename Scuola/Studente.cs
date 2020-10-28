using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoScuola
{
    public class Studente
    {
        private string nome;
        private string cognome;
        private DateTime dataDiNascita;
        List<Votazione> voti = new List<Votazione>();

        public Studente(string nome, string cognome)
        {
            this.nome = nome;
            this.cognome = cognome;
        }

        internal void AddVoto(Votazione votazione)
        {
            throw new NotImplementedException();
        }

        public string GetNome()
        {
            return nome;
        }

        public string GetCognome()
        {
            return cognome;
        }

        public DateTime GetDataDiNascita()
        {
            return dataDiNascita;
        }
        public void SetDataDiNascita(DateTime data)
        {
            dataDiNascita = data;
        }

        public List<Votazione> GetVoti()
        {
            return voti;
        }

        public void AddVoto(Votazione voto)
        {
            voti.Add(voto);
        }
        public Votazione TrovaVotoMassimo()
        {
            int c = 0;
            double massimo = -1;
            for (int i = 0; i < voti.Count; i++)
            {
                if (voti[i].GetVoto() > massimo)
                    c = i;
            }
            return voti[c].GetVoto();
        }
    }
}
