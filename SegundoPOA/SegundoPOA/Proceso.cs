using SegundoPOA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoPOA
{
    public class Proceso
    {
        public List<Empleado> empleados;
        public int Id = 1;
        public Proceso() {
            empleados = new List<Empleado>();

        }
        public bool Menu()
        {
            int op = 0;
            Console.Clear();
            Console.WriteLine("_________________");
            Console.WriteLine("Agregar empleado: 1");
            Console.WriteLine("Verificar si empleado existe: 2");
            Console.WriteLine("Mostrar lista de empleados: 3");
            Console.WriteLine("Ordenar empleados: 4");
            Console.WriteLine("Salir: 5");
            Console.WriteLine("_________________");
            Console.WriteLine("Seleccione la opcion deseada:");
            string input = Console.ReadLine();
            if (!int.TryParse(input,out op)) {
                Console.WriteLine("No es una opcion valida");
                Console.WriteLine("Se cerro el programa");
                return false;
            }

           bool continuar = opciones(op);
            return continuar;

        }

        public bool opciones(int op)
        {
            Console.Clear();
            switch (op) 
            {
                case 1:
                    AgregarEmpleador();
                    break;
                case 2:
                    Verificar();
                    break;
                case 3:
                    Console.Clear();
                    MostrarEmpleados();
                    break;
                case 4:
                    Ordenar();
                    break;
                case 5:
                    Console.WriteLine("Se cerro el programa");
                    return false;
                    break;
                default:
                    Console.WriteLine("Se cerro el programa");
                    return false;
                   
            }
            return true;
        }

        public void Inicio() 
        {
            bool continuar = true;

            while (continuar) {
              continuar =  Menu();
            }
        }

        public bool Agregar()
        {
            int cantidad = 0;
            var empleado = new Empleado();
            empleado.codigo = Id;
            Console.Clear();
            Console.WriteLine("Agregar un nuevo empleado");
            Console.WriteLine("____________________");
            Console.WriteLine("Agregue el nombre");
            empleado.nombre = Console.ReadLine();


            Console.WriteLine("Agregue el apellido");
            empleado.apellidos = Console.ReadLine();


            Console.WriteLine("Agregue la direccion");
            empleado.direccion = Console.ReadLine();


            Console.WriteLine("Agregue la cedula");
            empleado.cedula = Console.ReadLine();

            Console.WriteLine("Agregue el sexo");
            empleado.sexo = Console.ReadLine();

            Console.WriteLine("Agregue el telefono");
            empleado.telefono = Console.ReadLine();

            Console.WriteLine("Agregue el correo");
            empleado.correo = Console.ReadLine();

            Console.WriteLine("Agregue el departamento");
            empleado.departamento = Console.ReadLine();

            Console.WriteLine("Agregue el sueldo");
            var sueldo = Console.ReadLine();
            if (!int.TryParse(sueldo, out cantidad)) {
                empleado.sueldo = 0;
                Console.WriteLine("Sueldo invalido");
            }
            empleado.sueldo = cantidad;

            empleados.Add(empleado);
            Id++;
            Console.WriteLine("Desea agregar otro empleado? Y/N");
            var op = Console.ReadLine();
            if (op.Equals("Y") || op.Equals("yes")) 
            {
                return true;
            }
            return false;
        }

        public void AgregarEmpleador()
        {
            bool continuar = true;
            while (continuar)
            {
                continuar = Agregar();
            }
        }

        public void Verificar() 
        {
            string nombre = "";
            Console.Clear();
            Console.WriteLine("Buscar empleado");
            Console.WriteLine("Introdusca el nombre:");
            nombre = Console.ReadLine();

            if (empleados.Where(x => x.nombre.Equals(nombre)).Count() > 0)
            {
                Console.WriteLine("El empleado existe!");
            }
            else {
                Console.WriteLine("El empleado no existe!");
            }

            Console.ReadKey();
        }

        public void MostrarEmpleados()
        {
           
            Console.WriteLine("Lista de empleados");
            if (empleados.Count > 0)
            {
                foreach (var item in empleados)
                {
                    Console.WriteLine("__________________");
                    Console.WriteLine("Codigo: " + item.codigo.ToString());
                    Console.WriteLine("Nombre: " + item.nombre);
                    Console.WriteLine("Apellido: " + item.apellidos);
                    Console.WriteLine("Direccion: " + item.direccion);
                    Console.WriteLine("Cedula: " + item.cedula);
                    Console.WriteLine("Sexo: " + item.sexo);
                    Console.WriteLine("Telefono: " + item.telefono);
                    Console.WriteLine("Correo: " + item.correo);
                    Console.WriteLine("Departamento: " + item.departamento);
                    Console.WriteLine("Sueldo: " + item.sueldo.ToString());


                    Console.WriteLine("__________________");
                }

            }
            else {
                Console.WriteLine("No hay empleados para mostrar");
            }
            Console.ReadKey();

        }

        public void Ordenar()
        {
            Console.Clear();

            Console.WriteLine("Ordenado por orden alfabetico");
            if (empleados.Count > 0)
            {
                empleados.OrderBy(x => x.nombre);
                MostrarEmpleados();
            }
            else {
                Console.WriteLine("No hay empleados para ordenar");
                Console.ReadKey();
            }
           
        }

    }
}
