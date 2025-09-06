﻿using Microsoft.EntityFrameworkCore;

namespace HotelListingApi.Data
{
    public class HotelListingDbContext(DbContextOptions<HotelListingDbContext> options) : DbContext(options)
    {
        public DbSet<Country> Countries { get; set; }

        public DbSet<Hotel> Hotels { get; set; }
    }
}
