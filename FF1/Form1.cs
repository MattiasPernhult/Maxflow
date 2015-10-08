using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FF1
{
    public partial class Form1 : Form
    {
        int leftNodes, rightNodes;
        float x1 = 50.0F, x2 = 200.0F, y = 50.0F;
        int left, right;
        Point[] pointsX;
        int[] pointsY;
        Stack<int> stack = new Stack<int>();
        Graph g;
        Maxflow n;

        public Form1(int leftNodes, int rightNodes)
        {
            InitializeComponent();
            this.leftNodes = leftNodes;
            this.rightNodes = rightNodes;
            g = new Graph(leftNodes, rightNodes);
            n = new Maxflow(g.TotalNodes);
            pointsY = new int[g.TotalNodes];
            this.BackColor = Color.White;
        }

        private void DrawLine()
        {
            Graphics g = CreateGraphics();
            Pen myPen;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            myPen = new Pen(Color.Black, 2);
            g.DrawLine(myPen, new Point((int)x1 + 20, pointsY[left] + 10), new Point((int)x2, pointsY[right] + 10));
        }

        public void DrawMaxLines()
        {
            Graphics g = CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            Pen myPen = new Pen(Color.Orange, 4);
            while (stack.Count != 0)
                g.DrawLine(myPen, new Point((int)x1 + 20, pointsY[stack.Pop()] + 10), new Point((int)x2, pointsY[stack.Pop()] + 10));
            
        }

        private void DrawNodes()
        {
            comboRight.Items.Clear();
            comboLeft.Items.Clear();
            y = 50.0F;
            Graphics g = CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            Font font = new Font("Arial", 16);
            SolidBrush brushLeft = new SolidBrush(Color.Red);
            SolidBrush brushRight = new SolidBrush(Color.Blue);
            StringFormat sf = new StringFormat();
            for (int left = 0; left < leftNodes; left++)
            {
                g.DrawString(left.ToString(), font, brushLeft, x1, y, sf);
                comboLeft.Items.Add(left);
                pointsY[left] = (int)y;
                y += 30.0f;
            }
            y = 50.0F;
            for (int right = leftNodes; right < rightNodes + leftNodes; right++)
            {
                g.DrawString(right.ToString(), font, brushRight, x2, y, sf);
                pointsY[right] = (int)y;
                y += 30.0f;
                comboRight.Items.Add(right);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawNodes();
        }

        private void comboLeft_SelectedIndexChanged(object sender, EventArgs e)
        {
            left = comboLeft.SelectedIndex;
        }

        private void comboRight_SelectedIndexChanged(object sender, EventArgs e)
        {
            right = comboRight.SelectedIndex + leftNodes;
        }

        private void btnConn_Click(object sender, EventArgs e)
        {
            bool success = g.AddEdge(left + 1, right + 1);
            if (success)
                DrawLine();
            else
                MessageBox.Show("Finns redan en koppling mellan dessa två noder");
        }

        private void btnMaximal_Click(object sender, EventArgs e)
        {
            int max = n.FF(g.TheGraph, g.Source, g.Sink);
            stack = n.stack;
            DrawMaxLines();
            MessageBox.Show("Maximala matchningen mellan dessa är: " + max);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            bool success = g.RemoveEdge(left + 1, right + 1);
            if (success)
            {
                Reset();
                DrawAfterRemovedEdge();
            }
            else
                MessageBox.Show("Går inte att ta bort en koppling som inte finns mellan dessa två noder");
        }

        private void DrawAfterRemovedEdge()
        {
            for (int l = 1; l <= leftNodes; l++)
            {
                for (int r = leftNodes + 1; r < g.Sink; r++)
                {
                    if (g.TheGraph[l, r] == 1)
                    {
                        left = l - 1;
                        right = r - 1;
                        DrawLine();
                    }
                }
            }
        }

        private void Reset()
        {
            Graphics gr = CreateGraphics();
            gr.Clear(Color.White);
            DrawNodes();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
            for (int l = 0; l <= leftNodes; l++)
            {
                for (int r = 0; r < g.Sink; r++)
                {
                    g.TheGraph[l, r] = 0;
                }
            }
            g.AddSource();
            g.AddSink();
        }
    }
}
