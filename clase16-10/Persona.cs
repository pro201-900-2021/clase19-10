using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase16_10
{
    class Persona
    {
        //atributos
        //modificador de acceso / mutador /mutador de acceso
        //los atributos por defecto son "private"
        private string nombre;
        private string apellido;
        private string rut;
        private int edad;

        //ENCAPSULAR
        //Al encapsular, accedo a los atributos a través de funciones
        //Obtener y Modificar o Entregar -> Get y Set -> Getters y Setters

        // Mutador - tipo de dato del retorno - nombre de la función - (sus argumentos)

        //Java: getNombre (camelCase)
        //C#: GetNombre (PascalCase)

        //GETTERS
        public string GetNombre()
        {
            return nombre;
        }
        public string GetApellido()
        {
            return apellido;
        }
        public string GetRut()
        {
            return rut;
        }
        public int GetEdad()
        {
            return edad;
        }
        //SETTERS
        public void SetNombre(string nuevoNombre)
        {
            nombre = nuevoNombre;
        }

        public void SetApellido(string value)
        {
            apellido = value;
        }
        public void SetRut(string rut)
        {
            this.rut = rut;
        }
        public void SetEdad(int value)
        {
            edad = value;
        }

        //O, en lugar de encapsular con funciones, puedo encapsular con propiedades

        
        public string Apellido { get => apellido; set => apellido = value; }
        public string Rut { get => rut; set => rut = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        //CONSTRUCTOR

        public Persona() //El constructor es usado para instanciar una clase
        {
            //HACE NADA
        }

        public Persona(string nombre, string apellido, string rut, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.rut = rut;
            this.edad = edad;
        }

        public Persona(string rut)
        {
            this.rut = rut;
            this.edad = 0;
        }

        public Persona(int edad)
        {
            this.edad = edad;
        }
        //muchos constructores y su uso dependerá del argumento
    }
}
