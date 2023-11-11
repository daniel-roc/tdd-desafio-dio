using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        private List<string> _historico;

        public CalculadoraImp()
        {
            _historico = new List<string>();
        }

         public int Somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            _historico.Add($"{num1} + {num2} = {resultado}");
            return resultado;
        }

        public int Subtrair(int num1, int num2)
        {
            int resultado = num1 - num2;
            _historico.Add($"{num1} - {num2} = {resultado}");
            return resultado;
        }
        public int Multiplicar(int num1, int num2)
        {
            int resultado = num1 * num2;
            _historico.Add($"{num1} * {num2} = {resultado}");
            return resultado;
        }

        public int Dividir(int num1, int num2)
        {
            int resultado = num1 / num2;
            _historico.Add($"{num1} / {num2} = {resultado}");
            return resultado;
        }

        public List<string> Historico()
        {
            // _historico.RemoveRange(3, _historico.Count);
            return _historico;
        }
       

        public bool EhPar(int num)
        {
            return num % 2 == 0;
        }
    }
}