using Microsoft.EntityFrameworkCore;
using Sisgef.Controllers;
using Sisgef.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Sisgef
{
    public class ApplicationContext : DbContext
    {

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        public DbSet<Veiculo> Veiculo { get; set; }

        public DbSet<PostoCombustivel> PostoCombustivel { get; set; }

    }
}
