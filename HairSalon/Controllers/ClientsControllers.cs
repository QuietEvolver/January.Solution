using System; 
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering; //NLn.

namespace HairSalon.Controllers
{
  public class ClientsController : Controller
  {
    private readonly HairSalonContext _db;

    public ClientsController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Client> model = _db.Clients.ToList();//.Include(clients => clients.Stylist) M2M
      return View(model);
    }
    public ActionResult Create()
    {
       // ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "StylistName", "StylistChairType");//Appt&M2M
      return View();
    }

    [HttpPost]
    public ActionResult Create(Client client)
    {
      _db.Clients.Add(client);
      _db.SaveChanges();    
      return RedirectToAction("Index");
    }
    public ActionResult Details(int id)
    {
      Client thisClient= _db.Clients.FirstOrDefault(client => client.ClientId == id);
    //CHGorAdd? a Stylist..(singular?)Client thisClient= _db.Clients.FirstOrDefault(clients => clients.ClientId == id);
    return View(thisClient);
    }

    public ActionResult Edit(int id)
    {
      //Console.WriteLine("id" + id);
        var thisClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
        //i.e.ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "StylistName","Specialty, Appointment,,.");
            //CHGorAdd? a Stylist..(singular?)Client thisClient= _db.Clients.FirstOrDefault(clients => clients.ClientId == id);;;;;ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "StylistName")
        //Console.WriteLine("thisClient" + id);
        return View(thisClient);
    }

    [HttpPost]
    public ActionResult Edit(Client client)
    {
        _db.Entry(client).State = EntityState.Modified;
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisClient = _db.Clients.FirstOrDefault(clients => clients.ClientId == id);
      return View(thisClient);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
       
        //var thisClient = _db.Clients.FirstOrDefault(clients => clients.Stylist>??Id == id);
        _db.Clients.Remove(thisClient);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }
  }
}