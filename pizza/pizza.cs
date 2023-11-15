using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizza
{
    internal class pizza
    {
        string pizzaNev;

        public pizza(string line)
        {
            string[] sor = line.Split(';');
            pizzaNev = sor[0];
        }

        double pizzaAr;

        public double PizzaAr { get => pizzaAr; set => pizzaAr = value; }

        public string PizzaNev { get => pizzaNev; set => pizzaNev = value; }

        public override string ToString()
        {
            return $"{pizzaNev}, ára: {PizzaAr.ToString("#,##0")}";
        }
    }
    }
