using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering; //NLn.

namespace HairSalon.Controllers
{
  public class StylistsController : Controller
  {
    private readonly HairSalonContext _db;

    public StylistsController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Stylist> model = _db Stylists.Include(stylists => stylists.Client)ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "StylistName");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Stylist style)
    {
      _db Stylists.Add(style);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Stylist thisStylist = _db Stylists.FirstOrDefault(styles => styles.StylistId == id); //style.StylistId == id);
      return View(thisStylist);
    }

    public ActionResult Edit(int id)
    {
      var thisStylist = _db Stylists.FirstOrDefault(styles => styles.StylistId == id);
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "StylistId");
      return View(thisStylist);
    }

    [HttpPost]
    public ActionResult Edit(Stylist style)
    {
      _db.Entry(style).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisStylist = _db Stylists.FirstOrDefault(styles => styles.StylistId == id);
      return View(thisStylist);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisStylist = _db.Stylists.FirstOrDefault(stylists => stylists.StylistId == id);// ManytoMany(style => style.StylistId == id);
      _db Stylists.Remove(thisStylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}