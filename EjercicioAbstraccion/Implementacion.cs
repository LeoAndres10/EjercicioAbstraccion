
namespace EjercicioAbstraccion
{
    public class Implementacion : Matematicas
    {


        public Implementacion(double numero1, double numero2)
        {
            this.numero1 = numero1;
            this.numero2 = numero2;
        }
        public Implementacion()
        {
            
        }
        public double numero1;

        public double numero2;


        public override double NumeroMayor()
        {
            return Math.Max(numero1, numero2);
        }

        public override double NumeroMenor()
        {
            return Math.Min(numero1, numero2);
        }

        public override double RaizCuadrada()
        {
            return Math.Sqrt(numero1);
        }

        public override double RaizCuadrada2()
        {
            return Math.Sqrt(numero2);
        }
        public override double ValorAbsoluto()
        {
            return Math.Abs(numero1);
        }
        public override double ValorAbsoluto2()
        {
            return Math.Abs(numero2);
        }
        public override void Imprimir()
        {
            Console.WriteLine($"El  numero mayor es:  {NumeroMayor()}");
            Console.WriteLine($"El  numero menor es:  {NumeroMenor()}");
            Console.WriteLine($"La raiz cuadrada del primer numero es:  {RaizCuadrada()}");
            Console.WriteLine($"La raiz cuadrada del segundo numero es:  {RaizCuadrada2()}");
            Console.WriteLine($"El valor absoluto del primer numero es:  {ValorAbsoluto()}");
            Console.WriteLine($"El valor absoluto del segundo numero es:  {ValorAbsoluto2()}");
            Console.WriteLine();
        }
    }
}