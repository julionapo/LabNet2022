using Antlr.Runtime.Tree;
using Lab.Demo.EF.Entities;
using Lab.Demo.EF.Logic;
using Lab.Demo.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.Demo.MVC.Controllers
{
    public class ShippersController : Controller
    {
        ShippersLogic logic = new ShippersLogic();

        // GET: Shippers
        public ActionResult Index()
        {
            
            List<Lab.Demo.MVC.Models.ShippersView> shippers = logic.getAll().Select(
                s => new Models.ShippersView
            {
                id= s.ShipperID,
                nombre=s.CompanyName,
                telefono=s.Phone
            }).ToList();
            return View(shippers);
        }

        [HttpGet]
        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(ShippersView shippersView)
        {
            try
            {
                if (shippersView.id == 0)
                {
                    logic.insertShipper(shippersView.nombre, shippersView.telefono);

                } else
                {
                    logic.updateShip(new Shippers
                    {
                        CompanyName = shippersView.nombre,
                        Phone = shippersView.telefono,
                        ShipperID = shippersView.id
                    });
                }
                return RedirectToAction("Index");
            } catch(Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }
        }

        public ActionResult Delete(int id)
        {
            logic.deleteShip(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult ShowForUpdate(int id)
        {
            try
            {
                Shippers ship = logic.getById(id);
                ShippersView shipView = new Models.ShippersView
                {
                    id = ship.ShipperID,
                    nombre = ship.CompanyName,
                    telefono = ship.Phone
                };
                return View("Insert",shipView);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }
        }
    }
}