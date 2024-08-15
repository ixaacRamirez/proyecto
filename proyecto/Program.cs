// See https://aka.ms/new-console-template for more information

public class progra
{
    public static string EdadMeses { get; private set; }

    static void main(string[] Args)
    {
        int Edad;
        string Nombre;
        Console.WriteLine("bienvenidos a nuestro primer sistema cread en c#");
        Console.WriteLine("ingrese su nombre para continuar");
        Nombre= Console.ReadLine();//para recibir valores de caracter
        Console.WriteLine("ingrese su edad");
        Edad= Convert.ToInt32(Console.ReadLine);//conbertir a datos tipo double
        EdadMeses= Edad * 12;// calculos Matematicos 
        Console.WriteLine("tu edad en meses es: " + EdadMeses + "Meses");//concatenacion 
    }
} 