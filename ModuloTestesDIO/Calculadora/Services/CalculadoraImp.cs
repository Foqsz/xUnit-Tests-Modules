﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloTestesDIO.Calculadora.Services
{
    internal class CalculadoraImp
    {
        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public bool EhPar(int numero)
        {
            return numero % 2 == 0;
        }
    }
}
