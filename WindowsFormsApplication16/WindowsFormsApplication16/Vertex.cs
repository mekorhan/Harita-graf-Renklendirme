using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication16
{
    public class Vertex
    {

        public string name;
        public Neighbor adjlist;
        public Boolean sorgu;
        public int nbrNumber;
        public int colour;
        public Vertex(string name, Neighbor neighbors, Boolean sorgu, int nbrNumber, int colour)
        {
            this.name = name;
            this.adjlist = neighbors;
            this.sorgu = sorgu;
            this.nbrNumber = nbrNumber;
            this.colour = colour;

        }


    }
}
