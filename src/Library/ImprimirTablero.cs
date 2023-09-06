using System;
using System.Text;
using System.Threading;

namespace PII_Game_Of_Life
{
    public class ImprimirTablero
    {
        public static Board ImpTablero(Board tablerito)
        {
        bool[,] b = tablerito.Tablero; //variable que representa el tablero
        int width = b.GetLength(0); //ancho
        int height = b.GetLength(1); //alto
        
        Console.Clear();
        StringBuilder s = new StringBuilder();
        for (int y = 0; y<height;y++)
        {
            for (int x = 0; x<width; x++)
            {
                if(b[x,y])
                {
                    s.Append("|X|");
                }
                else
                {
                    s.Append("___");
                }
            }
            s.Append("\n");
        }
        Console.WriteLine(s.ToString());
        //=================================================
        tablerito = Logica.LogicaJuego(tablerito);

        //=================================================
        Thread.Sleep(300);
        return tablerito;
        }
    }
}