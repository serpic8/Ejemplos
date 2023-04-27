namespace Serializable
{
    [Serializable]
    public class Datos
    {
        private int id;
        private string nombre;
        private string nCuenta;
        private decimal saldo;

        public Datos() : this(0,"","",0.0M)
        {

        }

        public Datos(int valorId, string valorNombre, string valornCuenta, decimal valorSaldo)
        {
            this.id = valorId;
            this.nombre = valorNombre;
            this.nCuenta = valornCuenta;
            this.saldo = valorSaldo;
        }

        public int valorId { get => id; set => id = value; }
        public string valorNombre { get => nombre; set => nombre = value; }
        public string valornCuenta { get => nCuenta; set => nCuenta = value; }

        public decimal valorSaldo { get => saldo; set => saldo = value; }

        public override string ToString()
        {
            return "ID: " + id + "\n" +
                "NOMBRE: " + nombre + "\n" +
                "CUENTA: " + nCuenta + "\n" +
                "SALDO: " + saldo + "\n"; 
        }


    }
}