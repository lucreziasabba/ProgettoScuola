using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoScuola
{
    public class Scuola
    {
        private string nome;
        private List<Classe> classi;
        private List<Materia> materie;

        public Scuola(string nome)
        {
            this.nome = nome;
        }

        public string GetNome()
        {
            return nome;
        }

        public Classe CreateClasse(int anno, string sezione)
        {
            Classe classe = new Classe(anno, sezione);
            classi.Add(classe);
            return classe;
        }

        public List<Classe> GetClassi()
        {
            return classi;
        }

        public Materia CreateMateria(string nome)
        {
            Materia materia = new Materia(nome);
            materie.Add(materia);
            return materia;
        }

        public List<Materia> GetMaterie()
        {
            return materie;
        }

        public Votazione TrovaVotoMassimo()
        {
            double max = -1;
            int c = 0;
            for (int i = 0; i < classi.Count; i++)
            {
                Votazione voto = classi[i].TrovaVotoMassimo();
                if (voto.GetVotoDouble() > max)
                {
                    max = voto.GetVotoDouble();
                    c = i;
                }
            }
            return classi[c].TrovaVotoMassimo();
        }
        public Votazione TrovaVotoMinimo()
        {
            double min = 11;
            int c = 0;
            for (int i = 0; i < classi.Count; i++)
            {
                Votazione voto = classi[i].TrovaVotoMinimo();
                if (voto.GetVotoDouble() < min)
                {
                    min = voto.GetVotoDouble();
                    c = i;
                }
            }
            return classi[c].TrovaVotoMinimo();
        }
    }
}
