namespace Parcial_tema4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el valor del radio del cono");
            double radio = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de la altura del cono");
            double altura = double.Parse(Console.ReadLine());


            double AB = Math.PI * radio*radio;
            Console.WriteLine($"El valor de la area de la base es { AB}");
            double generatriz = Math.Sqrt(radio * radio + altura * altura);
            Console.WriteLine($"El valor de la generatriz es { generatriz}");
            double AL = Math.PI * radio * generatriz;
            Console.WriteLine($"El valor de la area lateral es { AL}");

            double volumen = (Math.PI*radio*radio*altura)/3;
            Console.WriteLine($"El valor del volumen es { volumen}");


            double area = AB + AL;
            Console.WriteLine($"El area del cono es { area}");






        }
    }
}
