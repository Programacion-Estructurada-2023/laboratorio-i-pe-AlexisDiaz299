using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            //Declaración y asignación de tipo texto

            string? departamento, municipio, ciudad;
            Console.Write("\n Ingrese el nombre del departamento: ");
            departamento = Console.ReadLine();
            Console.Write("\n Ingrese el nombre del municipio: ");
            municipio = Console.ReadLine();
            Console.Write("\n Ingrese el nombre de la ciudad: ");
            ciudad = Console.ReadLine();

            string? colonia = "Colonia Las Flores";
            string? colorCasa = "Blanca";

            //Declaracion tipo int

            int añosViviendo;
            int edadActual;
            Console.Write("\n Ingresar los años que lleva viviendo en su residencia actual: ");
            añosViviendo = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Ingresar su edad actual: ");
            edadActual = Convert.ToInt32(Console.ReadLine());

            DateTime fechaNacimiento = new DateTime(2004, 1, 13);
            DateTime fechaActual = DateTime.Now;

            //Aplicación de funciones a variables de texto

            //Comparacion de cadenas
            
            Console.WriteLine("\n************COMPARACION DE CADENAS************");
            Console.WriteLine("\n Colonia y Ciudad son iguales? >>> " + string.Equals(colonia, ciudad));
            Console.WriteLine("\n Municipio y Ciudad son iguales? >>> " + string.Equals(municipio, ciudad));

            //Funcion de concatenacion 

            string? concatenacion = departamento + " " + municipio +"  "+ ciudad;
            Console.WriteLine("\n Concatenación de texto >>> " + concatenacion);

            //Funcion de mayusculas

            string? mayusculas = departamento.ToUpper();
            Console.WriteLine("\n Departamento en mayúsculas >>> " + mayusculas);

            ////Funcion de limpiado

            string? limpiado = municipio.Trim();
            Console.WriteLine("\n Municipio limpiado de espacios >>> " + limpiado);

            //Funcion de longitud

            int longitudColonia = colonia.Length;
            int longitudColorCasa = colorCasa.Length;
            Console.WriteLine("\n Longitud de la Colonia >>> " + longitudColonia);
            Console.WriteLine("\n Longitud del Color de Casa >>> " + longitudColorCasa);

            //Aplicación de funciones a variables de fecha

            //Formateo de fecha

            Console.WriteLine("\n\n************FORMATEO DE FECHAS************");
            Console.WriteLine("\n Fecha de nacimiento >>> " + fechaNacimiento.ToString("dd/MM/yyyy"));
            Console.WriteLine("\n Fecha actual >>> " + fechaActual.ToString("dd/MM/yyyy"));
            
            //Funcion de agregar semanas a las fechas

            DateTime fechaNacimientoMas2Semanas = fechaNacimiento.AddDays(14);
            DateTime fechaActualMas2Semanas = fechaActual.AddDays(14);

            Console.WriteLine("\n\n************FECHAS CON 2 SEMANAS ADICIONALES************");
            Console.WriteLine("\n Fecha de nacimiento + 2 semanas >>> " + fechaNacimientoMas2Semanas.ToString("dd/MM/yyyy"));
            Console.WriteLine("\n Fecha actual + 2 semanas >>> " + fechaActualMas2Semanas.ToString("dd/MM/yyyy"));

            //Funcion de comparar fechas

            bool fecha1Mayor = fechaNacimiento > fechaActual;
            bool fecha1Menor = fechaNacimiento < fechaActual;
            Console.WriteLine("\n Fecha de nacimiento mayor que fecha actual? >>> " + fecha1Mayor);
            Console.WriteLine("\n Fecha de nacimiento menor que fecha actual? >>> " + fecha1Menor);

            //Impresión de valores en consola
            Console.WriteLine("\n\n\n*************************************\n");
            Console.WriteLine("\n--------INICIO DE IMPRESION DE VALORES--------" );
            Console.WriteLine("\n\n************VALORES INGRESADOS DE VARIABLES DE TEXTO************");
            Console.WriteLine("\n Departamento >>> " + departamento);
            Console.WriteLine("\n Municipio >>> " + municipio);
            Console.WriteLine("\n Ciudad >>> " + ciudad);
            Console.WriteLine("\n Colonia >>> " + colonia);
            Console.WriteLine("\n Color de Casa >>> " + colorCasa);

            Console.WriteLine("\n\n************VALORES DE VARIABLES ENTERAS************");
            Console.WriteLine("\n Años de vivir en la residencia actual >>> " + añosViviendo);
            Console.WriteLine("\n Edad actual >>> " + edadActual);

            Console.WriteLine("\n\n************COMPARACION DE CADENAS************");
            Console.WriteLine("\n Colonia y Ciudad son iguales >>> " + string.Equals(colonia, ciudad));
            Console.WriteLine("\n Municipio y Ciudad son iguales >>> " + string.Equals(municipio, ciudad));

            Console.WriteLine("\n\n************VALORES OBTENIDOS DE FUNCIONES DE FECHA************");
            Console.WriteLine("\n Fecha de nacimiento >>> " + fechaNacimiento.ToString("dd/MM/yyyy"));
            Console.WriteLine("\n Fecha actual >>> " + fechaActual.ToString("dd/MM/yyyy"));
            Console.WriteLine("\n----------------FIN DE IMPRESION----------------\n\n");
            Console.WriteLine("\n\n\n*************************************************************************\n");

            //Autoevaluacion 9
        


        }
    }
}