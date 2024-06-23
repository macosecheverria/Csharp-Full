namespace  Poo {

    class Program
    {
        static void Main(string[] args)
        {
            Automovil subaru = new Automovil("Subaru", "Impreza", "Azul", 2300);
            Console.WriteLine(subaru.GetAutomovil());
        }


        class Automovil
        {
            private string fabricante;
            private string modelo;
            private string color;
            private int cilindrada;

            public Automovil(
                string fabricante, 
                string modelo, 
                string color, 
                int cilindrada
                )
            {
                this.fabricante = fabricante;
                this.modelo = modelo;
                this.color = color;
                this.cilindrada = cilindrada;
            }

            public string GetAutomovil()
            {
                return "Fabricante: " + fabricante + 
                       " Modelo: " + modelo + 
                       " Color: " + color + 
                       " Cilindrada" + cilindrada;
            }


        }
    }
}

