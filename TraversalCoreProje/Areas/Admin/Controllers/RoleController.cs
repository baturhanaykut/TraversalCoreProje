using AutoMapper;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.Areas.Admin.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RoleController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;

        public RoleController(RoleManager<AppRole> roleManager, UserManager<AppUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View(_roleManager.Roles.ToList());
        }

        [HttpGet]
        public IActionResult CreateRole() 
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleWiewModel createRoleWiewModel)
        {
            AppRole role = new AppRole()
            {
                Name = createRoleWiewModel.RoleName
            };
            var result = await _roleManager.CreateAsync(role);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
           return View();
        }

        public async Task<IActionResult> Deleterole(int id)
        {
            var value = await _roleManager.FindByIdAsync(id.ToString());
            await _roleManager.DeleteAsync(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdeteRole(int id)
        {
            var value = await _roleManager.FindByIdAsync(id.ToString());
            UpdateRoleWiewModel updateRoleWiewModel = new UpdateRoleWiewModel()
            {
                RoleId = value.Id,
                RoleName = value.Name,
            };
            return View(updateRoleWiewModel);
        }

        [HttpPost]
        public async Task<IActionResult> UpdeteRole(UpdateRoleWiewModel updateRoleWiewModel)
        {
            var value = await _roleManager.FindByIdAsync(updateRoleWiewModel.RoleId.ToString());
            value.Name = updateRoleWiewModel.RoleName;
            await _roleManager.UpdateAsync(value);
            return RedirectToAction("Index");
        }

        public IActionResult UserList()
        {
            var values = _userManager.Users.ToList();
            return View(values);
        }

 
        public async Task<IActionResult> AssignRole(int id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            TempData["UserId"] = user.Id;
            var roles = _roleManager.Roles.ToList();
            var userRoles = await _userManager.GetRolesAsync(user);

            List<RoleAssignViewModel> roleAssignViewModels = new List<RoleAssignViewModel>();
            foreach (var item in roles)
            {
                RoleAssignViewModel model = new RoleAssignViewModel();
                model.RoleId = item.Id;
                model.RoleName = item.Name;
                model.RoleExist = userRoles.Contains(item.Name);
                roleAssignViewModels.Add(model);
            }

            return View(roleAssignViewModels);
        }

        [HttpPost]
        public async Task<IActionResult> AssignRole(List<RoleAssignViewModel> roleAssignViewModels)
        {
            var userid = TempData["UserId"];
            var user = await _userManager.FindByIdAsync(userid.ToString());
            foreach (var item in roleAssignViewModels)
            {
                if (item.RoleExist)
                {
                    await _userManager.AddToRoleAsync(user, item.RoleName);
                }
                else
                {
                    await _userManager.RemoveFromRoleAsync(user, item.RoleName);
                }
            }
            return RedirectToAction("UserList");
        }

    }
}

