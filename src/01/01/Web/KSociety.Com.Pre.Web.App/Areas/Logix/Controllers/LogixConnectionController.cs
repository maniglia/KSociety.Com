﻿using Microsoft.AspNetCore.Mvc;

namespace KSociety.Com.Pre.Web.App.Areas.Logix.Controllers;

[Area("Logix")]
public class LogixConnectionController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}