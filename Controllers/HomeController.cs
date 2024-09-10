using Coza.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.IO;


namespace DOLU.Controllers
{
    public class HomeController : Controller
    {
        private readonly cozastoreContext _sql;

        public HomeController(cozastoreContext sql)
        {
            _sql = sql;
        }

        public IActionResult Index()
        {
            return View(_sql.Products.Include(x => x.Photos).Take(4).Include(x => x.ProductCategory).Include(x => x.ProductBranch).ToList());


        }
        public IActionResult Shop(int id=0)
        {
            ViewBag.Categories = _sql.Categories.ToList();
            var a = _sql.Products.Where(x => 1 == 1);
            if (id != 0)
            {
                a = a.Where(x => x.ProductCategoryId == id);
            }
            if (id == 0)
            {
                a = a;
            }
            return View(a.Include(x=>x.Photos).Include(x => x.ProductCategory).Include(x => x.ProductBranch).ToList());
        }
        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult BlogMore()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult QuickView(int id)
        {
            var a = _sql.Products.Include(x=>x.Photos).SingleOrDefault(x => x.ProductId == id);
            return View(a);
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Login(User user)
        {
            var daxilolan = _sql.Users.SingleOrDefault(x => x.UserNickName == user.UserNickName && x.UserPassword == user.UserPassword);
            if (daxilolan != null)
            {
                List<Claim> claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name, daxilolan.UserName),
                    new Claim(ClaimTypes.GivenName, daxilolan.UserNickName),
                    new Claim(ClaimTypes.Spn, daxilolan.UserProfilePhoto),
                    new Claim(ClaimTypes.Sid, daxilolan.UserId.ToString()),

           };
                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var prins = new ClaimsPrincipal(identity);
                var props = new AuthenticationProperties();
                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, prins, props).Wait();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
        }

        public IActionResult LogOut()
        {
            HttpContext.SignOutAsync().Wait();
            return RedirectToAction("Index", "Home");

        }

        public IActionResult SignUp()
        {
            return View(_sql.Users.ToList());
        }
        [HttpPost]
        public IActionResult SignUp(User user, IFormFile UserProfilePhoto)
        {
            if (user.UserGender == "man" && UserProfilePhoto == null)
            {
                user.UserProfilePhoto = "ppavatar.jpg";
            }
            if (user.UserGender == "woman" && UserProfilePhoto == null)
            {
                user.UserProfilePhoto = "womanavatar.png";
            }
            if(UserProfilePhoto != null)
            {
                string newproduct = Path.GetFileNameWithoutExtension(Path.GetRandomFileName()) + Path.GetExtension(UserProfilePhoto.FileName);
                using (Stream stream = new FileStream("wwwroot/images/" + newproduct, FileMode.Create))
                {
                    UserProfilePhoto.CopyTo(stream);
                }
                user.UserProfilePhoto = newproduct;
            }
            _sql.Users.Add(user);
            _sql.SaveChanges();
            return RedirectToAction("Login", "Home");
        }

        public IActionResult AddProduct()
        {
            ViewBag.Branch = _sql.Branches.ToList();
            ViewBag.Category = _sql.Categories.ToList();
            ViewBag.Colors = _sql.Colors.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product product, IFormFile[] Photo)
        {
            ViewBag.Branch = _sql.Branches.ToList();
            ViewBag.Category = _sql.Categories.ToList();
            ViewBag.Colors = _sql.Colors.ToList();
            product.ProductUserId = Convert.ToInt32(User.FindFirst(ClaimTypes.Sid).Value);
            _sql.Products.Add(product);
            _sql.SaveChanges();
            foreach (var item in Photo)
            {
                string editproduct = Path.GetFileNameWithoutExtension(Path.GetRandomFileName()) + Path.GetExtension(item.FileName);
                using (Stream stream = new FileStream("wwwroot/images/" + editproduct, FileMode.Create))
                {
                    item.CopyTo(stream);
                }
                Photo p = new Photo();
                p.PhotoName = editproduct;
                p.PhotoProductId = product.ProductId;

                _sql.Photos.Add(p);
                _sql.SaveChanges();
            }
            return RedirectToAction("UserProfile", "Home");
        }

        public IActionResult Delete(int id)
        {
            _sql.Photos.RemoveRange(_sql.Photos.Where(x => x.PhotoProductId == id).ToList());
            _sql.SaveChanges();
            var a = _sql.Products.SingleOrDefault(x => x.ProductId == id);
            _sql.Products.Remove(a);
            _sql.SaveChanges();
            return RedirectToAction("UserProfile", "Home");
        }
        public IActionResult Edit(int id)
        {
            ViewBag.Branch = _sql.Branches.ToList();
            ViewBag.Category = _sql.Categories.ToList();
            ViewBag.Colors = _sql.Colors.ToList();
            var a = _sql.Products.SingleOrDefault(x => x.ProductId == id);
            return View(a);
        }

        [HttpPost]
        public IActionResult Edit(int id,Product product)
        {
            var a = _sql.Products.SingleOrDefault(x => x.ProductId == id);
            a.ProductName = product.ProductName;
            a.ProductDescreption = product.ProductDescreption;
            a.ProductPrice = product.ProductPrice;
            a.ProductBranch = product.ProductBranch;
            a.ProductCategory = product.ProductCategory;    
            a.ProductColor=product.ProductColor;

            _sql.SaveChanges();
            return RedirectToAction("userProfile", "Home");
        }
        public IActionResult UserProfile()
        {
            int id = Convert.ToInt32(User.FindFirst(ClaimTypes.Sid).Value);
            return View(_sql.Products.Include(x => x.Photos).Include(x=>x.ProductUser).Where(x => x.ProductUserId == id).ToList());
        }

        public IActionResult ProfileEdit(int id)
        {
            var a = _sql.Users.SingleOrDefault(x => x.UserId == id);
            return View(a);
        }
        [HttpPost]
        public IActionResult ProfileEdit(User user,int id)
        {
            var a = _sql.Users.SingleOrDefault(x => x.UserId == id);
            a.UserName = user.UserName;
            a.UserGender = user.UserGender;
            a.UserPassword = user.UserPassword;
            a.UserNickName = user.UserNickName;
            _sql.SaveChanges();
            return RedirectToAction("UserProfile", "Home");

        }


        public IActionResult ShoppingCart(int id)
        {
            id = Convert.ToInt32(User.FindFirst(ClaimTypes.Sid).Value);
            return View(_sql.Baskets.Include(x => x.BasketProduct).Include(x => x.BasketProduct.Photos).Include(x => x.BasketProduct.ProductBranch).Where(x => x.BasketUserId == id).ToList());

        }
        public IActionResult AddShoppingCart(Basket basket, int id)
        {
            basket.BasketProductId = id;
            basket.BasketUserId = Convert.ToInt32(@User.FindFirst(ClaimTypes.Sid).Value);
            _sql.Baskets.Add(basket);
            _sql.SaveChanges();
            return RedirectToAction("ShoppingCart", "Home");

        }


        public IActionResult Favorites(int id)
        {
            id = Convert.ToInt32(@User.FindFirst(ClaimTypes.Sid).Value);
            return View(_sql.Favorites.Include(x=> x.FavoriteProduct).Include(x=>x.FavoriteProduct.Photos).Include(x=>x.FavoriteProduct.ProductBranch).Where(x => x.FavoriteUserId == id).ToList());
        }
        public IActionResult AddFavorites(Favorite favorite, int id)
        {
            favorite.FavoriteProductId = id;
            favorite.FavoriteUserId = Convert.ToInt32(@User.FindFirst(ClaimTypes.Sid).Value);
            _sql.Favorites.Add(favorite);
            _sql.SaveChanges();
            return RedirectToAction("Shop", "Home");

        }
        public IActionResult DeleteFavorites(int id)
        {
            var a = _sql.Favorites.SingleOrDefault(x => x.FavoriteId == id);
            _sql.Favorites.Remove(a);
            _sql.SaveChanges();
            return RedirectToAction("Favorites", "Home");

        }
        public IActionResult DeleteShoppingCart(int id)
        {
            var a = _sql.Baskets.SingleOrDefault(x => x.BasketId == id);
            _sql.Baskets.Remove(a);
            _sql.SaveChanges();
            return RedirectToAction("ShoppingCart", "Home");

        }




































































        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
