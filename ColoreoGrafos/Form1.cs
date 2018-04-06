using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ColoreoGrafos.Model;
namespace ColoreoGrafos
{
    public partial class Form1 : Form
    {
        Grafo grafo;
        public Form1()
        {
            InitializeComponent();
            grafo = new Grafo(10);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            // Dibuja el grafo actual en pantalla
            int radio;
            Graphics g = e.Graphics;
            foreach (Nodo vertice in grafo.Vertices) {

                foreach (Nodo vecino in vertice.Neighbors) {
                    Pen myPen = new Pen(Color.Black);
                    myPen.Width = 4;
                    radio = vecino.radio / 2;
                    g.DrawLine(myPen, vertice.xPos + radio, vertice.yPos + radio, vecino.xPos + radio, vecino.yPos + radio);
                    g.FillEllipse(new SolidBrush(vecino.color), vecino.xPos, vecino.yPos, vecino.radio, vecino.radio);
                    g.DrawEllipse(new Pen(Color.Black), vecino.xPos, vecino.yPos, vecino.radio, vecino.radio);
                }
                g.FillEllipse(new SolidBrush(vertice.color), vertice.xPos, vertice.yPos, vertice.radio, vertice.radio);
                g.DrawEllipse(new Pen(Color.Black), vertice.xPos, vertice.yPos, vertice.radio, vertice.radio);

            }

        }

        private void AgregarNodo_Click(object sender, EventArgs e)
        {
            int posX, posy;
            string id = IDEntry.Text;
            Int32.TryParse(xEntry.Text, out posX);
            Int32.TryParse(yEntry.Text, out posy);
            Nodo nodo = new Nodo(Color.White, posX, posy, id);
            if (grafo.getNodo(IDEntry.Text) != null)
            {
                MessageBox.Show("Ya existe un nodo con este ID!", "Error", MessageBoxButtons.OK);
            }
            else {
                grafo.AddToList(nodo);
                destinoCombo.Items.Add(nodo.ID);
                origenCombo.Items.Add(nodo.ID);
            }
            
            Refresh(); // Pintar nodo en pantalla
        }

        private void AgregarArista_Click(object sender, EventArgs e)
        {
            grafo.AddPair(grafo.getNodo(origenCombo.Text), grafo.getNodo(destinoCombo.Text)); //Arista bidireccional
            this.Refresh();
        }
        private bool is_safe(Nodo n, Color c) {
            foreach (Nodo neighbor in n.Neighbors) {
                if (c.Equals(neighbor.color)) {
                    return false;
                }
            }
            return true;
        }
        private bool graphColoringUtil(List<Color> colors,  int vertexNumb) {
            if (grafo.Vertices.Count == vertexNumb) {
                return true; //Se colorearon todos lo vértices exitosamente
            }
            Nodo currentVertex = grafo.Vertices[vertexNumb];
            for (int c = 0; c < colors.Count; c++) {
                if (is_safe(currentVertex, colors[c])) { // Determina si a un vertice en particular se le puede asignar un color
                    currentVertex.color = colors[c];
                    if (graphColoringUtil(colors, vertexNumb + 1))
                    {
                        return true;
                    }
                }
                currentVertex.color = Color.White; // De no poder colorearse se retorna al color por defecto
            }
            return false;
        }

        private void SolucionarGrafo_Click(object sender, EventArgs e)
        {
            int cantColores;
            List<Color> colors = new List<Color>();
            Int32.TryParse(cantColoresEntry.Text, out cantColores);
            for (int i = 1; i < cantColores+1; i++) {
                colors.Add(Color.FromArgb(255,(( i * 100 ) % 256), ((i * 50) % 256), ((i * 150) % 256)));
            }
            bool coloreado = graphColoringUtil(colors, 0);
            if (coloreado)
            {
                MessageBox.Show("Se logró colorear el grafo con " + colors.Count + " colores diferentes", "Éxito", MessageBoxButtons.OK);
            }
            else {
                MessageBox.Show("No Se logró colorear el grafo con " + colors.Count + " colores diferentes", "Fracaso", MessageBoxButtons.OK);
                foreach(Nodo node in grafo.Vertices) {
                    node.color = Color.White;
                }
            }
            this.Refresh();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Canvas_Click(object sender, EventArgs e)
        {
            Point point = Canvas.PointToClient(Cursor.Position);
            xEntry.Text = (point.X) + "";
            yEntry.Text = (point.Y) + "";
        }
    }
}
