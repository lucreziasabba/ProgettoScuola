using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoScuola
{
    public class Materia
    {
        private string nome;

        public Materia(string nome)
        {
            this.nome = nome;
        }

        public string GetNome()
        {
            return nome;
        }
    }
}
