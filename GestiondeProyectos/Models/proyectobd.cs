using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GestiondeProyectos.Models
{
    public class proyectobd : DbContext
    {
        public DbSet <Gestion> gestion { get; set; }
    }
}