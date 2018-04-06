using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoreoGrafos.Model
{
    public class Nodo
    {

        public Color color { get; set; }

        public List<Nodo> Neighbors { get; }

        public int xPos;

        public int yPos;

        public string ID;

        public int radio;

        public int NeighborCount => Neighbors.Count;

        public Nodo(Color pColor, int posX, int posY, string ID)
        {
            xPos = posX;
            yPos = posY;
            color = pColor;
            this.ID = ID;
            radio = 30;
            Neighbors = new List<Nodo>();
        }

        public void AddEdge(Nodo vertex)
        {
            Neighbors.Add(vertex);
        }

        public void AddEdges(params Nodo[] newNeighbors)
        {
            Neighbors.AddRange(newNeighbors);
        }

        public void RemoveEdge(Nodo vertex)
        {
            Neighbors.Remove(vertex);
        }

        public override string ToString()
        {
            return Neighbors.Aggregate(new StringBuilder($"{xPos}{yPos}: "), (sb, n) => sb.Append($"{n.xPos}{n.yPos}")).ToString();

        }

    }
}
