
class Program
{ 
    static void Main()
  {
    double EdadMeses, Edad;
    string nombre;

    Console.WriteLine("bienvenidos a nuestro primer sistema cread en C#");
    Console.WriteLine("ingrese su nombre para continuar");
    nombre = Console.ReadLine();// para recibir valores de caracter
    Console.WriteLine("ingrese su edad");
    Edad = Convert.ToDouble(Console.ReadLine());// conbertir a datos tipo double
    EdadMeses = Edad * 12;// calculos Matematicos 
    Console.WriteLine("tu edad en meses es: " + EdadMeses + "Meses");// concatenacion 
        if (Edad >= 18)
        {
            Console.WriteLine("Usted es Mayor de edad");
        }
        else
        {
            Console.WriteLine("Usted es Menor de edad");

        }
  }
} 