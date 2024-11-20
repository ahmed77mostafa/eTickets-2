using eTickets_2.Data;
using eTickets_2.Data.Services;
using eTickets_2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets_2.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorServices _actorServices;
        public ActorsController(IActorServices actorServices)
        {
            _actorServices = actorServices;
        }
        public async Task<IActionResult> Index()
        {
            var AllActors = await _actorServices.GetAll();
            return View(AllActors);
        }
        public IActionResult Details(int id)
        {
            var actor = _actorServices.GetById(id);
            if (actor == null)
                return NotFound();
            return View(actor);
        }
        public IActionResult Edit(int id)
        {
            var actor = _actorServices.GetById(id);
            if(actor == null)
                return NotFound();
            return View(actor);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Actor actor)
        { 
            if(!ModelState.IsValid)
            {
                _actorServices.Update(actor);
                return RedirectToAction("Index");
            }
            return NotFound();
        }
        public IActionResult Delete(int id)
        {
            _actorServices.Delete(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Actor actor) 
        {
            if(!ModelState.IsValid)
            {
                _actorServices.Add(actor);
                return RedirectToAction("Index");
            }
            return NotFound();
        }

    }
}
