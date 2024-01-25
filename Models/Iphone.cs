namespace DesafioPOO.Models
{

    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria){

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"...Instalando o aplicativo \"{nomeApp}\" no iPhone...");
            Thread.Sleep(1500);
            Console.WriteLine($"{nomeApp} instalado com sucesso!");
        }
    }
}