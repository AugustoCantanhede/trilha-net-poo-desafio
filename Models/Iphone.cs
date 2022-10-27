namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class IPhone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public IPhone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no iPhone.");
        }
    }
}