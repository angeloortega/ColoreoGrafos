using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoreoGrafos.Model
{
    public class Grafo
    {
        public List<Nodo> Vertices { get; }
        public int Size => Vertices.Count;
        public Grafo(int tamaño)
        {
            Vertices = new List<Nodo>(10) ;
        }
      

        public void AddPair(Nodo first, Nodo second)
        {
            AddToList(first);
            AddToList(second);
            AddNeighbors(first, second);
        }


        public void AddToList(Nodo vertex)
        {
            if (!Vertices.Contains(vertex))
            {
                Vertices.Add(vertex);
            }
        }

        private void AddNeighbors(Nodo first, Nodo second)
        {
            AddNeighbor(first, second);
            AddNeighbor(second, first);
        }

        private void AddNeighbor(Nodo first, Nodo second)
        {
            if (!first.Neighbors.Contains(second))
            {
                first.AddEdge(second);
            }
        }

        public Nodo getNodo(string id)
        {
            foreach (var vertex in Vertices)
            {
                if (vertex.ID.Equals(id))
                {
                    return vertex;
                }
            }
            return null; 
        }

    }
}
