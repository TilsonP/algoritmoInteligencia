using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace algoritmoInteligencia
{

    /*class Mapa
    {
        private int fila = 0;
        private int columna = 0;
        private int numfila = 10;
        private int numcolumna = 10;
        private int anchoBloque = 40;
        private int altoBloque = 40;

        public void paint(Panel panel)
        {
            int[,] mapa = obtenermapa();
            for (int fila = 0; fila < numfila; fila++)
            {
                for (int columna = 0; columna < numcolumna; columna++)
                {
                    if (mapa[fila, columna] == 1)
                    {
                        RectangleF rect = new RectangleF(0, 0, 40, 40);
                        SolidBrush blueBrush = new SolidBrush(Color.Blue);
                        Pen lapiz = new Pen(Color.Black, 3);
                        Rectangle Rect = new Rectangle(0, 0, 40, 40);

                        panel.FillRectangle(blueBrush, rect);
                        panel.DrawRectangle(lapiz, Rect);

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
                           {1,0,0,1,1,0,0,0,1,0 },
                           {0,0,0,0,1,0,1,0,0,0 },
                           {0,1,0,0,1,0,1,1,0,0 },
                           {0,0,0,0,0,0,0,0,0,0 },
                           {0,0,1,1,1,0,0,1,1,0 }};
            return map;
        }
    }*/
}
