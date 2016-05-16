using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Forum.Models;

namespace Forum.Services
{
    public class UserContext : DbContext
    {
        public UserContext()
            : base("UserDB")
        { }

        public DbSet<User> Users { get; set; }
    }
}
