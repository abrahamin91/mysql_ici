using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoBarajas
{
    class Parametros
    {
        private string nom;
        private string valor;

        public string Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public Parametros(string n, string v)
        {
            Nom = n;
            Valor = v;
        }

    }
}
