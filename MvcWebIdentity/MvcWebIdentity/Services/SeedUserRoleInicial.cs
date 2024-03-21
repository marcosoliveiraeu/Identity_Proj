﻿using MvcWebIdentity.Context;
using MvcWebIdentity.Services;
using Microsoft.AspNetCore.Identity;
using System.Data;

namespace MvcWebIdentity.Services
{
    public class SeedUserRoleInicial : ISeedUserRoleInicial
    {

        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public SeedUserRoleInicial(UserManager<IdentityUser> user
                                  , RoleManager<IdentityRole> role)
        {
            _userManager = user;
            _roleManager = role;
        }


        public async Task SeedRolesAsync()
        {

            if (!await _roleManager.RoleExistsAsync("User"))
            {
                IdentityRole role = new IdentityRole();
                role.Name = "User";
                role.NormalizedName = "USER";
                role.ConcurrencyStamp = Guid.NewGuid().ToString();

               
                IdentityResult identityResult = await _roleManager.CreateAsync(role);
            }

            if (!await _roleManager.RoleExistsAsync("Admin"))
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Admin";
                role.NormalizedName = "ADMIN";
                role.ConcurrencyStamp = Guid.NewGuid().ToString();


                IdentityResult identityResult = await _roleManager.CreateAsync(role);

            }

            if (!await _roleManager.RoleExistsAsync("Gerente"))
            {


                IdentityRole role = new IdentityRole();
                role.Name = "Gerente";
                role.NormalizedName = "GERENTE";
                role.ConcurrencyStamp = Guid.NewGuid().ToString();


                IdentityResult identityResult = await _roleManager.CreateAsync(role);



            }

        }

        public async Task SeedUserAsync()
        {

            if (await _userManager.FindByEmailAsync("usuario@localhost") == null)
            {
                IdentityUser user = new IdentityUser();

                user.UserName = "usuario@localhost";
                user.Email = "usuario@localhost";
                user.NormalizedUserName = "USUARIO@LOCALHOST";
                user.NormalizedEmail = "USUARIO@LOCALHOST";
                user.EmailConfirmed = true;
                user.LockoutEnabled = false;
                user.SecurityStamp = Guid.NewGuid().ToString();

                IdentityResult result = await _userManager.CreateAsync(user, "Numsei#2023");



                if (result.Succeeded)
                {
                    await _userManager.CreateAsync(user, "User");
                }

            }


            if (await _userManager.FindByEmailAsync("admin@localhost") == null)
            {
                IdentityUser user = new IdentityUser();

                user.UserName = "admin@localhost";
                user.Email = "admin@localhost";
                user.NormalizedUserName = "ADMIN@LOCALHOST";
                user.NormalizedEmail = "ADMIN@LOCALHOST";
                user.EmailConfirmed = true;
                user.LockoutEnabled = false;
                user.SecurityStamp = Guid.NewGuid().ToString();

                IdentityResult result = await _userManager.CreateAsync(user, "Numsei#2023");



                if (result.Succeeded)
                {
                    await _userManager.CreateAsync(user, "Admin");
                }

            }


            if (await _userManager.FindByEmailAsync("gerente@localhost") == null)
            {
                IdentityUser user = new IdentityUser();

                user.UserName = "gerente@localhost";
                user.Email = "gerente@localhost";
                user.NormalizedUserName = "GERENTE@LOCALHOST";
                user.NormalizedEmail = "GERENTE@LOCALHOST";
                user.EmailConfirmed = true;
                user.LockoutEnabled = false;
                user.SecurityStamp = Guid.NewGuid().ToString();

                IdentityResult result = await _userManager.CreateAsync(user, "Numsei#2023");



                if (result.Succeeded)
                {
                    await _userManager.CreateAsync(user, "Gerente");
                }

            }


        }


    }
}
