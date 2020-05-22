using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace algoritmoInteligencia
{
    public partial class Form1 : Form
    {
        private int fila = 0;
        private int columna = 0;
        private int numfila = 10;
        private int numcolumna = 10;
        private int anchoBloque = 40;
        private int altoBloque = 40;
        public List<Individuo> Poblacion;
        public Individuo individuo;

        public Form1()
        {
            InitializeComponent();
        }

        public void paint(Graphics grafico)
        {
            int[,] mapa = obtenermapa();
            for (int fila = 0; fila < numfila; fila++)
            {
                for (int columna = 0; columna < numcolumna; columna++)
                {
                    if (mapa[fila, columna] == 1)
                    {
                        RectangleF rect = new RectangleF(columna * 50, fila * 50, 50, 50);
                        SolidBrush blueBrush = new SolidBrush(Color.Black);
                        Pen lapiz = new Pen(Color.Black, 3);
                        Rectangle Rect = new Rectangle(columna * 50, fila * 50, 50, 50);

                        grafico.FillRectangle(blueBrush, rect);
                        grafico.DrawRectangle(lapiz, Rect);

                    }
                    else if (mapa[fila, columna] == 0)
                    {
                        RectangleF rect = new RectangleF(columna * 50, fila * 50, 50, 50);
                        SolidBrush blueBrush = new SolidBrush(Color.White);
                        Pen lapiz = new Pen(Color.Black, 3);
                        Rectangle Rect = new Rectangle(columna * 50, fila * 50, 50, 50);

                        grafico.FillRectangle(blueBrush, rect);
                        grafico.DrawRectangle(lapiz, Rect);
                    }
                    else
                    {
                        RectangleF rect = new RectangleF(columna * 50, fila * 50, 50, 50);
                        SolidBrush blueBrush = new SolidBrush(Color.Green);
                        Pen lapiz = new Pen(Color.Black, 3);
                        Rectangle Rect = new Rectangle(columna * 50, fila * 50, 50, 50);

                        grafico.FillRectangle(blueBrush, rect);
                        grafico.DrawRectangle(lapiz, Rect);
                    }

                }
            }
        }

        public int[,] obtenermapa()
        {
            int[,] map = { {0,0,1,0,0,1,0,0,0,0 },
                           {0,0,0,0,0,1,0,1,1,0 },
                           {0,1,1,1,0,0,0,0,1,0 },
                           {0,0,1,0,0,1,1,0,1,0 },
                           {0,0,0,0,0,0,1,0,0,0 },
                           {1,0,0,1,2,0,0,0,1,0 },
                           {0,0,0,1,1,0,1,0,0,0 },
                           {0,1,0,0,1,0,1,1,0,1 },
                           {0,0,0,0,0,0,0,0,0,0 },
                           {0,0,1,1,1,0,0,1,1,0 }};
            return map;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            paint(e.Graphics);
            GenerarPoblacion(e.Graphics);
        }

        public void GenerarPoblacion(Graphics grafico)
        {
            Random random = new Random();
            int[,] mapa = obtenermapa();

            for (int i = 0; i < 19; i++)
            {
                if (i<20)
                {
                    for (int j = 0; j < 19; j++)
                    {
                        individuo = new Individuo();

                        RectangleF rect = new RectangleF(0 * 50+10, 0 * 50+10, 30, 30);
                        SolidBrush blueBrush = new SolidBrush(Color.Blue);

                        grafico.FillRectangle(blueBrush, rect);

                        int Paso = random.Next(8);

                        int colum = 0;
                        int fila = 0;

                        if (Paso == 0 && colum !=0 && j > 0 && mapa[colum - 1, fila] == 0)
                        {
                            colum -= 1;

                            RectangleF rect1 = new RectangleF(colum * 50 + 10, fila * 50 + 10, 30, 30);
                            SolidBrush blueBrush1 = new SolidBrush(Color.Blue);

                            grafico.FillRectangle(blueBrush1, rect1);

                            individuo.movimientos.Add(Paso);
                            individuo.actitud =+ 1;
                        }
                        else if (Paso == 1 && colum != 10 && mapa[colum + 1, fila] == 0)
                        {
                            colum += 1;

                            RectangleF rect1 = new RectangleF(colum * 50 + 10, fila * 50 + 10, 30, 30);
                            SolidBrush blueBrush1 = new SolidBrush(Color.Blue);

                            grafico.FillRectangle(blueBrush1, rect1);

                            individuo.movimientos.Add(Paso);
                            individuo.actitud = +1;
                        }
                        else if (Paso == 2 && fila != 0 && mapa[colum, fila-1] == 0 && j > 0)
                        {
                            fila -= 1;

                            RectangleF rect1 = new RectangleF(colum * 50 + 10, fila * 50 + 10, 30, 30);
                            SolidBrush blueBrush1 = new SolidBrush(Color.Blue);

                            grafico.FillRectangle(blueBrush1, rect1);

                            individuo.movimientos.Add(Paso);
                            individuo.actitud = +1;
                        }
                        else if (Paso == 3 && fila != 10 && mapa[colum, fila + 1] == 0)
                        {
                            fila += 1;

                            RectangleF rect1 = new RectangleF(colum * 50 + 10, fila * 50 + 10, 30, 30);
                            SolidBrush blueBrush1 = new SolidBrush(Color.Blue);

                            grafico.FillRectangle(blueBrush1, rect1);

                            individuo.movimientos.Add(Paso);
                            individuo.actitud = +1;
                        }
                        else if (Paso == 4 && colum != 0 && fila != 0 && mapa[colum - 1, fila - 1] == 0)
                        {
                            fila -= 1;
                            colum -= 1;

                            RectangleF rect1 = new RectangleF(colum * 50 + 10, fila * 50 + 10, 30, 30);
                            SolidBrush blueBrush1 = new SolidBrush(Color.Blue);

                            grafico.FillRectangle(blueBrush1, rect1);

                            individuo.movimientos.Add(Paso);
                            individuo.actitud = +1;
                        }
                        else if (Paso == 5 && colum != 0 && fila != 10 && mapa[colum - 1, fila + 1] == 0)
                        {
                            fila += 1;
                            colum -= 1;

                            RectangleF rect1 = new RectangleF(colum * 50 + 10, fila * 50 + 10, 30, 30);
                            SolidBrush blueBrush1 = new SolidBrush(Color.Blue);

                            grafico.FillRectangle(blueBrush1, rect1);

                            individuo.movimientos.Add(Paso);
                            individuo.actitud = +1;
                        }
                        else if (Paso == 6 && colum != 10 && fila !=10 && mapa[colum + 1, fila + 1] == 0)
                        {
                            fila += 1;
                            colum += 1;

                            RectangleF rect1 = new RectangleF(colum * 50 + 10, fila * 50 + 10, 30, 30);
                            SolidBrush blueBrush1 = new SolidBrush(Color.Blue);

                            grafico.FillRectangle(blueBrush1, rect1);

                            individuo.movimientos.Add(6);
                            individuo.actitud = +1;
                        }
                        else if (Paso == 7 && colum != 10 && fila != 0 && mapa[colum + 1, fila - 1] == 0)
                        {
                            fila -= 1;
                            colum += 1;

                            RectangleF rect1 = new RectangleF(colum * 50 + 10, fila * 50 + 10, 30, 30);
                            SolidBrush blueBrush1 = new SolidBrush(Color.Blue);

                            grafico.FillRectangle(blueBrush1, rect1);

                            individuo.movimientos.Add(Paso);
                            individuo.actitud = +1;
                        }
                        else if (Paso == 8 && mapa[colum, fila] == 0)
                        {
                            RectangleF rect1 = new RectangleF(colum * 50 + 10, fila * 50 + 10, 30, 30);
                            SolidBrush blueBrush1 = new SolidBrush(Color.Blue);

                            grafico.FillRectangle(blueBrush1, rect1);

                            individuo.movimientos.Add(Paso);
                            individuo.actitud = +1;
                        }
                        else if (Paso == 0 && colum != 0 && j > 0 && mapa[colum - 1, fila] == 1)
                        {
                            RectangleF rect1 = new RectangleF(colum * 50 + 10, fila * 50 + 10, 30, 30);
                            SolidBrush blueBrush1 = new SolidBrush(Color.Red);

                            grafico.FillRectangle(blueBrush1, rect1);
                            j = 20;
                        }
                        else if (Paso == 1 && colum != 10 && mapa[colum + 1, fila] == 1)
                        {
                            RectangleF rect1 = new RectangleF(colum * 50 + 10, fila * 50 + 10, 30, 30);
                            SolidBrush blueBrush1 = new SolidBrush(Color.Red);

                            grafico.FillRectangle(blueBrush1, rect1);
                            j = 20;
                        }
                        else if (Paso == 2 && fila != 0 && mapa[colum, fila - 1] == 1)
                        {
                            RectangleF rect1 = new RectangleF(colum * 50 + 10, fila * 50 + 10, 30, 30);
                            SolidBrush blueBrush1 = new SolidBrush(Color.Red);

                            grafico.FillRectangle(blueBrush1, rect1);
                            j = 20;
                        }
                        else if (Paso == 3 && fila != 10 && mapa[colum, fila + 1] == 1)
                        {
                            RectangleF rect1 = new RectangleF(colum * 50 + 10, fila * 50 + 10, 30, 30);
                            SolidBrush blueBrush1 = new SolidBrush(Color.Red);

                            grafico.FillRectangle(blueBrush1, rect1);
                            j = 20;
                        }
                        else if (Paso == 4 && colum != 0 && fila != 0 && mapa[colum - 1, fila - 1] == 1)
                        {
                            RectangleF rect1 = new RectangleF(colum * 50 + 10, fila * 50 + 10, 30, 30);
                            SolidBrush blueBrush1 = new SolidBrush(Color.Red);

                            grafico.FillRectangle(blueBrush1, rect1);
                            j = 20;
                        }
                        else if (Paso == 5 && colum != 0 && fila != 10 && mapa[colum - 1, fila + 1] == 1)
                        {
                            RectangleF rect1 = new RectangleF(colum * 50 + 10, fila * 50 + 10, 30, 30);
                            SolidBrush blueBrush1 = new SolidBrush(Color.Red);

                            grafico.FillRectangle(blueBrush1, rect1);
                            j = 20;
                        }
                        else if (Paso == 6 && colum != 10 && fila != 10 && mapa[colum + 1, fila + 1] == 1)
                        {
                            RectangleF rect1 = new RectangleF(colum * 50 + 10, fila * 50 + 10, 30, 30);
                            SolidBrush blueBrush1 = new SolidBrush(Color.Red);

                            grafico.FillRectangle(blueBrush1, rect1);
                            j = 20;
                        }
                        else if (Paso == 7 && colum != 10 && fila != 0 && mapa[colum + 1, fila - 1] == 1)
                        {
                            RectangleF rect1 = new RectangleF(colum * 50 + 10, fila * 50 + 10, 30, 30);
                            SolidBrush blueBrush1 = new SolidBrush(Color.Red);

                            grafico.FillRectangle(blueBrush1, rect1);
                            j = 20;
                        }
                        else
                        {
                            RectangleF rect1 = new RectangleF(colum * 50 + 10, fila * 50 + 10, 30, 30);
                            SolidBrush blueBrush1 = new SolidBrush(Color.Red);

                            grafico.FillRectangle(blueBrush1, rect1);
                            j = 20;
                        }
                    }
                }
            }
        }
    }
}

