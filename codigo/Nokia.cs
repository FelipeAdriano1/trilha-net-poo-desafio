using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace codigo
{
    internal class Nokia : Smartphone
    {
        List<Nokia> armNokia;
        public Nokia(string numero, string modelo, string IMEI, int memoria) : base (numero, modelo, IMEI, memoria)
        {
            armNokia = new List<Nokia>();
        }

        public void adicionarNokia(Nokia nokia) 
        {
            armNokia.Add(nokia);
        }

        public void listarNokia() 
        {
            foreach (Nokia n in armNokia)
            {
                Console.WriteLine($"\nInformações do Smartphone\nModelo: {modelo}\nNúmero: {numero}\nIMEI: {IMEI}\nMemória: {memoria}GB");
            }
        }

        public override string instalarAplicativo(string nome)
        {
            string app = nome;

            return $"\nInstalando aplicativo {app} ...\n{app} instalado com sucesso !";
        }

        public string getIMEI() 
        {
            return IMEI;
        }

        public string getModelo() 
        {
            return modelo;
        }

        public int getMemoria() 
        {
            return memoria;
        }

    }
}
