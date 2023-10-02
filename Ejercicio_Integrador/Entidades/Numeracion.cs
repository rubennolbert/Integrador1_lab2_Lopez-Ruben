namespace Entidades
{
    public enum Esistema { DECIMAL, BINARIO }

    public class Numeracion
    {
        private Esistema sistema;
        private double valorNumerico;

        //*************CONSTRUCTOR************************************
        public Numeracion(Esistema sistema, string valorNumerico)
        {
            this.InicializarValores(valorNumerico, sistema);
        }
        public Numeracion(Esistema sistema, double valorNumerico)
        {
            this.InicializarValores(valorNumerico.ToString(), sistema);
        }

        //*****************PROPIEDADES*********************************
        public Esistema Sistema { get { return this.sistema; } }
        public double ValorNumerico { get { return this.valorNumerico; } }

        //*****************METODOS*************************************
        public bool EsBinario(string valor)
        {
            foreach (var c in valor)
            {
                if (c == '0' || c == '1')
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public double BinarioADecimal(string valor)
        {
            if (EsBinario(valor))
            {
                return (double)Convert.ToInt32(valor, 2);
            }
            return 0;
        }
        public string DecimalABinario(int valor)
        {
            return Convert.ToString(valor, 2);
        }
        public string DecimalABinario(string valor)
        {
            int valorInt;
            if (int.TryParse(valor, out valorInt))
            {
                return DecimalABinario(valorInt);
            }
            return "Numero invalido.";
        }

        public string ConvertirA(Esistema sistema)
        {
            if (sistema == Esistema.DECIMAL)
            {
                return this.ValorNumerico.ToString();               
            }
            return DecimalABinario(this.valorNumerico.ToString());
        }

        public void InicializarValores(string valor, Esistema sistema)
        {
            this.sistema = sistema;
            double auxValor;

            if (sistema == Esistema.BINARIO && EsBinario(valor))
            {
                this.valorNumerico = BinarioADecimal(valor);
            }
            else if (double.TryParse(valor, out auxValor) && sistema == Esistema.DECIMAL)
            {
                this.valorNumerico = auxValor;
            }
            else
                this.valorNumerico = double.MinValue;
        }

        //************************SOBRECARGAS_OPERADORES************************
        public static bool operator ==(Esistema sistema, Numeracion numeracion)
        {
            return sistema == numeracion.sistema;
        }
        public static bool operator !=(Esistema sistema, Numeracion numeracion)
        {
            return !(sistema == numeracion.sistema);
        }

        public static bool operator ==(Numeracion n1, Numeracion n2)
        {
            return n1.sistema == n2.sistema;
        }
        public static bool operator !=(Numeracion n1, Numeracion n2)
        {
            return !(n1.sistema == n2.sistema);
        }

        public static Numeracion operator +(Numeracion n1, Numeracion n2)
        {
            return new Numeracion(n1.sistema, n1.valorNumerico + n2.valorNumerico);
        }
        public static Numeracion operator -(Numeracion n1, Numeracion n2)
        {
            return new Numeracion(n1.sistema, n1.valorNumerico - n2.valorNumerico);
        }
        public static Numeracion operator *(Numeracion n1, Numeracion n2)
        {
            return new Numeracion(n1.sistema, n1.valorNumerico * n2.valorNumerico);
        }
        public static Numeracion operator /(Numeracion n1, Numeracion n2)
        {
            return new Numeracion(n1.sistema, n1.valorNumerico / n2.valorNumerico);
        }
    }
}