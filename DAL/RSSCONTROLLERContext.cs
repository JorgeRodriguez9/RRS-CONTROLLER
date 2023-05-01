using System.Collections.Generic;
using System;
using RRS_Controller.Models;
using Microsoft.EntityFrameworkCore;

namespace RRS_Controller.DAL
{
    public class RSSCONTROLLERContext : DbContext
    {

        public RSSCONTROLLERContext(DbContextOptions<RSSCONTROLLERContext> options) : base(options) { }

        public DbSet<ADMIN_PAE> ADMIN_PAEs { get; set; }
        public DbSet<CATEGORY> CATEGORYS { get; set; }
        public DbSet<EVALUATION> EVALUATIONS { get; set; }
        public DbSet<FOOD> FOODS { get; set; }
        public DbSet<FOOD_PRODUCT> FOOD_PRODUCTS { get; set; }
        public DbSet<INSTITUTION> INSTITUTIONS { get; set; }
        public DbSet<MANAGER_PAE> MANAGER_PAEs { get; set; }
        public DbSet<MENU> MENUS { get; set; }
        public DbSet<MENU_FOOD> MENU_FOODS { get; set; }
        public DbSet<NUTRITIONITS_INTS> NUTRITIONITS_INTSs { get; set; }
        public DbSet<NUTRITIONITS_PAE> NUTRITIONITS_PAEs { get; set; }
        public DbSet<PRODUCT> PRODUCTS { get; set; }
        public DbSet<REQUEST> REQUESTS { get; set; }
        public DbSet<REQUEST_MENU> REQUEST_MENUS { get; set; }
        public DbSet<ROLE> ROLES { get; set; }
        public DbSet<SECRETARY_INTS> SECRETARY_INTSs { get; set; }
        public DbSet<SHIPMENT> SHIPMENTS { get; set; }
        public DbSet<SUPPLIER> SUPPLIERS { get; set; }
        public DbSet<UNIT> UNITS { get; set; }
        public DbSet<USER> USERS { get; set; }

    }
}
