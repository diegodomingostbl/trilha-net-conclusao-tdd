using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Calculadora
{
    public class ClassCalculadora
    {
        private List<string> historico;
        private string data;

        public ClassCalculadora(string data)
        {
            historico = new List<string>(); 
            this.data = data;
        }

        public int Somar(int val1, int val2)
        {
            int result = val1 + val2;
            historico.Insert(0, "Res: " + result + " - data: " + data);
            return result;
        }

        public int Subtrair(int val1, int val2)
        {
            int result = val1 - val2;
            historico.Insert(0, "Res: " + result + " - data: " + data);
            return result;
        }

        public int Multiplicar(int val1, int val2)
        {
            int result = val1 * val2;
            historico.Insert(0, "Res: " + result + " - data: " + data);
            return result;
        }

        public int Dividir(int val1, int val2)
        {
            int result = val1 / val2;
            historico.Insert(0, "Res: " + result + " - data: " + data);
            return result;
        }

        public List<string> Historico()
        {
            historico.RemoveRange(3, historico.Count - 3);
            return historico;
        }
    }
}
