using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using IndependentContracts.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace IndependentContracts.Controllers
{
  public class ClientsController : Controller
  {
    private readonly IndependentContractsContext _db;

    public ClientsController(IndependentContractsContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Client> model = _db.Clients.Include(orgs=>orgs.Organization).ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.Orgs = new SelectList(_db.Organizations, "OrganizationId", "Name");
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
      var thisClient = _db.Clients
          .Include(client => client.Contractors)
          .ThenInclude(join => join.Contractor)
          .Include(client=>client.Organization)
          .FirstOrDefault(client => client.ClientId == id);
      return View(thisClient);
    }

    public ActionResult Edit(int id)
    {
      var thisClient = _db.Clients.Include(client=>client.Organization).FirstOrDefault(client => client.ClientId == id);
      ViewBag.Orgs = new SelectList(_db.Organizations, "OrganizationId", "Name");
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
      var thisClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
      return View(thisClient);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
      _db.Clients.Remove(thisClient);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult AddContractor(int id)
    {
    var thisClient = _db.Clients.FirstOrDefault(clients => clients.ClientId == id);
    ViewBag.ContractorId = new SelectList(_db.Contractors, "ContractorId", "Name");
    return View(thisClient);
    }

    [HttpPost]
    public ActionResult AddContractor(Client client, int ContractorId)
    {
      if (ContractorId != 0)
      {
      _db.ClientContractor.Add(new ClientContractor() { ContractorId = ContractorId, ClientId = client.ClientId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteContractor(int joinId)
    {
      var joinEntry = _db.ClientContractor.FirstOrDefault(entry => entry.ClientContractorId == joinId);
      _db.ClientContractor.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}