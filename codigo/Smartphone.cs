using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codigo
{
    internal abstract class Smartphone
    {
        public string numero {  get; set; }
        protected string modelo {  get; set; }
        protected string IMEI {  get; set; }
        protected int memoria {  get; set; }

        public Smartphone(string numero, string modelo, string IMEI, int memoria) 
        {
            this.numero = numero;
            this.modelo = modelo;
            this.IMEI = IMEI;
            this.memoria = memoria;
        }

        public void ligar() 
        {
            Console.WriteLine("Ligando...");
        }

        public void receberLigacao() 
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract string instalarAplicativo(string nome);
    }
}
