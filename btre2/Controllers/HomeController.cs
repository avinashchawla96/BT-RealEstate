﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using btre2.Models;
using btre2.Repository.Interface;
using Microsoft.AspNetCore.Authorization;
using btre2.ViewModels;

namespace btre2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly IListingRepository listingRepository;

        public HomeController(ILogger<HomeController> logger, IListingRepository listingRepository)
        {
            this.logger = logger;
            this.listingRepository = listingRepository;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            ViewBag.Current = "Index";
            var listings = listingRepository.GetTop3Listing();
            return View(listings);
        }

        [AllowAnonymous]
        public IActionResult About()
        {
            ViewBag.Current = "About";
            return View();
        }

        [Authorize]
        public IActionResult Listings()
        {
            ViewBag.Current = "Listings";
            var listings = listingRepository.GetListings();
            return View(listings);
        }

        [Authorize]
        public IActionResult Listing(int id)
        {
            var listing = listingRepository.GetListing(id);
            return View(listing);
        }

        public IActionResult Search(SearchViewModel model)
        {
            model.Listings = listingRepository.Search(model);
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
