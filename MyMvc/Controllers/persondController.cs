using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyMvc.Controllers
{
    public class persondController : Controller
    {
        // GET: persond
        public async Task< ActionResult> Index()
        {
            ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
            var g= await service.GetAllFishesAsync();
            return View(g);
        }

        // GET: persond/Details/5
        public async Task< ActionResult> Details(int id)
        {
            ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
            var u = await service.GetFishByIdAsync(id);
            //var idInt = id;

            //return Catches.FirstOrDefault(Catches => Catches.ID == idInt);
            return View(u);
        }

        // GET: persond/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}
        //[HttpPost]
        public ActionResult Create()
        {

            //public Person AddFish(Person catch1)
            //{
            //    Catches.Add(catch1);
            //    return catch1;
            //}
            
            
           

            return View();
        }

        // POST: persond/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ServiceReference1.Person person)
        {
            try
            {
                ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
                var d = service.AddFishAsync(person);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: persond/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: persond/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task< ActionResult> Edit(int id, ServiceReference1.Person person)
        {
            try
            {

                ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
                await service.UpdateFishAsync(person, id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: persond/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: persond/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ServiceReference1.Person  person)
        {
            try
            {

                ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
                service.DeleteFishAsync(person.ID=id);
                
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}