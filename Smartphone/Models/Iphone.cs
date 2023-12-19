namespace Smartphone.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : SmartphoneImp
    {

        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {

        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando o aplicativo '{nome}' no iPhone");
        }
    }
}