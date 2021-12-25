using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text.Encodings.Web;
using System.Text;
using System.Threading.Tasks;

namespace MPlan.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
        return View();
        }
    }
}
