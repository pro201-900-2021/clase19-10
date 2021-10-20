//Dependencias
//include
//require
//import
using System;

//nombre solución
namespace clase16_10
{
    //clase principal
    class Program{
        //Función principal, mi llave de contacto
        static void Main(string[] args)
        {
            //print
            //put
            //echo
            //System.out.println
            Console.WriteLine("Hello World!");
            Console.Write("Bye World!");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine();
            //declaración de variables
            string nombre = "Diego";

            Console.WriteLine(nombre);

            int edad = 18;
            Console.WriteLine(edad);

            //puedo declarar e inicializar una variable en líneas distintas.
            string apellido;
            apellido = "Lucero";

            bool grande;

            grande = true;
            grande = false;

            Console.WriteLine("Valor mas alto de un Int");
            Console.WriteLine(Int32.MaxValue);
            Console.WriteLine("Valor mas pequeño de un Int");
            Console.WriteLine(Int32.MinValue);

            //estructuras iterativas o bucles
            //for - por o para
            //while - mientras

            int contador = 0;
            bool condicion = false;
            while (condicion) //bool (true o false)
            {
                Console.Write("El contador vale: ");
                Console.WriteLine(contador);
                contador = contador + 1;

                //estructura condicional
                if(contador > 100)
                {
                    condicion = false;
                }
            }

            Console.WriteLine("FOR");
            //declaración e inicialización de variable // condición // incremento
            for(int cont = 0; cont < 100; cont++) // cont = cont + 1
            {
                Console.WriteLine(cont);
            }

            //estructuras condicionales
            //if-else
            //switch-case

            //si o "en caso de"

            //PascalCase
            //camelCase
            //snake_case


            if (false)
            {
                Console.WriteLine("Estoy dentro del IF");
            }
            else
            {
                Console.WriteLine("Estoy dentro del ELSE");
            }



            Console.WriteLine("********===******");
            int miEdad = 20;

            //OR
            //AND
            //NOT


            if (miEdad > 0 && miEdad < 18)
            {
                Console.WriteLine("Tú eres menor de edad");
            }else if(miEdad >= 18 && miEdad < 30)
            {
                Console.WriteLine("Tú eres mayor de edad, estás jovencita/o");
            }else if (miEdad >= 30 && miEdad < 40)
            {
                Console.WriteLine("Tú eres mayor de edad");
            }
            else
            {
                //se ejecutará si la condición nunca fue verdadera para ningun caso
            }

            int opcion = 2;

            switch (opcion)
            {
                case 1:
                    opcionN(1);
                    break;
                case 2:
                    opcionN(2);
                    break;
                case 3:
                    opcionN(3);
                    break;
                default:
                    Console.WriteLine("La opción no existe");
                    break;
            }

            //DRY => Dont repeat yourself

            int unnumero;

            Console.WriteLine("Acá comienzo a trabajar con la clase Persona");
            Console.WriteLine("*******************");
            //solo hemos declarado la variable y su tipo de dato
            Persona p1;
            //inicializamos la variable de tipo Persona
            p1 = new Persona();

            Persona p2 = new Persona(); //Instanciar una clase Persona o Crear un objeto del tipo Persona

            //p1.nombre = "Diego";
            p1.SetNombre("Diego");
            p1.SetApellido("Lucero");
            p1.SetRut("111111111");
            p1.SetEdad(18);
            //p1.apellido = "Lucero";
            //p1.rut = "111111111";
            //p1.edad = 18;

            //p1.nombre = "Andrés";

            //en caso de ser char '' comillas simples, de otra manera las comillas dobles me indican string
            char letraa = 'a';

            //Console.WriteLine(p1.nombre);
            Console.WriteLine(p1.GetNombre());
            Console.WriteLine(p1.GetApellido());
            Console.WriteLine(p1.GetRut());
            Console.WriteLine(p1.GetEdad());

            p2.Nombre = "John";
            p2.Apellido = "Doe";
            p2.Rut = "222222222";
            p2.Edad = 20;

            Console.WriteLine("Acá muestro los datos de la persona 2 (p2)");
            Console.WriteLine();
            Console.WriteLine(p2.Nombre);
            Console.WriteLine(p2.Apellido);
            Console.WriteLine(p2.Rut);
            Console.WriteLine(p2.Edad);

            Console.WriteLine("Acá trabajo con la persona 3 (p3)");
            Persona p3 = new Persona("Armando", "Casas", "333333333", 50);
            Console.WriteLine(p3.Nombre);
            Console.WriteLine(p3.Apellido);
            Console.WriteLine(p3.Edad);
            Console.WriteLine(p3.Rut);

            Console.WriteLine("****************************************");
            Person newPerson = new Person("Diego", "Lucero", "111111111", 20);
            newPerson.showInfo();

        }

        public static void opcionN(int n)
        {
            Console.WriteLine("La opción es "+n);
        }

    }

    //public Persona {}
}
