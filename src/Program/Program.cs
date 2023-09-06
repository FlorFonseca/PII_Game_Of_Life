using System;

namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board1 = LeerArchivo.TableroNuevo();
            while (true)
            {
                board1 = ImprimirTablero.ImpTablero(board1);
            }
        }
    }
}