using Lab.Demo.EF.Data;
using Lab.Demo.EF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.EF.Logic
{
    public class ShippersLogic
    {
        private readonly NorthwindContext context;

        public ShippersLogic()
        {
            context = new NorthwindContext();
        }

        public ShippersLogic(NorthwindContext context)
        {
            this.context = context;
        }

        public List<Shippers> getAll()
        {
            return context.Shippers.ToList();
        }

        public bool insertShipper(string nombre, string telefono)
        {
            try
            {
                Shippers shippers = new Shippers();
                shippers.CompanyName = nombre;
                shippers.Phone = telefono;
                context.Shippers.Add(shippers);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); 
                return false;
            }
        }

        public bool deleteShip(Shippers ship)
        {
            try
            {
                context.Shippers.Remove(ship);
                context.SaveChanges();
                return true;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public List<Shippers> getByName(string name)
        {
            return (
                from s in context.Shippers
                where s.CompanyName.Contains(name)
                select s
                ).ToList();
        }

        public bool changePhoneShip(Shippers ship)
        {
            try
            {
                var shippersUpdate = context.Shippers.Find(ship.ShipperID);
                shippersUpdate.Phone = ship.Phone;
                context.SaveChanges();
                return true;
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
