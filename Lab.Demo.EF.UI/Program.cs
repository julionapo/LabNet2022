using Lab.Demo.EF.Entities;
using Lab.Demo.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.EF.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program.getEntities();
            //Program.insertJulioShip();
            // Program.deleteAllJulioShip();
            Program.updateJulioShip();
            Console.ReadLine();
        }

        static public void insertJulioShip()
        {
            ShippersLogic shippersLogic = new ShippersLogic();
            if(shippersLogic.insertShipper("JulioCompany and assoc", "1137979454"))
            {
                Console.WriteLine("Se inserto correctamente");
            } else
            {
                Console.WriteLine("Hubo un inconveniente al insertar la nave");
            }
        }

        static public void deleteAllJulioShip()
        {
            ShippersLogic shippersLogic = new ShippersLogic();
            foreach(var i in shippersLogic.getByName("julio"))
            {
                if (shippersLogic.deleteShip(i))
                {
                    Console.WriteLine($" nave con id {i.ShipperID} eliminado exitosamente");
                } else
                {
                    Console.WriteLine($"nave con id {i.ShipperID} no se pudo eliminar");
                }
            }
        }

        static public void updateJulioShip()
        {
            ShippersLogic shippersLogic = new ShippersLogic();
            foreach (var i in shippersLogic.getByName("julio"))
            {
                i.Phone = "5555-5555";
                if (shippersLogic.changePhoneShip(i))
                {
                    Console.WriteLine("Se actualizo el telefono correctamente");
                } else
                {
                    Console.WriteLine("No se ha podido actualizar el telefono");
                }
            }
            
        }

        static public void getEntities()
        {
            Console.WriteLine("Aplicacion iniciada");
            EmployeesLogic employeesLogic = new EmployeesLogic();
            Console.WriteLine("Traemos todos los empleados");
            foreach (Employees item in employeesLogic.GetAll())
            {
                Console.WriteLine($"nombre: {item.FirstName}, apellido: {item.LastName}, titulo: {item.LastName}");
            }
            Console.WriteLine();
            ShippersLogic shipperLogic = new ShippersLogic();
            Console.WriteLine("Traemos todas las navieras");
            foreach (Shippers item in shipperLogic.getAll())
            {
                Console.WriteLine($"nombre: {item.CompanyName}, telefono: {item.Phone} ");
            }
        }
    }
}
