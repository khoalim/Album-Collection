﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AlbumProject.Controllers
{
    [Route("api/[ArtistController]")]
    [ApiController]

    public class ArtistController : ControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}