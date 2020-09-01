﻿using btre2.Data;
using btre2.Models;
using btre2.Repository.Interface;
using btre2.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace btre2.Repository.Manager
{
    public class ListingRepository : IListingRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public ListingRepository(ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        public Listing GetListing(int id)
        {
            var listing = _context.Listings.Include(x => x.Realtor).SingleOrDefault(x => x.Id == id);
            return listing;
        }

        public IEnumerable<Listing> GetListings()
        {
            var listings = _context.Listings.Include(x => x.Realtor).ToList();
            return listings;
        }

        public IEnumerable<Listing> GetTop3Listing()
        {
            var listings = _context.Listings
                                        .Include(x => x.Realtor)
                                        .OrderByDescending(x => x.ListDate)
                                        .Take(3)
                                        .ToList();
            return listings;
        }

        public string CreateListing(CreateListingViewModel model)
        {
            var uniqueFileName = UploadedFile(model.PhotoMain);
            var uniqueFileName1 = UploadedFile(model.Photo1);
            var uniqueFileName2 = UploadedFile(model.Photo2);
            var uniqueFileName3 = UploadedFile(model.Photo3);
            var uniqueFileName4 = UploadedFile(model.Photo4);
            var uniqueFileName5 = UploadedFile(model.Photo5);
            var uniqueFileName6 = UploadedFile(model.Photo6);

            Listing listing = new Listing
            {
                Title = model.Title,
                Address = model.Address,
                City = model.City,
                State = model.State,
                ZipCode = model.ZipCode,
                Description = model.Description,
                Price = model.Price,
                Bedrooms = model.Bedrooms,
                Bathrooms = model.Bathrooms,
                Garage = model.Garage,
                Sqft = model.Sqft,
                LotSize = model.LotSize,
                PhotoMain = uniqueFileName,
                Photo1 = uniqueFileName1,
                Photo2 = uniqueFileName2,
                Photo3 = uniqueFileName3,
                Photo4 = uniqueFileName4,
                Photo5 = uniqueFileName5,
                Photo6 = uniqueFileName6,
                IsPublished = model.IsPublished,
                RealtorId = model.RealtorId
            };

            _context.Listings.Add(listing);
            _context.SaveChanges();
            return "Successfully Created";
        }

        private String UploadedFile(IFormFile photo)
        {
            string uniqueFileName = null;
            if (photo != null)
            {
                string uploadsFolder = Path.Combine(_hostEnvironment.WebRootPath, "images");
                uniqueFileName = DateTime.Now.ToString("yyyyMMdd") + "_" + photo.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    photo.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }

        public Listing Update(Listing listingChanges)
        {
            var listing = _context.Listings.Attach(listingChanges);
            listing.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return listingChanges;
        }

        public string Delete(int id)
        {
            var listing = _context.Listings.Find(id);
            _context.Listings.Remove(listing);
            _context.SaveChanges();
            return "Successfully Deleted";
        }

        public IEnumerable<Listing> Search(SearchViewModel model)
        {
            if (model != null)
            {
                IEnumerable<Listing> listings = null;
                if (model.Bedrooms.HasValue)
                {
                    listings = _context.Listings.Where(m => m.Bedrooms == model.Bedrooms).ToList();
                }

                if (model.Price.HasValue)
                {
                    listings.Where(m => m.Price <= model.Price);
                }

                if (!String.IsNullOrEmpty(model.City))
                {
                    listings.Where(m => m.City == model.City);
                }

                if (!String.IsNullOrEmpty(model.State))
                {
                    listings.Where(m => m.State == model.State);
                }

                if (!String.IsNullOrEmpty(model.Keyword))
                {
                    listings.Where(m => m.Description == model.Keyword);
                }

                return listings;

            }

            return _context.Listings.ToList();

        }

        public IEnumerable<Listing> GetListingForSpecificRealtor()
        {
            throw new NotImplementedException();
        }
    }
}
