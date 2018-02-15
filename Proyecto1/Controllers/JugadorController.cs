using Proyecto1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibreriaClases;
using static LibreriaClases.ListaDoble;

namespace Proyecto1.Controllers
{
    public class JugadorController : Controller
    {
        //static List<Jugador> player = new List<Jugador>();
        
        
        // GET: Jugador
        public ActionResult Index()
        {
            return View();
            
        }


        [HttpPost]
        public ActionResult Index(HttpPostedFileBase archivoTXT)
        {


            try
            {
                //Obtengo la data del archivo
                string resultado = new System.IO.StreamReader(archivoTXT.InputStream).ReadToEnd();

                //En este caso quiero separar por la coma, me devolvería 2 valores
                string[] datos = resultado.Split(',');
               string[] dtos = new string[10];

                for (int i = 0; i < archivoTXT.ContentLength; i++)
                {
                   // datos[i] = ColeccionJugadores.Instance.AgregarJugador();
                   // Array.Clear(datos(0,5));
                }

                //Mi otro controlador necesita 2 parámetros
                //return RedirectToAction("Datos", new { nom = datos[0].ToString(), mail = datos[1].ToString() });

            }
            catch (Exception ex)
            {
                ViewBag.mensaje = "Se produjo un error : " + ex.Message;
            }

            return View();
        }


        // GET: Jugador/Details/5
        public ActionResult Details(Jugador p)
        {
            return View(p);
        }


        // GET: Jugador/Create
        public ActionResult Create()
        {
           // var jugador = ColeccionJugadores.Instance.AgregarJugador(jugador);

            return View();
            //ColeccionJugadores.Instance.AgregarJugador();
        }

        // POST: Jugador/Create
        [HttpPost]
        public ActionResult Create(Jugador p)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                //player.Add(p);
                return View("Create", p);
            }
        }

        


        // GET: Jugador/Edit/5
        public ActionResult Edit(Jugador p)
        {
            return View(p);
        }

        // POST: Jugador/Edit/5
        [HttpPost]
        public ActionResult Edit(Jugador p, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
               // player.Add(p);
                return View("Create", p);
                //return View();
            }
        }

        // GET: Jugador/Delete/5
        public ActionResult Delete(Jugador p)
        {
            return View(p);
        }

        // POST: Jugador/Delete/5
        [HttpPost]
        public ActionResult Delete(Jugador p, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View(p);
            }
        }
    }
}
