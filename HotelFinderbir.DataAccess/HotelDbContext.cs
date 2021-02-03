using HotelFinderbir.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelFinderbir.DataAccess
{
    public class HotelDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=DESKTOP-IT4752E; Database=HotelDBbir;uid=sa;pwd=12345;");
        }

        public DbSet<Hotel> Hotels { get; set; }
    }
}
