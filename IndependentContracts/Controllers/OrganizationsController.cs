using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using IndependentContracts.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace IndependentContracts.Controllers
{
  public class OrganizationsController : Controller
  {
    private readonly IndependentContractsContext _db;
    public OrganizationsController(IndependentContractsContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Organization> model = _db.Organizations.ToList();
      return View(model);
    }

    public ActionResult Details(int id)
    {
      var thisOrganization = _db.Organizations
          .Include(organization => organization.Clients)
          .FirstOrDefault(organization => organization.OrganizationId == id);
      return View(thisOrganization);
    }
    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Organization organization)
    {
      _db.Organizations.Add(organization);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Edit(int id)
    {
      var thisOrganization = _db.Organizations.FirstOrDefault(organization => organization.OrganizationId == id);
      return View(thisOrganization);
    }

    [HttpPost]
    public ActionResult Edit(Organization organization)
    {
      _db.Entry(organization).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisOrganization = _db.Organizations.FirstOrDefault(organization => organization.OrganizationId == id);
      return View(thisOrganization);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisOrganization = _db.Organizations.FirstOrDefault(organization => organization.OrganizationId == id);
      _db.Organizations.Remove(thisOrganization);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}