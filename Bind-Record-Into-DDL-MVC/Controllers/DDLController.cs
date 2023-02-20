using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Bind_Record_Into_DDL_MVC.Models;
using System.Threading.Tasks;
using Bind_Record_Into_DDL_MVC.Data;

namespace Bind_Record_Into_DDL_MVC.Controllers
{
    public class DDLController : Controller
    {
        private readonly ApplicationDbContext _cc;

        public DDLController(ApplicationDbContext cc)
        {
            _cc = cc;
        }

        public IActionResult Index()
        {
            List<CountryClass> cl = new List<CountryClass>();
            cl = (from c in _cc.CountryClasses select c).ToList();
            cl.Insert(0, new CountryClass { Id = 0, Cname = "--Select Country Name--" });
            ViewBag.message = cl;
            return View();
        }
    }
}
