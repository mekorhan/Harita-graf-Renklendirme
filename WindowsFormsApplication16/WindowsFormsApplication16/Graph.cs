using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace WindowsFormsApplication16

{
    public class Graph
    {

        public Vertex[] adjlists;

        public Graph()
        {

            string dosya_yolu = @"s.txt";

            FileStream fs = new FileStream(dosya_yolu, FileMode.Open);
            
            StreamReader sw = new StreamReader(fs);
            
            Scanner sc = new Scanner(sw.ReadToEnd());
            fs.Close();
            adjlists = new Vertex[sc.nextInt()];



            for (int v = 0; v < adjlists.Length; v++)
            {

                adjlists[v] = new Vertex(sc.next(), null, false, 0, 0);


            }


            while (sc.hasNext())
            {
                int v1 = indexForName(sc.next());
                int v2 = indexForName(sc.next());



                adjlists[v1].adjlist = new Neighbor(v2, adjlists[v1].adjlist);
                adjlists[v2].adjlist = new Neighbor(v1, adjlists[v2].adjlist);
            }
            
        }

        int indexForName(string name)
        {

            for (int v = 0; v < adjlists.Length; v++)
            {

                if (adjlists[v].name.Equals(name))
                    return v;
            }
            return -1;
        }

        public void print()
        {

            Console.WriteLine();
            int x = 0;
            for (int v = 0; v < adjlists.Length; v++)
            {

                Console.Write(adjlists[v].name);

                for (Neighbor nbr = adjlists[v].adjlist; nbr != null; nbr = nbr.next)
                {

                    Console.Write(" --> " + adjlists[nbr.vertexNum].name);

                    x++;
                }


                Console.WriteLine("\n" + x);
                x = 0;

            }



        }

        public Boolean komsulukAra(Vertex[] aList, Vertex[] adjlists, int v, Neighbor nbrN)
        {



            for (Neighbor nbra = aList[v].adjlist; nbra != null; nbra = nbra.next)
            {
                // Console.WriteLine(" -----------------" + adjlists[nbra.vertexNum].name + adjlists[nbrN.vertexNum].name);
                if (adjlists[nbra.vertexNum].name == adjlists[nbrN.vertexNum].name)
                {

                    return true;

                }

            }

            return false;

        }

        public Boolean komsudaAra(Vertex[] adjlists, Neighbor nbrN, int colour)
        {



            for (Neighbor nbra = adjlists[nbrN.vertexNum].adjlist; nbra != null; nbra = nbra.next)
            {
                //Console.WriteLine(" **** " + adjlists[nbra.vertexNum].name +" colour is " + adjlists[nbra.vertexNum].colour +" "+ adjlists[nbrN.vertexNum].name +" colour is " + adjlists[nbrN.vertexNum].colour );

                if (adjlists[nbra.vertexNum].colour == adjlists[nbrN.vertexNum].colour + colour && adjlists[nbra.vertexNum].colour != 0)
                {

                    return false;

                }

            }

            return true;

        }

        public Boolean besVeYukarsıİçin(Vertex[] adjlists, Neighbor nbrN, int colour)
        {



            for (Neighbor nbra = adjlists[nbrN.vertexNum].adjlist; nbra != null; nbra = nbra.next)
            {
                //Console.WriteLine(" **** " + adjlists[nbra.vertexNum].name + " colour is " + adjlists[nbra.vertexNum].colour + " " + adjlists[nbrN.vertexNum].name + " colour is " + adjlists[nbrN.vertexNum].colour);

                if (adjlists[nbra.vertexNum].colour == adjlists[nbrN.vertexNum].colour + colour && adjlists[nbra.vertexNum].colour != 0)
                {

                    return false;

                }

            }

            return true;

        }


        public int buyukKucuk(Vertex[] adjlists, Neighbor nbrN)
        {



            for (int i = 1; i <= 5; i++)
            {

                Neighbor nbra = adjlists[nbrN.vertexNum].adjlist;


                while (nbra != null)
                {


                    if (adjlists[nbra.vertexNum].colour == i)
                    {

                        break;

                    }

                    nbra = nbra.next;

                    if (nbra == null)
                    {

                        return i;

                    }

                }


            }

            return -1;

        }




        public void paintingProcess()
        {


            Vertex[] aList = new Vertex[adjlists.Length];

            for (int v = 0; v < adjlists.Length; v++)
            {
                int count = 0;
                for (Neighbor nbr = adjlists[v].adjlist; nbr != null; nbr = nbr.next)
                {
                    count += 1;
                }

                adjlists[v].nbrNumber = count;

                aList[v] = adjlists[v];
                

            }

            for (int i = 0; i < aList.Length - 1; i++)
            {
                for (int j = 1; j < aList.Length - i; j++)
                {

                    if (aList[j].nbrNumber < aList[j - 1].nbrNumber)
                    {
                        Vertex gecici = aList[j - 1];
                        aList[j - 1] = aList[j];
                        aList[j] = gecici;
                    }
                }


            }

            for (int i = aList.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(aList[i].name);

            }



            int colour = 0;

            for (int v = aList.Length - 1; v >= 0; v--)
            {

                Console.WriteLine(".....");

                if (aList[v].colour != 0)
                {


                }
                else
                {


                    colour++;

                    aList[v].colour = colour;

                    Console.WriteLine("En Büyük = " + aList[v].name);

                    for (Neighbor nbr = aList[v].adjlist; nbr != null; nbr = nbr.next)
                    {

                        Console.WriteLine("\n" + adjlists[nbr.vertexNum].name);

                        for (Neighbor nbrN = adjlists[nbr.vertexNum].adjlist; nbrN != null; nbrN = nbrN.next)
                        {

                            if (aList[v].colour >= 5)
                            {

                                aList[v].colour = buyukKucuk(adjlists, nbrN);

                            }

                            Console.WriteLine("\t" + adjlists[nbrN.vertexNum].name);



                            if (adjlists[nbrN.vertexNum].colour == 0 && komsulukAra(aList, adjlists, v, nbrN) == false && komsudaAra(adjlists, nbrN, colour) == true)
                            {

                                adjlists[nbrN.vertexNum].colour = aList[v].colour;

                                Console.WriteLine("\t" + "-" + adjlists[nbrN.vertexNum].name);
                            }


                        }

                    }
                }



            }

            for (int v = 0; v < adjlists.Length; v++)
            {

                Console.WriteLine(adjlists[v].name + "====" + adjlists[v].colour);

            }
        }
    }
}
