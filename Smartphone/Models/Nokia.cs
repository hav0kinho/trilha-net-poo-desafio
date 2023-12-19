namespace Smartphone.Models
{
    // TODO: Herdar da classe "Smartphone" (X)
    public class Nokia : SmartphoneImp
    {
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
                
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando o aplicativo '{nome}' no Nokia");
        }
    }
}