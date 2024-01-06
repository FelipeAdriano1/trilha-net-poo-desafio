namespace codigo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CONSTRUINDO UM OBJETO DO TIPO NOKIA

            Console.WriteLine("Digite o número do Nokia: ");
            string numero = Console.ReadLine();
            Console.WriteLine("Digite o modelo do Nokia: ");
            string modelo = Console.ReadLine();
            Console.WriteLine("Digite o IMEI do Nokia: ");
            string imei = Console.ReadLine();
            Console.WriteLine("Digite a memória do Nokia: ");
            int memoria = int.Parse(Console.ReadLine());

            Nokia nokia = new Nokia(numero: numero, modelo: modelo, IMEI: imei, memoria: memoria);
            nokia.adicionarNokia(nokia);

            nokia.listarNokia();

            string appNokia = nokia.instalarAplicativo(nome: "Whatsapp");
            string appNokia1 = nokia.instalarAplicativo(nome: "Telegram");

            Console.WriteLine($"{appNokia}\n{appNokia1}");



            //CONSTRUINDO UM OBJETO DO TIPO IPHONE

            Console.WriteLine("\n\nDigite o número do Iphone: ");
            string numeroI = Console.ReadLine();
            Console.WriteLine("Digite o modelo do Iphone: ");
            string modeloI = Console.ReadLine();
            Console.WriteLine("Digite o IMEI do Iphone: ");
            string imeiI = Console.ReadLine();
            Console.WriteLine("Digite a memória do Iphone: ");
            int memoriaI = int.Parse(Console.ReadLine());

            Iphone iphone = new Iphone(numero: numeroI, modelo: modeloI, IMEI: imeiI, memoria: memoriaI);
            iphone.adicionarIphone(iphone);
            iphone.listarIphones();
            
            string appIphone = iphone.instalarAplicativo(nome: "Word");
            Console.WriteLine(appIphone); 
        }
    }
}
