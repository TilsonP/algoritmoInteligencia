using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritmoInteligencia
{
    public class Individuo
    {
        public List<int> movimientos { get; set; }
        public int actitud { get; set; }

        public Individuo()
        {
            this.movimientos = new List<int>();
        }
    }
}
