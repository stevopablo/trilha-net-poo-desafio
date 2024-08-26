namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone

    {
        public Nokia(string numero, string modelo, string imai,int memoria)
            : base(numero, modelo, imai, memoria){}

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} no Nokia");
        }
    }

}