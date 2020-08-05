using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using IndependentContracts.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace IndependentContracts.Controllers
{
  public class ContractorsController : Controller
  {
    private readonly IndependentContractsContext _db;
    public ContractorsController(IndependentContractsContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Contractor> model = _db.Contractors.ToList();
      return View(model);
    }

    public ActionResult Details(int id)
    {
      var thisContractor = _db.Contractors
          .Include(contractor => contractor.Clients)
          .ThenInclude(join => join.Client)
          .FirstOrDefault(contractor => contractor.ContractorId == id);
      return View(thisContractor);
    }
    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Contractor contractor)
    {
      _db.Contractors.Add(contractor);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Edit(int id)
    {
      var thisContractor = _db.Contractors.FirstOrDefault(contractors => contractors.ContractorId == id);
      return View(thisContractor);
    }

    [HttpPost]
    public ActionResult Edit(Contractor contractor)
    {
      _db.Entry(contractor).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult AddClient(int id)
    {
      var thisContractor = _db.Contractors.FirstOrDefault(contractors => contractors.ContractorId == id);
      ViewBag.ClientId = new SelectList(_db.Clients, "ClientId", "Name");
      return View(thisContractor);
    }

    [HttpPost]
    public ActionResult AddClient(Contractor contractor, int ClientId)
    {
      if (ClientId != 0)
      {
      _db.ClientContractor.Add(new ClientContractor() { ClientId = ClientId, ContractorId = contractor.ContractorId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisContractor = _db.Contractors.FirstOrDefault(contractors => contractors.ContractorId == id);
      return View(thisContractor);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisContractor = _db.Contractors.FirstOrDefault(contractors => contractors.ContractorId == id);
      _db.Contractors.Remove(thisContractor);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteClient(int joinId)
    {
      var joinEntry = _db.ClientContractor.FirstOrDefault(entry => entry.ClientContractorId == joinId);
      _db.ClientContractor.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}