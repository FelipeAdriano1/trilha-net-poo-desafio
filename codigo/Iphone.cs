using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codigo
{
    internal class Iphone : Smartphone
    {
        List<Iphone> armIphone;
        public Iphone(string numero, string modelo, string IMEI, int memoria) : base(numero, modelo, IMEI, memoria)
        {
            armIphone = new List<Iphone>();
        }

        public void adicionarIphone(Iphone iphone) 
        {
            armIphone.Add(iphone);
        }

        public void listarIphones() 
        {
            foreach (Iphone i in armIphone)
            {
                Console.WriteLine($"\nInformações do Smartphone\nModelo: {modelo}\nNúmero: {numero}\nIMEI: {IMEI}\nMemória: {memoria}GB");
            }
        }

        public override string instalarAplicativo(string nome)
        {
            string app = nome;

            return $"\nInstalando aplicativo {app} ...\nAplicativo {nome} instalado com sucesso !";
        }

        public string getModelo() 
        {
            return modelo;
        }

        public int getMemoria() 
        {
            return memoria;
        }

        public string getIMEI() 
        {
            return IMEI;
        }
    }
}
