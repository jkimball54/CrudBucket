﻿using CrudBucketMVC.DataAccess;
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
    }
}
