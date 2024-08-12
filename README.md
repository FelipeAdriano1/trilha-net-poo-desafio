## Desafio de projeto ⚔️
Este desáfio é parte do bootcamp **Aprofundamento C#** da plataforma **DIO**. O objetivo é aplicar os conhecimentos adquiridos no módulo de orientação a objetos.

## Contexto 📋
Você é responsável por modelar um sistema que trabalha com celulares. Para isso, foi solicitado que você faça uma abstração de um celular e disponibilize maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.

## Proposta 📌
Você precisa criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. 
Você deve criar as suas classes de acordo com o diagrama abaixo:

![Diagrama classes](Imagens/diagrama.png)

## Regras e validações
1. A classe **Smartphone** deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.

## Resultados 🎯
O princípal  objetivo deste desafio é implementar conceitos sobre encapsulamento, herança e polimorfismo. 
A classe `Smartphone` é abstrata e possuí atributos **Protected:** `modelo`, `IMEI` e `memória` e um atributo **public:** `numero`.
Esta classe tem um construtor que define seus atributos.
````plaintext
public Smartphone(string numero, string modelo, string IMEI, int memoria) 
        {
            this.numero = numero;
            this.modelo = modelo;
            this.IMEI = IMEI;
            this.memoria = memoria;
        }
````
Também temos os métodos `ligar()` e `receberLigacao()` e um método abstrato `instalarAplicativo();`.

````
        public void ligar() 
        {
            Console.WriteLine("Ligando...");
        }

        public void receberLigacao() 
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract string instalarAplicativo(string nome);
````
Por fim, temos as classes `Nokia` e `Iphone` que extendem de `Smartphone` e instanciam seus métodos abstratos.

````
﻿using System;
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
````
