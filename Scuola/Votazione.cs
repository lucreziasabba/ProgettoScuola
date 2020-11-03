using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoScuola
{
    public class Votazione
    {
        private double voto;
        private DateTime data;
        private Materia materia;

        public Votazione(double voto, Studente studente, Materia materia)
        {
            this.voto = voto;
            studente.AddVoto(this);
            this.materia = materia;
        }

        public Votazione GetVoto()
        {
            return this;
        }

        public DateTime GetData()
        {
            return data;
        }

        public Materia GetMateria()
        {
            return materia;
        }

        public bool IsSufficiente()
        {
            if (voto >= 6)
                return true;
            else
                return false;
        }

        public double GetVotoDouble()
        {
            return voto;
        }
    }
}
