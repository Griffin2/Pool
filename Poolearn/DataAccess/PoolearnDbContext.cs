using Poolearn.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Poolearn.DataAccess
{
    public class PoolearnDbContext:DbContext
    {
        public PoolearnDbContext():base("PoolearnDatabase")
        {

        }
       
        public DbSet<ThreadViewModel> Pools { get; set; }
    }
}