using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memoria
{
    public class MemoriaImp : MemoriaAbs
    {
        public override void mostrar()
        {
            Console.WriteLine("Dir Dato Link");
            Console.WriteLine("*---------------*");
            int dir = 0;
            foreach(NodoM actual in MEM)
            {
                int dato = actual.dato;
                int link = actual.link;
                Console.WriteLine(" | " + dir + "\t| " + dato + "\t| " + link);
                dir++;
            }
        }

        public override void new_espacio(int cantidad)
        {
            int Dir = libre;
            int D = libre;
            for (int i = 1; i < cantidad; i++)
            {
                D = MEM[D].link;
                libre = MEM[D].link;
                MEM[D].link = -1;
            }

        }
    }
}
