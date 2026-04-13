namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        //Informa qual o smartphone está sendo utilizado
        //metodo para impedir redundancia de codigo
        //nao fiz utilizando propriedade na classe
        //Smartphone, para nao fugir do foco do
        //diagrama apresentado no projeto
        public void InformaSmartphoneUtilizado(string marca) => Console.WriteLine($"Smartphone {marca}:");

        public abstract void InstalarAplicativo(string nomeApp);
    }
}