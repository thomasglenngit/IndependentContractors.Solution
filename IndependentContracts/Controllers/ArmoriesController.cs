using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using IndependentContracts.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace IndependentContracts.Controllers
{
  public class ArmoriesController : Controller
  {
    private readonly IndependentContractsContext _db;
    public ArmoriesController(IndependentContractsContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Armory> model = _db.Armories.ToList();
      return View(model);
    }

    public ActionResult Details(int id)
    {
      var thisArmory = _db.Armories //Armory entries
          .Include(armory => armory.Contractors) //Join table
          .ThenInclude(join => join.Contractor) //to the contractor
          .FirstOrDefault(armory => armory.ArmoryId == id);
      return View(thisArmory);
          
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Armory armory)
    {
      _db.Armories.Add(armory);
      _db.SaveChanges();
      return RedirectToAction("Details", new {id = armory.ArmoryId});
    }

    public ActionResult Edit(int id)
    {
      var thisArmory = _db.Armories.FirstOrDefault(armories => armories.ArmoryId == id);
      return View(thisArmory);
    }

    [HttpPost]
    public ActionResult Edit(Armory armory)
    {
      _db.Entry(armory).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Details", new {id = armory.ArmoryId});
    }

    public ActionResult Delete(int id)
    {
      var thisArmory= _db.Armories.FirstOrDefault(armories => armories.ArmoryId == id);
      return View(thisArmory);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisArmory= _db.Armories.FirstOrDefault(armories => armories.ArmoryId == id);
      _db.Armories.Remove(thisArmory);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    // [HttpPost]
    // public ActionResult DeleteArmory(int joinId)
    // {
    //   var joinEntry = _db.ClientContractor.FirstOrDefault(entry => entry.ClientContractorId == joinId);
    //   _db.ClientContractor.Remove(joinEntry);
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }

  }
}