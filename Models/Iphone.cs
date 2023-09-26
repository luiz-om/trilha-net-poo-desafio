namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public int MyProperty { get; set; }
        public Iphone(string numero, string modelo, string imei, int memoria, int myProperty) : base(numero, modelo, imei, memoria)
        {
MyProperty = myProperty;
        }


        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
           Console.WriteLine($"Instalando o aplicativo {nomeApp} no Iphone");
           
        }
    }
}