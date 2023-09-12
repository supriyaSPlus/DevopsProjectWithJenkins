using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UserManagementProject.Data;
using UserManagementProject.Models;

namespace UserManagementProject.Controllers;

public class UserController : Controller
{
    private ApplicationDbContext _db;
     public UserController(ApplicationDbContext db)
     {
        _db=db;
     }

     public IActionResult Index()
     {
        var users= _db.Users.ToList();
        return View(users);
     }
     public IActionResult Create()
     {
        return View();
     }

     public IActionResult CreateUser(User user)
     {
        _db.Users.Add(user);
        _db.SaveChanges();
        return RedirectToAction("Index");
     }
}