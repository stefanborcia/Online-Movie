﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Movie_DataAccess.Data;
using Movie_Models;
using Movie_Utility;

namespace Movie_DataAccess.DbInitializer
{
    public class DbInitializer : IDbInitializer
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _db;

        public DbInitializer(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _db = db;
        }

        public void Initialize()
        {
            // Migrations if they are not applied
            try
            {
                if (_db.Database.GetPendingMigrations().Count() > 0)
                {
                    _db.Database.Migrate();
                }
            }catch(Exception ex) { }
            // Create roles if they are not created
            if (!_roleManager.RoleExistsAsync(StaticDetails.Role_Customer).GetAwaiter().GetResult())
            {
                _roleManager.CreateAsync(new IdentityRole(StaticDetails.Role_Customer)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(StaticDetails.Role_Company)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(StaticDetails.Role_Admin)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(StaticDetails.Role_Employee)).GetAwaiter().GetResult();

                // If roles are not created, then we will create admin user as well
                _userManager.CreateAsync(new ApplicationUser
                    {
                        UserName = "testadmin@gmail.com",
                        Email = "testadmin@gmail.com",
                        Name = "Borcia Stefan Iulian",
                        PhoneNumber = "45287996147",
                        StreetAddress = "Zonnestraat 13",
                        State = "Oost-Vlaanderen",
                        PostalCode = "9500",
                        City = "Ronse"
                    },
                    "Admin123.").GetAwaiter().GetResult();

                ApplicationUser user = _db.ApplicationUsers.FirstOrDefault(u => u.Email == "testadmin@gmail.com");
                _userManager.AddToRoleAsync(user, StaticDetails.Role_Admin).GetAwaiter().GetResult();
            }
            return;
        }
    }
}
