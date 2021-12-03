using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProjectFinal.DAL;
using ProjectFinal.Models;
using ProjectFinal.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFinal.Controllers
{
    //Accouttunuz olmasa course ReadMore ishlemiyecek!!!
    public class AccountController : Controller
    {
        // merkezden idare etme mentiqi 
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public AccountController(AppDbContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
        //Burada Accoutlarla bagli rolelar create edirik ve bu hisse az ishledilir sonra ise commentde atilir...
        //public async Task<IActionResult> CreateRole()
        //{
        //    IdentityRole identityRole1 = new IdentityRole("Member");
        //    IdentityRole identityRole2 = new IdentityRole("Admin");
        //    IdentityRole identityRole3 = new IdentityRole("SuperAdmin");


        //    await _roleManager.CreateAsync(identityRole1);
        //    await _roleManager.CreateAsync(identityRole2);
        //    await _roleManager.CreateAsync(identityRole3);

        //    return Content("ok");
        //}

        //public async Task<IActionResult> CreateSuperAdmin()
        //{
        //    AppUser admin = new AppUser
        //    {
        //        UserName = "huseyn123",
        //        FullName = "Mammadov Huseyn",
        //        IsAdmin = true,
        //    };

        //    //passsword: huseyn123
        //    await _userManager.CreateAsync(admin, "huseyn123");
        //    await _userManager.AddToRoleAsync(admin, "SuperAdmin");

        //    return Ok();
        //}

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(MemberRegisterModel registerModel)
        {
           
            if (!ModelState.IsValid)
            {
                return View();
            }

            AppUser existUser = await _userManager.FindByNameAsync(registerModel.UserName);
            if (existUser != null)
            {
                ModelState.AddModelError("UserName", "UserName already taken");
                return View();
            }
            AppUser newUser = new AppUser()
            {
                FullName = registerModel.FullName,
                UserName = registerModel.UserName,
                IsAdmin = false,
            };

            var result = await _userManager.CreateAsync(newUser, registerModel.Password);

            if (!result.Succeeded)
            {
                foreach (var item in result.Errors)
                {
                    if (item.Code == "PasswordTooShort")
                    {
                        item.Description = "Passwordun uzunlugu 8-den kicik ola bilmez";
                    }
                    else if (item.Description == "ConfirmedPassword and Password do not match.")
                    {
                        item.Description = "Alinmadi";
                    }
                    ModelState.AddModelError("", item.Description);
                }
                return View();
            }

            await _userManager.AddToRoleAsync(newUser, "Member");
            await _signInManager.SignInAsync(newUser, true);

            return RedirectToAction("index", "home");
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(MemberLoginModel loginModel)
        {

            AppUser user = await _userManager.FindByNameAsync(loginModel.UserName);

            if (user == null || user.IsAdmin)
            {
                ModelState.AddModelError("", "UserName or Password is incorrect");
                return View();
            }

            var result = await _signInManager.PasswordSignInAsync(user, loginModel.Password, loginModel.IsPersistent, true);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "UserName or Password is incorrect");
                return View();
            }

            return RedirectToAction("index", "home");
        }
      
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("login");
        }
        
        public async Task<IActionResult> Edit()
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            MemberEditModel member = new MemberEditModel
            {
                FullName = user.FullName,
                UserName = user.UserName,
            };
            return View(member);
        }
      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(MemberEditModel member)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (_userManager.Users.Any(x => x.UserName == member.UserName && x.Id != user.Id))
            {
                ModelState.AddModelError("UserName", "UserName already taken!");
                return View();
            }

            if (!ModelState.IsValid)
            {
                return View();
            }

            user.UserName = member.UserName;
            user.FullName = member.FullName;


            if (!string.IsNullOrWhiteSpace(member.Password))
            {
                if (string.IsNullOrWhiteSpace(member.CurrentPassword))
                {
                    ModelState.AddModelError("CurrentPassword", "CurrentPassword can not be emtpy");
                    return View();
                }

                var result = await _userManager.ChangePasswordAsync(user, member.CurrentPassword, member.Password);
                if (!result.Succeeded)
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }

                    return View();
                }
            }
            await _userManager.UpdateAsync(user);

            await _signInManager.SignInAsync(user, true);
            return RedirectToAction("index", "home");
        }
    }
}