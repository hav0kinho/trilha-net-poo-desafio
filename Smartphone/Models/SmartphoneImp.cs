namespace Smartphone.Models
{
    public abstract class SmartphoneImp
    {
        // Realizei algumas mudanças no encapsulament do modelo para que encaixa-se na expansão do projeto
        public string Numero { get; set; }

        public string Modelo { get; set; }
        public string IMEI { get; set; }
        private int Memoria { get; set; }

        public SmartphoneImp(string numero, string modelo, string imei, int memoria)
        {
            this.Numero = numero;
            this.Modelo = modelo;
            this.IMEI = imei;
            this.Memoria = memoria;
            // TODO: Passar os parâmetros do construtor para as propriedades (X)
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}