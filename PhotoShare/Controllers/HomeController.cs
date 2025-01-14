using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PhotoShare.Models;

namespace PhotoShare.Controllers
{
    public class HomeController : Controller
    {
        // Constructor
        public HomeController()
        {

        }

        public IActionResult Index()
        {
            // Create a list of photos
            List<Photo> photos = new List<Photo>();

            // Create a photo
            Photo photo1 = new Photo();
            photo1.PhotoId = 1;
            photo1.Title = "Photo1";
            photo1.Description = "Description 1";
            photo1.ImageFilename = "photo1.jpg";
            photo1.CreatedAt = DateTime.Now;

            // Create a photo
            Photo photo2 = new Photo();
            photo1.PhotoId = 2;
            photo1.Title = "Photo2";
            photo1.Description = "Description 2";
            photo1.ImageFilename = "photo2.jpg";
            photo1.CreatedAt = DateTime.Now;

            // Create a photo
            Photo photo3 = new Photo();
            photo1.PhotoId = 3;
            photo1.Title = "Photo3";
            photo1.Description = "Description 3";
            photo1.ImageFilename = "photo1.jpg";
            photo1.CreatedAt = DateTime.Now;

            // Add the photos to the list
            photos.Add(photo1);
            photos.Add(photo2);
            photos.Add(photo3);

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
