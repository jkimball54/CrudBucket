using CrudBucketMVC.DataAccess;
using Microsoft.AspNetCore.Mvc;
using CrudBucketMVC.Models;
namespace CrudBucketMVC.Controllers
{
    public class OwnersController : Controller
    {
        private readonly CrudBucketContext _context;

        public OwnersController(CrudBucketContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var owners = _context.Owners;
            return View(owners);
        }
        [Route("/Owners/{id:int}")]
        public IActionResult Show(int id)
        {
            var owner = _context.Owners.Find(id);
            return View(owner);
        }
        [Route("/Owners/New")]
        public IActionResult New()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Owner owner)
        {
            _context.Owners.Add(owner);
            _context.SaveChanges();

            var newOwnerId = owner.Id;

            return Redirect($"/Owners/{newOwnerId}");
        }
        [Route("/Owners/{id:int}/Edit")]
        public IActionResult Edit(int id)
        {
            var owner = _context.Owners.Find(id);
            return View(owner);
        }
        [HttpPost]
        [Route("Owners/{id:int}")]
        public IActionResult Update(int id, Owner owner)
        {
            owner.Id = id;
            _context.Owners.Update(owner);
            _context.SaveChanges();

            return Redirect($"/Owners/{owner.Id}");
        }
    }
}
