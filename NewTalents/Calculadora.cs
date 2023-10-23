using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTalents
{
    public class Calculadora
    {
        private List<string> HistoricoLista;
        private string Data;

        public Calculadora(string Data)
        {
            HistoricoLista = new List<string>();
            this.Data = Data;
        }
        public int Somar(int Valor1, int Valor2)
        {
            int Result = Valor1 + Valor2;

            HistoricoLista.Insert(0, "Result: " + Result + " - " + Data);
            return Result;
        }
        public int Subtrair(int Valor1, int Valor2)
        {
            int Result = Valor1 - Valor2;

            HistoricoLista.Insert(0, "Result: " + Result + " - " + Data);
            return Result;
        }
        public int Multiplicar(int Valor1, int Valor2)
        {
            int Result = Valor1 * Valor2;

            HistoricoLista.Insert(0, "Result: " + Result + " - " + Data);
            return Result;
        }
        public int Dividir(int Valor1, int Valor2)
        {
            int Result = Valor1 / Valor2;

            HistoricoLista.Insert(0, "Result: " + Result + " - " + Data);
            return Result;
        }
        public List<string> Historico()
        {
            HistoricoLista.RemoveRange(3, HistoricoLista.Count -3);
            return HistoricoLista;
        }
    }
}
