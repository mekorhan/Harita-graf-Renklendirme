using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication16
{
    public class Neighbor
    {


        public int vertexNum;
        public Neighbor next;
        public Neighbor(int vnum, Neighbor nbr)
        {
            this.vertexNum = vnum;
            next = nbr;
        }


    }
}
